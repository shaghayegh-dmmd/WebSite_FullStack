using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cr24.WebSite.DAL.Models;

namespace Cr24.WebSite.BLL
{
    class WebSiteService
    {
        #region Article
        public bool CreatArticle(User_Article fileData)
        {
            try
            {
                var newFile = new User_Article
                {
                    Category = fileData.Category,
                    CreationDate = DateTime.Now,
                    Description = fileData.Description,
                    Summary = fileData.Summary,
                    Title = fileData.Title,
                    ImageId = fileData.ImageId,
                    TagId = fileData.TagId,


                };

                using (var db = new WebEntity())
                {
                    db.User_Article.Add(newFile);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteArticle(long id)
        {
            
            try
            {
                using (var db = new WebEntity())
                {
                    var contObj = db.User_Article.First(o => o.Id == id);
                    db.User_Article.Remove(contObj);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        #endregion
    }
}
