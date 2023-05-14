namespace Cr24.WebSite.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[Manager.User]")]
    public partial class Manager_User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string RoleName { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? FileId { get; set; }

        public virtual Manager_Attachment Manager_Attachment { get; set; }
    }
}
