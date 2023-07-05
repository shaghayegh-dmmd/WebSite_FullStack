using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cr24.WebSite.BLL;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Cr24.WebSite.DAL;
using Cr24.WebSite.DAL.Models;
using System.IO;

namespace Cr24.WebSite.Controllers
{
    public class ContactUsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllContactUs([DataSourceRequest] DataSourceRequest request)
        {
            var res = ContactUsService.GetAllContactUs();

            return Json(res.ToDataSourceResult(request));
        }


    }
}