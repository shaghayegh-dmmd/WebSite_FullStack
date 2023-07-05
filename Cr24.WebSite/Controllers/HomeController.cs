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
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadMenu()
        {
            MenuModel menuModel = CreateActionMenu();

            return PartialView("_PartialMenu", menuModel);
        }

        private MenuModel CreateActionMenu()
        {


            MenuModel menuModel = new MenuModel()
            {
                Id = 1,
                ChildList = new List<MenuModel>()
            };

                menuModel.ChildList.Add(new MenuModel()
                {

                    Id = 2,
                    ParentId = 1,
                    DisplayName = "مقاله ها",
                    ControlName = "Article",
                    ActionName = "Index",
                    IconUrl = "/Content/Images/Vector.svg"

                });
          
                menuModel.ChildList.Add(new MenuModel()
                {
                    Id = 3,
                    ParentId = 1,
                    DisplayName = "فایل ها",
                    ControlName = "Attachment",
                    ActionName = "Index",
                    IconUrl = "/Content/Images/upload.svg"

                });

                menuModel.ChildList.Add(new MenuModel()
                {
                    Id = 4,
                    ParentId = 1,
                    DisplayName = "اخبار",
                    ControlName = "News",
                    ActionName = "Index",
                    IconUrl = "/Content/Images/newspaper.svg"
                });

            menuModel.ChildList.Add(new MenuModel()
            {
                Id = 4,
                ParentId = 1,
                DisplayName = "فرم تماس با ما",
                ControlName = "ContactUs",
                ActionName = "GetAllContactUs",
                IconUrl = "/Content/Images/newspaper.svg"
            });

            menuModel.ChildList.Add(new MenuModel()
            {
                Id = 4,
                ParentId = 1,
                DisplayName = "فرم رزومه",
                ControlName = "Resume",
                ActionName = "ResumeDetailInfo",
                IconUrl = "/Content/Images/newspaper.svg"
            });

            return menuModel;
        }

    }
}