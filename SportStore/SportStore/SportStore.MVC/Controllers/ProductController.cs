using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStore.Domain.Entityes;
using SportStore.Domain.Abstract;

namespace SportStore.MVC.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository repository;
        public ProductController(IProductRepository rep)
        {
            repository = rep;
        }
        // GET: Product
        public ActionResult List()
        {
            return View(repository.Products);
        }
    }
}