using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Cr24.WebSite.DAL.Models
{
    [DataContract]
   public class ArticleModel
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public DateTime? CreationDate { get; set; }

        [DataMember]
        public string Category { get; set; }

        [DataMember]
        public string Summary { get; set; }

        [DataMember]
        public string ImageId { get; set; }

        [DataMember]
        public long? FileId { get; set; }

        [DataMember]
        public string TagId { get; set; }

        [DataMember]
        public byte[] FileContent { get; set; }

        [DataMember]
        public byte[] ImageContent { get; set; }


    }
}
