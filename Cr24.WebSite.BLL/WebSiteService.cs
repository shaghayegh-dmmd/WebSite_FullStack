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

        public bool DeleteFileAccess(long id)
        {
            try
            {
                using (var db = new WebEntity())
                {
                    var contObj = db.User_Article.First(o => o.Id == id);
                    db.AccessFileContents.Remove(contObj);
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
