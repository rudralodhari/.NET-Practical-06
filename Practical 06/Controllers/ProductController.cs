using ProductCatlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductCatlog.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<product> P = getproduct();
            return View(P);
        }

        private List<product> getproduct()
        {
            List<product> P = new List<product>();

            product P1 = new product
            {
                id = 1,
                name = "Running Shoes",
                description = "Lightweight red running shoes for everyday comfort.",
                qty = 10,
                price = 2499,
                imgurl = "~/Content/Images/running-shoes.jpg",
            };

            product P2 = new product
            {
                id = 2,
                name = "Digital Camera",
                description = "A compact camera for everyday photography.",
                qty = 5,
                price = 45999,
                imgurl = "~/Content/Images/digital-camera.jpg",
            };

            P.Add(P1);
            P.Add(P2);


            return P;

        }

        public ActionResult Detail(int id)
        {
            List<product> P = getproduct();
            product P1 = new product();
            P1 = P.FirstOrDefault(H  => H.id == id);

            return View(P1);
        }
    }
}