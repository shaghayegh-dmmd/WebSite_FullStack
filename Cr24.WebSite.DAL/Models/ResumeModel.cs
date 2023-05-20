using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cr24.WebSite.DAL.Models
{
   
    public class ResumeModel
    {
       
        public long Id { get; set; }

        
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        
        public string PhoneNumber { get; set; }

        
        public string Email { get; set; }

        
        public string NationalCode { get; set; }

        
        public long? FileId { get; set; }

    }
}
