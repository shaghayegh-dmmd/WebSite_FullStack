using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cr24.WebSite.DAL.Models
{
   
   public class ArticleModel
    {
        
        public long Id { get; set; }

        
        public string Title { get; set; }

       
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

        
        public byte[] FileContent { get; set; }

       
        public byte[] ImageContent { get; set; }


    }
}
