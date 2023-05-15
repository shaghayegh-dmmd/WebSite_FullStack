using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Cr24.WebSite.DAL.Models
{
    [DataContract]
    public class TagModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string TagName { get; set; }
    }
}
