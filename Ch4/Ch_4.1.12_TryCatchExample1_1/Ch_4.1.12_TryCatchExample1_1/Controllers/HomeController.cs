using Ch_4._1._12_TryCatchExample1_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Ch_4._1._12_TryCatchExample1_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Pair p1 = new Pair(5, 10);
            Pair p2 = new Pair(3, 7);
            Pair p3 = new Pair(14, 3);
            Pair p4 = new Pair(17, 2);
            Pair p5 = new Pair(25, 10);
            Pair p6 = new Pair(15,0);
            Pair p7 = new Pair(6, 3);
            Pair p8 = new Pair(119, 10);
            List<int> pRatio = new List<int>();
            
            try
            {
                pRatio.Add(p1.X / p1.Y);
                pRatio.Add(p2.X / p2.Y);
                pRatio.Add(p3.X / p3.Y);
                pRatio.Add(p4.X / p4.Y);
                pRatio.Add(p5.X / p5.Y);
                pRatio.Add(p6.X / p6.Y);
                pRatio.Add(p7.X / p7.Y);
                pRatio.Add(p8.X / p8.Y);
            }
            catch (DivideByZeroException ex)
            {
                ViewBag.ErrorMessage = "Data is not valid";
            }
     
            
            return View(pRatio);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}