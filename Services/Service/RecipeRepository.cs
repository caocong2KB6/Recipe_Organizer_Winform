﻿using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class RecipeRepository : RepositoryBase<Recipe>
    {
        Recipe_Organizer_PRN211Context _context;
        DbSet<Recipe> _dbSet;

        public RecipeRepository()
        {
            _context = new Recipe_Organizer_PRN211Context();
            _dbSet = _context.Set<Recipe>();
        }
    }
}
