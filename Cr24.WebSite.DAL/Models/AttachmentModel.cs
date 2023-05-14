using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Cr24.WebSite.DAL.Models
{
    [DataContract]
    public class AttachmentModel
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public byte[] FileContent { get; set; }

        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public DateTime? CreationDate { get; set; }
    }
}
