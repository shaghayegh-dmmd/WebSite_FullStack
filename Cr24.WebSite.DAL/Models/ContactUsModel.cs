using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Cr24.WebSite.DAL.Models
{
    [DataContract]
    public class ContactUsModel
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string TextContent { get; set; }

        [DataMember]
        public string Subject { get; set; }
    }
}
