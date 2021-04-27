using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ChefSahar.Service.Application.Common.Behaviors
{
    public class LoggerRequestBehavior<TRequest,TRespons> : IPipelineBehavior<TRequest,TRespons>
        where TRequest : IRequest<TRespons>
    {
        private readonly ILogger<TRequest> logger;

        public LoggerRequestBehavior(ILogger<TRequest> logger)
        {
            this.logger = logger;
        }

        public async Task<TRespons> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TRespons> next)
        {
            logger.LogInformation($"Request Send {request.GetType().Name} : {request}", request);

            return await next();
        }
    }
}
