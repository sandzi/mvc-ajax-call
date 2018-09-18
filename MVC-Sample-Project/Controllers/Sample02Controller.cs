using MVC_Sample_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sample_Project.Controllers
{
    public class Sample02Controller : Controller
    {
        // GET: Sample02
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(SampleViewModel m)
        {
            var result = int.Parse(m.txtFirstNo) + int.Parse(m.txtSecondNo);
            return result.ToString();
        }
    }
}