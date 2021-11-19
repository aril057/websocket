using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebSocketClientSample.Models;

namespace MVCWebSocketClientSample.Controllers
{
    public class HomeController : Controller
    {
        WebSocketClient wb = new WebSocketClient();
        public ActionResult Index()
        {
            return View();
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

        public ContentResult Test()
        {
            wb.Connect();
            return Content(wb.output);
        }

        public ContentResult GetRFIDPhoto()
        {
            wb.GetRFIDPhoto();
            return Content(wb.output);
        }

        [HttpGet]
        public ContentResult msgR()
        {
            return Content(wb.received);
        }
    }
}