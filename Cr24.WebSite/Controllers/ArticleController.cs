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

namespace Cr24.WebSite.Controllers
{
    public class ArticleController: Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ArticleDetailInfo()
        {
            return View();
        }

        public ActionResult GetAllArticle([DataSourceRequest] DataSourceRequest request)
        {
            var res = WebSiteService.GetAllArticle();

            return Json(res.ToDataSourceResult(request));
        }

        public ActionResult CreatArticle(ArticleModel fileData)
        {
            var res = WebSiteService.CreatArticle(fileData);

            return Json(new { res }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult EditeArticle(ArticleModel fileData)
        {
            var res = WebSiteService.EditeArticle(fileData);

            return Json(res, JsonRequestBehavior.AllowGet);
        }
        public ActionResult DeleteArticle(long id)
        {
            var res = WebSiteService.DeleteArticle(id);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}