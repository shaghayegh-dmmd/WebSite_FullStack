using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cr24.WebSite.DAL.Models
{
   
    public class ContactUsModel
    {
        
        public long Id { get; set; }

        
        public string Email { get; set; }

       
        public string UserName { get; set; }

       
        public string TextContent { get; set; }

        
        public string Subject { get; set; }
    }
}
