﻿using OnlineShoppingStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductRepository repository;
        public int PageSize = 2;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
       public ViewResult List(int page = 1)
       {

            return View(repository.Products
                    .OrderBy(p => p.ProductId)
                    .Skip((page -1) * PageSize)
                    .Take(PageSize)
                
                );
        }
    }
}