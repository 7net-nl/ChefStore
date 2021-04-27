using ChefSahar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Infrascture.DataBase.EF
{
    public static class SeedHelper
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Recipe>().HasData(new Recipe
            {
                CookTime = 20,
                Description = "thi is For Description",
                ID = 1,
                ImageUrl = "/Images/Test.jpg",
                NumberServing = 3,
                TimePrep = 15,
                Title = "This Is Title",
                VideoUrl = "/Images/Video.mp4"
            });
        }
    }
}
