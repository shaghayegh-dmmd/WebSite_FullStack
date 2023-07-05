using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cr24.WebSite.DAL.Models;

namespace Cr24.WebSite.BLL
{
    public class NewsService
    {
        public static bool CreateNews(NewsModel fileData)
        {
            try
            {
                var newFile = new User_News
                {
                    CreationDate = DateTime.Now,
                    Description = fileData.Description,
                    Title = fileData.Title,
                    ImageId = fileData.ImageId,
                    HeadLine = fileData.HeadLine,
                    Reference = fileData.Reference

                };

                using (var db = new WebEntity())
                {
                    db.User_News.Add(newFile);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EditNews(NewsModel fileData)
        {
            try
            {
                using (var db = new WebEntity())
                {
                    var contObj = db.User_News.First(o => o.Id == fileData.Id);
                    contObj.Title = fileData.Title;
                    contObj.Description = fileData.Description;
                    contObj.ImageId = fileData.ImageId;
                    contObj.Reference = fileData.Reference;
                    contObj.HeadLine = fileData.HeadLine;

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static List<NewsModel> GetAllNews()
        {

            using (var db = new WebEntity())
            {
                return db.User_News.Select(o => new NewsModel
                {
                    Title = o.Title,
                    Description = o.Description,
                    ImageId = o.ImageId,
                    Reference = o.Reference,
                    HeadLine = o.HeadLine,
                    CreationDate = o.CreationDate

                }).ToList();
            }
        }

        public static bool DeleteNews(long id)
        {

            try
            {
                using (var db = new WebEntity())
                {
                    var contObj = db.User_News.First(o => o.Id == id);
                    db.User_News.Remove(contObj);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

    }
}
