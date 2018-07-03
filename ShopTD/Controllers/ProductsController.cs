using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopTD.Models;
namespace ShopTD.Controllers
{
    public class ProductsController : Controller
    {
        //connection
        ShopTDEntities db = new ShopTDEntities();
        // GET: Products
        public ActionResult Index()
        {            
            return View();
        }
        public PartialViewResult listProductsPartial()
        {
            var products = db.Products.ToList();
            return PartialView(products);
        }        
    }
}