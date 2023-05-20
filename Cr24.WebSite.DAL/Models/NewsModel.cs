using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cr24.WebSite.DAL.Models
{
   
    public class NewsModel
    {

       
        public long Id { get; set; }

        
        public string Title { get; set; }

        
        public string Reference { get; set; }

        
        public string HeadLine { get; set; }

        
        public string Description { get; set; }

       
        public DateTime? CreationDate { get; set; }

       
        public string ImageId { get; set; }
    }
}
