﻿using System;
using System.Collections.Generic;

namespace Services.Models
{
    public partial class Recipe
    {
        public Recipe()
        {
            MealPlannings = new HashSet<MealPlanning>();
            Categories = new HashSet<Category>();
            Users = new HashSet<User>();
        }

        public int RecipeId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Ingredient { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Status { get; set; } = null!;
        public string? Img { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<MealPlanning> MealPlannings { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
