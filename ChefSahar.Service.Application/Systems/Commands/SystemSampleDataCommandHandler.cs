using ChefSahar.Domain.Contract.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Systems.Commands
{
    public class SystemSampleDataCommandHandler : IRequestHandler<SystemSampleDataCommand,string>
    {
        private readonly IDbContext context;
      

        public SystemSampleDataCommandHandler(IDbContext context)
        {
            this.context = context;
  
        }
        public async Task<string> Handle(SystemSampleDataCommand request, CancellationToken cancellationToken)
        {
           var Result =  new SampleDataSeeder(context);

            Result.Seed();

            context.SaveChanges();

            return "Complete";
        }
    }
}
