using EShoppingCart.Data;
using EShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppingCart.Models;
using Microsoft.EntityFrameworkCore;

namespace EShoppingCart.Repositories
{
    //This repository will inherit from ICategoryRepository(The interface which holds the required for this repository)
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        //Below constructor in this repository is used to inject the ApplicationDbContext service to interact with the database
        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Added relevant property as shown below
        public IEnumerable<Category> Categories => _applicationDbContext.Categories;

    }
}
