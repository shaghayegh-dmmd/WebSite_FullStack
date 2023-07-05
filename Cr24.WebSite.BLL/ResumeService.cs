using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cr24.WebSite.DAL.Models;

namespace Cr24.WebSite.BLL
{
    public class ResumeService
    {
        public static bool CreateResume(ResumeModel fileData)
        {
            try
            {
                var newFile = new User_Resume
                {
                    Email = fileData.Email,
                    FirstName = fileData.FirstName,
                    LastName = fileData.LastName,
                    PhoneNumber = fileData.PhoneNumber,
                    NationalCode = fileData.NationalCode,
                    FileId = fileData.FileId
                };

                using (var db = new WebEntity())
                {
                    db.User_Resume.Add(newFile);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EditResume(ResumeModel fileData)
        {
            try
            {
                using (var db = new WebEntity())
                {
                    var contObj = db.User_Resume.First(o => o.Id == fileData.Id);
                    contObj.Email = fileData.Email;
                    contObj.FirstName = fileData.FirstName;
                    contObj.LastName = fileData.LastName;
                    contObj.PhoneNumber = fileData.PhoneNumber;
                    contObj.NationalCode = fileData.NationalCode;
                    contObj.FileId = fileData.FileId;

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static List<ResumeModel> GetAllResume()
        {

            using (var db = new WebEntity())
            {
                return db.User_Resume.Select(o => new ResumeModel
                {
                    Email = o.Email,
                    FirstName = o.FirstName,
                    LastName = o.LastName,
                    PhoneNumber = o.PhoneNumber,
                    NationalCode = o.NationalCode,
                    FileId = o.FileId

                }).ToList();
            }
        }

        public static bool DeleteResume(long id)
        {
            try
            {
                using (var db = new WebEntity())
                {
                    var contObj = db.User_Resume.First(o => o.Id == id);
                    db.User_Resume.Remove(contObj);
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
