using ChefSahar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Domain.Contract.Interfaces
{
    public interface IDataSet
    {
         DbSet<Recipe> Recipe { get; set; }
         DbSet<Instruction> Instructions { get; set; }
         DbSet<Ingridient> Ingridients { get; set; }
         DbSet<Category>  Categories { get; set; }
        DbSet<Tag>  Tags { get; set; }

    }
}
