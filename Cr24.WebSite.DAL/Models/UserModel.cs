using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Cr24.WebSite.DAL.Models
{
    [DataContract]
    public class UserModel
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string RoleName { get; set; }

        [DataMember]
        public DateTime? CreationDate { get; set; }

        [DataMember]
        public long? FileId { get; set; }
    }
}
