using StoreyApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreyApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetMeasurers()
        {
            MeasurerService measurerService = new MeasurerService();

            var measurers = measurerService.GetMeasurers().Result;

            var recordsTotal = measurers.Count();

            return Json(new { draw = "", recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = measurers });
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