using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Cr24.WebSite.DAL.Models
{
    public partial class WebEntity : DbContext
    {
        public WebEntity()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Manager_Attachment> Manager_Attachment { get; set; }
        public virtual DbSet<Manager_User> Manager_User { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User_Article> User_Article { get; set; }
        public virtual DbSet<User_ContactUs> User_ContactUs { get; set; }
        public virtual DbSet<User_News> User_News { get; set; }
        public virtual DbSet<User_Resume> User_Resume { get; set; }
        public virtual DbSet<User_Tag> User_Tag { get; set; }
     

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manager_Attachment>()
                .HasMany(e => e.Manager_User)
                .WithOptional(e => e.Manager_Attachment)
                .HasForeignKey(e => e.FileId);

            modelBuilder.Entity<Manager_Attachment>()
                .HasMany(e => e.User_Article)
                .WithOptional(e => e.Manager_Attachment)
                .HasForeignKey(e => e.FileId);

            modelBuilder.Entity<Manager_Attachment>()
                .HasMany(e => e.User_Resume)
                .WithOptional(e => e.Manager_Attachment)
                .HasForeignKey(e => e.FileId);

            modelBuilder.Entity<User_Resume>()
                .Property(e => e.NationalCode)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
