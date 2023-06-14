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
    public class ArticleController: Controller
    {
        #region Article's Info
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

        public ActionResult Async_SaveImage(HttpPostedFileBase file)
        {
            if (file != null)
            {
                
                Session["Async_SaveImageArticle" + User.Identity.Name] = file;
            }

            return Content("");
        }
        public ActionResult Async_DeleteImageArticle(string[] fileNames)
        {


            if (fileNames != null)
            {
                foreach (var fullName in fileNames)
                {
                    var fileName = Path.GetFileName(fullName);
                    var physicalPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);

                    // TODO: Verify user permissions

                    if (System.IO.File.Exists(physicalPath))
                    {
                        // The files are not actually removed in this demo
                        // System.IO.File.Delete(physicalPath);
                    }
                }
            }
            Session["Async_SaveImageArticle" + User.Identity.Name] = null;
            // Return an empty string to signify success
            return Content("");
        }
        public ActionResult Async_SaveFile(HttpPostedFileBase file)
        {

            if (file != null)
            {
                Session["Async_SaveFileArticle" + User.Identity.Name] = file;
            }

            return Content("");
        }
        public ActionResult Async_DeleteFile(string[] fileNames)
        {


            if (fileNames != null)
            {
                foreach (var fullName in fileNames)
                {
                    var fileName = Path.GetFileName(fullName);
                    var physicalPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);

                    // TODO: Verify user permissions

                    if (System.IO.File.Exists(physicalPath))
                    {
                        // The files are not actually removed in this demo
                        // System.IO.File.Delete(physicalPath);
                    }
                }
            }
            Session["Async_SaveFileArticle" + User.Identity.Name] = null;
            // Return an empty string to signify success
            return Content("");
        }
        public long AddAttachment(HttpPostedFileBase att)
        {
           Stream str = att.InputStream;
            byte[] content = new byte[str.Length];
            str.Read(content, 0, content.Length);

            var attObj = new AttachmentModel
            {
                FileName = att.FileName,
                CreationDate = DateTime.Now,
                FileContent = content
            };
            var res = WebSiteService.CreatAttachment(attObj);
            return attObj.Id;
        }
        public ActionResult Save(ArticleModel attachmentViewModel)
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
                if (attachmentViewModel.Id == 0)
                {
                    if (Session["Async_SaveFileArticle" + User.Identity.Name] != null)
                    {
                        var file = ((HttpPostedFileBase)Session["Async_SaveFileArticle" + User.Identity.Name]);
                    attachmentViewModel.FileId = AddAttachment(file);
                    }
                    
                    if (Session["Async_SaveImageArticle" + User.Identity.Name] != null)
                    {
                        var Image = ((HttpPostedFileBase)Session["Async_SaveImageArticle" + User.Identity.Name]);
                        attachmentViewModel.ImageId = "," + AddAttachment(Image) + ",";
                    }
                        var attachmentsvc = CreatArticle(attachmentViewModel);


                        Session["Async_SaveFileArticle" + User.Identity.Name] = null;
                        Session["Async_SaveImageArticle" + User.Identity.Name] = null;
                    
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
        #endregion
        #region Article's Tag
        public JsonResult GetAllTags([DataSourceRequest] DataSourceRequest request)
        {
            List<TagModel> lstTag = WebSiteService.GetAllTags();
            return Json(lstTag, JsonRequestBehavior.AllowGet);
        }
        public ActionResult SaveTag(string tagName)
        {
            bool result = false;
            string lst = string.Empty;
            var tagInfo = WebSiteService.GetTagByName(tagName);
            if (tagInfo == null)
            {
                result = WebSiteService.SaveTag(tagName);
                
            }

            return Json(new {Result = result}, "text/plain");
        }
        #endregion
    }
}