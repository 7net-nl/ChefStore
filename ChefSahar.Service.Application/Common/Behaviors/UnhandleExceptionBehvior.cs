using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Common.Behaviors
{
    public class UnhandleExceptionBehvior<TRequest, TRespons> : IPipelineBehavior<TRequest, TRespons>
        where TRequest : IRequest<TRespons>
    {
        private readonly ILogger<TRequest> logger;

        public UnhandleExceptionBehvior(ILogger<TRequest> logger)
        {
            this.logger = logger;
        }
        public async Task<TRespons> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TRespons> next)
        {
            try
            {
                return await next();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, typeof(TRequest).Name, request);

                throw;
            }
        }
    }
}
