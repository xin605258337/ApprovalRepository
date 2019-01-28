using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Approval.Mvc.Controllers
{
    public class ApprovalConfigurationController : Controller
    {
        // GET: ApprovalConfiguration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();

        }

        public ActionResult Update()
        {
            return View();
        }
    }
}