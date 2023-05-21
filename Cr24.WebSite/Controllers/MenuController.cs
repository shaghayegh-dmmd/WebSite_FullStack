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
    public class MenuController : Controller
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

                });
          
                menuModel.ChildList.Add(new MenuModel()
                {
                    Id = 3,
                    ParentId = 1,
                    DisplayName = "فایل ها",
                    ControlName = "Attachment",
                    ActionName = "AttachmentIndex",

                });

                menuModel.ChildList.Add(new MenuModel()
                {
                    Id = 4,
                    ParentId = 1,
                    DisplayName = "اخبار",
                    ControlName = "News",
                    ActionName = "NewsIndex",

                });
            
            return menuModel;
        }

    }
}