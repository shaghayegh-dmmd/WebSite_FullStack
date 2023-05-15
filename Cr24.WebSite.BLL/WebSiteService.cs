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
        public bool CreatArticle(ArticleModel fileData)
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
                    FileId = fileData.FileId,
                    Manager_Attachment = fileData.

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

        public bool EditeArticle(ArticleModel fileData)
        {
            try
            {
                using (var db = new WebEntity())
                {
                    var contObj = db.User_Article.First(o => o.Id == fileData.Id);
                    contObj.Title = fileData.Title;
                    contObj.Description = fileData.Description;
                    contObj.Summary = fileData.Summary;
                    contObj.Category = fileData.Category;
                    contObj.ImageId = fileData.ImageId;
                    contObj.FileId = fileData.FileId;
                    contObj.TagId = fileData.TagId;

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<ArticleModel> GetAllFileContent()
        {

            using (var db = new WebEntity())
            {
                return db.User_Article.Select(o => new ArticleModel
                {
                    Title = o.Title,
                    Description = o.Description,
                    Category = o.Category,
                    Summary = o.Summary,
                    FileId = o.FileId,
                    TagId = o.TagId,
                    ImageId = o.ImageId

                }).ToList();
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


        #region Attachment
        public bool CreatAttachment(AttachmentModel fileData)
        {
            try
            {
                var newFile = new Manager_Attachment
                {
                    FileName = fileData.FileName,
                    CreationDate = DateTime.Now,
                    FileContent = fileData.FileContent
                   
                };

                using (var db = new WebEntity())
                {
                    db.Manager_Attachment.Add(newFile);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditeAttachment(AttachmentModel fileData)
        {
            try
            {
                using (var db = new WebEntity())
                {
                    var contObj = db.Manager_Attachment.First(o => o.Id == fileData.Id);
                    contObj.FileContent = fileData.FileContent;
                    contObj.FileName = fileData.FileName;
                   
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<AttachmentModel> GetAllAttachment()
        {

            using (var db = new WebEntity())
            {
                return db.Manager_Attachment.Select(o => new AttachmentModel
                {
                    FileName = o.FileName,
                    FileContent = o.FileContent
                }).ToList();
            }
        }

        public bool DeleteAttachment(long id)
        {

            try
            {
                using (var db = new WebEntity())
                {
                    var contObj = db.Manager_Attachment.First(o => o.Id == id);
                    db.Manager_Attachment.Remove(contObj);
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
