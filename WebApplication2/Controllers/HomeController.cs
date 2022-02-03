using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.DataAccesLayer;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var products = _dbContext.Products.Include(x => x.Category).ToList();

            //var Clothes = new Category { Id = 1, Name = "Clothes" };
            //var Shoes = new Category { Id = 1, Name = "Shoes" };

            //var products = new List<Product>
            //{
            //    new Product {Id = 1, Name = "T-Shirt", Price = 22, Category = Clothes },
            //    new Product {Id = 2, Name = "Dress", Price = 65, Category = Clothes},
            //    new Product {Id = 3, Name = "Shoes", Price = 10, Category = Shoes}
            //};

            return View(products);
        }

        public IActionResult Detail() 
        {
            var Clothes = new Category { Id = 1, Name = "Clothes" };

            return View(new Product {Id = 1, Name = "T-Shirt", Price = 22, Category = Clothes });
        }

        public IActionResult Create() 
        {
            return View();
        }
    }
}
