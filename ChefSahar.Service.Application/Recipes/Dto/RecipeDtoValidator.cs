using ChefSahar.Service.Application.Common;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Dto
{
    public class RecipeDtoValidator<TCommand> : AbstractValidator<TCommand> where TCommand:RecipeDto
    {
        public RecipeDtoValidator() : base()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.CookTime).NotNull();
            RuleFor(c => c.Description).NotNull().ChildRules(d => d.RuleFor(f => f.Length).LessThan(1000));
            RuleFor(c => c.ID).NotNull();
            RuleFor(c => c.ImageUrl).NotEmpty().NotNull().ChildRules(d => d.RuleFor(e => e.Length).LessThan(1000).GreaterThan(5));
            RuleFor(c => c.VideoUrl).NotEmpty().NotNull().ChildRules(d => d.RuleFor(e => e.Length).LessThan(1000).GreaterThan(5));
            RuleFor(c => c.Title).NotEmpty().NotNull().ChildRules(d => d.RuleFor(e => e.Length).LessThan(500).GreaterThan(5));
            RuleFor(c => c.NumberServing).NotNull();
            RuleFor(c => c.TimePrep).NotNull();
            RuleFor(c => c.Views).NotNull();
            
        }
    }
}
