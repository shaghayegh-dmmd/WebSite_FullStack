using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cr24.WebSite.DAL.Helper;

namespace Cr24.WebSite.DAL.Models
{
   
   public class ArticleModel
    {
        
        public long Id { get; set; }

        
        public string Title { get; set; }

       
        public string Description { get; set; }

     
        public DateTime? CreationDate { get; set; }

        public string CreationDateStr
        {
            set
            {
                var val = value.PersianNumbersToEnglish();
                if (!DateHelper.IsValidJalaliDate(val)) return;
                var date = val.ToGeoDateTime();
                if (date != null) CreationDate = (DateTime)date;
            }
            get
            {
                try
                {
                    return DateHelper.GetJalaliFromDateTimeGregorian(CreationDate);
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }
        public string Category { get; set; }

  
        public string Summary { get; set; }

        
        public string ImageId { get; set; }

       
        public long? FileId { get; set; }

        
        public string TagId { get; set; }

    }
}
