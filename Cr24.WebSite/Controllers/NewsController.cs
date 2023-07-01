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
    public class NewsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewsDetailInfo()
        {
            return View();
        }

        public ActionResult GetAllNews([DataSourceRequest] DataSourceRequest request)
        {
            var res = NewsService.GetAllNews();

            return Json(res.ToDataSourceResult(request));
        }

        public ActionResult CreateNews(NewsModel fileData)
        {
            var res = NewsService.CreateNews(fileData);

            return Json(new { res }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult EditNews(NewsModel fileData)
        {
            var res = NewsService.EditNews(fileData);

            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteNews(long id)
        {
            var res = NewsService.DeleteNews(id);

            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Async_SaveImageNews(HttpPostedFileBase file)
        {
            if (file != null)
            {
                Session["Async_SaveImageNews" + User.Identity.Name] = file;
            }

            return Content("");
        }

        public ActionResult Async_DeleteImageNews(string[] fileNames)
        {
            if (fileNames != null)
            {
                foreach (var fullName in fileNames)
                {
                    var fileName = Path.GetFileName(fullName);
                    var physicalPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);

                    if (System.IO.File.Exists(physicalPath))
                    {
                        // The files are not actually removed in this demo
                        // System.IO.File.Delete(physicalPath);
                    }
                }
            }
            Session["Async_SaveImageNews" + User.Identity.Name] = null;
            
            return Content("");
        }

        public ActionResult Save(NewsModel saveItems)
        {

            var isSaved = false;

            //if (!ModelState.IsValid)
            //{
            //    var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
            //    var errorKeys = ModelState.Where(x => x.Value.Errors.Count > 0)
            //        .Select(kvp => kvp.Key
            //        );

            //    var allKeys = ModelState.Keys.ToList();
            //    return Json(new { IsSaved = false, IsValid = false, errors, errorKeys, allKeys }, JsonRequestBehavior.AllowGet);
            //}

            try
            {
                if (saveItems.Id == 0)
                {
                    
                    if (Session["Async_SaveImageNews" + User.Identity.Name] != null)
                    {
                        var Image = ((HttpPostedFileBase)Session["Async_SaveImageNews" + User.Identity.Name]);
                        saveItems.ImageId = "," + AddAttachment(Image) + ",";
                    }
                    var attachmentsvc = CreateNews(saveItems);

                    Session["Async_SaveImageNews" + User.Identity.Name] = null;

                    return Json(new
                    {
                        IsSaved = true,
                        IsValid = true,
                        Message = "فایل با موفقیت ذخیره شد",
                    }, JsonRequestBehavior.AllowGet);

                    //}

                    //return Json(new
                    //{
                    //    IsSaved = true,
                    //    IsValid = true,
                    //    Message = "فایل ذخیره نشد",
                    //}, JsonRequestBehavior.AllowGet);
                }

                else
                {
                    return Json(
                        new
                        {
                            IsSaved = false,
                            IsValid = false,
                            Message = "فایلی برای ذخیره کردن یافت نشد"
                        }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(
                    new
                    {
                        IsSaved = false,
                        IsValid = false,
                        ex.Message,
                    }, JsonRequestBehavior.AllowGet);
            }
        }

        public long AddAttachment(HttpPostedFileBase att)
        {
            Stream str = att.InputStream;
            byte[] content = new byte[str.Length];
            str.Read(content, 0, content.Length);

            var attObj = new AttachmentModel
            {
                FileName = att.FileName,
                SystemFileType = att.ContentType,
                CreationDate = DateTime.Now,
                FileContent = content
            };
            var res = WebSiteService.CreatAttachment(attObj);
            return res;
        }

    }
}