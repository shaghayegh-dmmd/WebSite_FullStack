using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cr24.WebSite.DAL.Models;

namespace Cr24.WebSite.BLL
{
    public class AttachmentService
    {
        public static List<AttachmentModel> GetAllAttachment()
        {
            using (var db = new WebEntity())
            {
                return db.Manager_Attachment.Select(o => new AttachmentModel
                {
                    FileContent = o.FileContent,
                    FileName = o.FileName,
                    CreationDate = o.CreationDate,
                    SystemFileType = o.SystemFileType

                }).ToList();
            }
        }
    }
}
