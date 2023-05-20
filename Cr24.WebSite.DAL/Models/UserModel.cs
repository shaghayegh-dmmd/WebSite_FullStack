using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cr24.WebSite.DAL.Models
{
    
    public class UserModel
    {
       
        public long Id { get; set; }

        
        public string UserName { get; set; }

        
        public string FirstName { get; set; }

       
        public string LastName { get; set; }

        
        public string Password { get; set; }

        
        public bool? IsActive { get; set; }

        
        public string Email { get; set; }

        
        public string RoleName { get; set; }

       
        public DateTime? CreationDate { get; set; }

        
        public long? FileId { get; set; }
    }
}
