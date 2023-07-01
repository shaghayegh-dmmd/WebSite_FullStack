using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cr24.WebSite.DAL.Helper;

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
        public string ImageId { get; set; }
    }
}
