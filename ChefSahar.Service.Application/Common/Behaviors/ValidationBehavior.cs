using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace ChefSahar.Service.Application.Common.Behaviors
{
    public class ValidationBehavior<TRequest, TRespons> : IPipelineBehavior<TRequest, TRespons>
        where TRequest : IRequest<TRespons>
    {
        private readonly IEnumerable<IValidator<TRequest>> validators;
        private readonly ILogger<TRequest> logger;

        public ValidationContext  Context { get; set; }
        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators,ILogger<TRequest> logger)
        {
            this.validators = validators;
            this.logger = logger;
        }
        public async Task<TRespons> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TRespons> next)
        {
            logger.LogInformation("Validator Handle",request);

            if(validators.Count() > 0)
            {
                logger.LogInformation("Validator Check Start");

                Context = new ValidationContext(request);

                var Failures = validators.Select(c => c.Validate(Context)).SelectMany(d => d.Errors).Where(f => f != null).ToList();

                if (Failures.Count > 0)
                {
                    logger.LogError("Validator Not Ok", Failures);

                    throw new ValidationException(Failures);
                }
            }

          return await next();
        }
    }
}
