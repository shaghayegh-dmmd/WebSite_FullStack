using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Cr24.WebSite.DAL.Models
{
    [DataContract]
    public class ResumeModel
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string NationalCode { get; set; }

        [DataMember]
        public long? FileId { get; set; }

    }
}
