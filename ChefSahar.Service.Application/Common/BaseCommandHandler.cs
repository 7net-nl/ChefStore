using AutoMapper;
using ChefSahar.Domain.Contract.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Common
{
    public abstract class BaseCommandHandler<TRequest, TRespons, IRepo, TEntity, TEntityDto, TResult> : IRequestHandler<TRequest, TRespons>
        where TRequest : IRequest<TRespons>
        where IRepo : IRepository
        
    {
        protected readonly IRepo repo;
        protected readonly IMapper mapper;
        protected readonly ILogger<IRepo> logger;
        protected TEntity  Entity { get; set; }
        protected TEntityDto  EntityDto { get; set; }
        protected TResult  Result { get; set; }
        public BaseCommandHandler(IRepo repo,IMapper mapper,ILogger<IRepo> logger)
        {
            this.repo = repo;
            this.mapper = mapper;
            this.logger = logger;
        }
        public abstract Task<TRespons> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
