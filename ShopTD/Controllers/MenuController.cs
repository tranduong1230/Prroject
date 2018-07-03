using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopTD.Models;

namespace ShopTD.Controllers
{
    public class MenuController : Controller
    {
        ShopTDEntities db = new ShopTDEntities();
        // GET: Menu
        public PartialViewResult Menu_first()
        {
            var listMenu = db.Menus.ToList();
            return PartialView(listMenu);
        }
        public PartialViewResult Partial_subMenu(int parent_id)
        {
            var subMenu = db.Menus.Where(n => n.Parent_ID == parent_id).ToList();
            return PartialView(subMenu);
        }
    }
}