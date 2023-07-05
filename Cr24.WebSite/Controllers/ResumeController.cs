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
    public class ResumeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ResumeDetailInfo()
        {
            return View();
        }
        public ActionResult CreateResume(ResumeModel fileData)
        {
            var res = ResumeService.CreateResume(fileData);

            return Json(new { res }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult EditResume(ResumeModel fileData)
        {
            var res = ResumeService.EditResume(fileData);

            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteResume(long id)
        {
            var res = ResumeService.DeleteResume(id);

            return Json(res, JsonRequestBehavior.AllowGet);
        }

    }
}