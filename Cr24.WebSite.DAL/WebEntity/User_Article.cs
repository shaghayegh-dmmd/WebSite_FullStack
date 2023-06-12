namespace Cr24.WebSite.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[User.Article]")]
    public partial class User_Article
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? CreationDate { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(700)]
        public string Summary { get; set; }

        [StringLength(500)]
        public string ImageId { get; set; }

        public long? FileId { get; set; }

        [StringLength(250)]
        public string TagId { get; set; }

        public virtual Manager_Attachment Manager_Attachment { get; set; }
    }
}
