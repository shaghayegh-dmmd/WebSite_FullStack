namespace Cr24.WebSite.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[Manager.Attachment]")]
    public partial class Manager_Attachment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Manager_Attachment()
        {
            Manager_User = new HashSet<Manager_User>();
            User_Article = new HashSet<User_Article>();
            User_Resume = new HashSet<User_Resume>();
        }

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public byte[] FileContent { get; set; }

        [StringLength(250)]
        public string FileName { get; set; }

        public DateTime? CreationDate { get; set; }

        public string SystemFileType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Manager_User> Manager_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Article> User_Article { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Resume> User_Resume { get; set; }
    }
}
