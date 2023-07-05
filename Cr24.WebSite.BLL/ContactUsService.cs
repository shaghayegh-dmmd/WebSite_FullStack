using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cr24.WebSite.DAL.Models;

namespace Cr24.WebSite.BLL
{
    public class ContactUsService
    {

        public static bool CreateContactUs(ContactUsModel fileData)
        {
            try
            {
                var newFile = new User_ContactUs
                {
                    Email = fileData.Email,
                    UserName = fileData.UserName,
                    TextContent = fileData.TextContent,
                    Subject = fileData.Subject
                };

                using (var db = new WebEntity())
                {
                    db.User_ContactUs.Add(newFile);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EditContactUs(ContactUsModel fileData)
        {
            try
            {
                using (var db = new WebEntity())
                {
                    var contObj = db.User_ContactUs.First(o => o.Id == fileData.Id);
                    contObj.Email = fileData.Email;
                    contObj.UserName = fileData.UserName;
                    contObj.TextContent = fileData.TextContent;
                    contObj.Subject = fileData.Subject;

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static List<ContactUsModel> GetAllContactUs()
        {

            using (var db = new WebEntity())
            {
                return db.User_ContactUs.Select(o => new ContactUsModel
                {
                    Email = o.Email,
                    UserName = o.UserName,
                    TextContent = o.TextContent,
                    Subject = o.Subject

                }).ToList();
            }
        }

        public static bool DeleteContactUs(long id)
        {
            try
            {
                using (var db = new WebEntity())
                {
                    var contObj = db.User_ContactUs.First(o => o.Id == id);
                    db.User_ContactUs.Remove(contObj);
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
