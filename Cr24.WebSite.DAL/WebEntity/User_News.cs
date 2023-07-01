namespace Cr24.WebSite.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[User.News]")]
    public partial class User_News
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(300)]
        public string Reference { get; set; }

        [StringLength(700)]
        public string HeadLine { get; set; }

        public string Description { get; set; }

        public DateTime? CreationDate { get; set; }

        public string ImageId { get; set; }
    }
}
