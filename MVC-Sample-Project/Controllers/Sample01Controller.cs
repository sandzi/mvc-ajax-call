using MVC_Sample_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sample_Project.Controllers
{
    public class Sample01Controller : Controller
    {

        // GET: Sample01
        public ActionResult Index()
        {
            return View();
        }

        //In this HttpPost Return String Method we use the @Ajax.Beginform Helper
        [HttpPost]
        public string Index(SampleViewModel m)
        {
            var result = int.Parse(m.txtFirstNo) + int.Parse(m.txtSecondNo);
            return result.ToString();
        }
    }
}