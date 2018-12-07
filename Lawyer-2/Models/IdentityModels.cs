using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Lawyer_2.Models.Database;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Lawyer_2.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Column("FirstName", TypeName = "nvarchar")]
        public string FirstName { get; set; }
        [Required]
        [Column("MidlleName", TypeName = "nvarchar")]
        public string MidlleName { get; set; }
        [Required]
        [Column("LastName", TypeName = "nvarchar")]
        public string LastName { get; set; }
        [Required]
        [Column("IsFreelance", TypeName = "bit")]
        public bool IsFreelance { get; set; }
        [Required]
        [Column("DOB", TypeName = "date")]
        public DateTime DOB { get; set; }
        [ForeignKey("UserType")]
        [Column("UserTypeId")]
        public int UserTypeId { get; set; }
        [ForeignKey("UserType")]
        public virtual UserType UserType { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserProviderDegree> UserProviderDegrees { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Telephone> Telephones { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Address> Addresses { get; set; }
        [InverseProperty("Client")]
        public virtual ICollection<Rate> ClientRates { get; set; }
        [InverseProperty("Provider")]
        public virtual ICollection<Rate> ProviderRates { get; set; }
        [ForeignKey("User")]
        public virtual ICollection<Certification> Certifications { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<EducationalQualification> EducationalQualifications { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<RequestBid> RequestBids { get; set; }
        [InverseProperty("Client")]
        public virtual ICollection<ChatManager> ClientChatManagers { get; set; }
        [InverseProperty("Provider")]
        public virtual ICollection<ChatManager> ProviderChatManagers { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<UserType> UserType { get; set; }
        public DbSet<Telephone> Telephone { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Rate> Rate { get; set; }
        public DbSet<Certification> Certification { get; set; }
        public DbSet<QualificationType> QualificationType { get; set; }
        public DbSet<EducationalQualification> EducationalQualification { get; set; }
        public DbSet<RequestType> RequestType { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<RequestBid> RequestBid { get; set; }
        public DbSet<University> University { get; set; }
        public DbSet<College> College { get; set; }
        public DbSet<Degree> Degree { get; set; }
        public DbSet<ChatManager> ChatManager { get; set; }
        public DbSet<ProviderDegree> ProviderDegree { get; set; }
        public DbSet<UserProviderDegree> UserProviderDegree { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rate>()
                .HasRequired(m => m.Client)
                .WithMany(m => m.ClientRates)
                .HasForeignKey(m => m.ClientId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Rate>()
                .HasRequired(m => m.Provider)
                .WithMany(m => m.ProviderRates)
                .HasForeignKey(m => m.ProviderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RequestBid>()
               .HasRequired(m => m.Provider)
               .WithMany(m => m.RequestBids)
               .HasForeignKey(m => m.ProviderId)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Request>()
              .HasRequired(m => m.Client)
              .WithMany(m => m.Requests)
              .HasForeignKey(m => m.ClientId)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChatManager>()
              .HasRequired(m => m.Client)
              .WithMany(m => m.ClientChatManagers)
              .HasForeignKey(m => m.ClientId)
              .WillCascadeOnDelete(false);
            modelBuilder.Entity<ChatManager>()
              .HasRequired(m => m.Provider)
              .WithMany(m => m.ProviderChatManagers)
              .HasForeignKey(m => m.ProviderId)
              .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}