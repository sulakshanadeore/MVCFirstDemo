using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstDemo.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products

        //actions return actionresult----result of a action
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchProduct(int id)
        {
            //content=string
            return Content("Tried to find the product id= " + id);
        }
        public ActionResult AddProduct()
        {
            //Add product logic

            //Same controller -different action
            return RedirectToAction("Index") ;
        }

        public ActionResult GoToGoogle()
        {

            return Redirect("https://www.google.com");
        }


        public ActionResult DeleteProduct()
        {

            return View();
        }

        [HttpPost]
        public ActionResult DeleteProduct(int id)
        {

            return View();
        }

        public ActionResult GoToIndexPageofHomeController()
        {

            //Different controller and action
            return RedirectToAction("Contact", "Home");
        }

    }
}