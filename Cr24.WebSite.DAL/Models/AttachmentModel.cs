using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cr24.WebSite.DAL.Models
{
    public class AttachmentModel
    {
        public long Id { get; set; }

        public byte[] FileContent { get; set; }

        public string FileName { get; set; }

        public DateTime? CreationDate { get; set; }

        public string SystemFileType { get; set; }
    }
}
