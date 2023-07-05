namespace Cr24.WebSite.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[User.ContactUs]")]
    public partial class User_ContactUs
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string TextContent { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }
    }
}
