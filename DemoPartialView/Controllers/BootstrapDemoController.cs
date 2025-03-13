using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoPartialView.Controllers
{
    public class BootstrapDemoController : Controller
    {
        // GET: Default
        public PartialViewResult Header()
        {
            return PartialView("_Header");
        }
    }
}