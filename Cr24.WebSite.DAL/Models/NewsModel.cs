using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Cr24.WebSite.DAL.Models
{
    [DataContract]
    public class NewsModel
    {

        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Reference { get; set; }

        [DataMember]
        public string HeadLine { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public DateTime? CreationDate { get; set; }

        [DataMember]
        public string ImageId { get; set; }
    }
}
