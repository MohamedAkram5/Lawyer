using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Lawyer_2.Models;

namespace Lawyer_2.Models.Database
{
    [Table("Address")]
    public class Address : CoreTableID
    {
        [Required]
        [Column("UserId")]
        [ForeignKey("User")]
        public string UserId { get; set; }
        [Required]
        [Column("CityId")]
        [ForeignKey("City")]
        public int CityId { get; set; }
        [Required]
        [Column("Country", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Country { get; set; }
        [Required]
        [Column("Region", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Region { get; set; }
        [Required]
        [Column("Street", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Street { get; set; }
        [Column("Street2", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Street2 { get; set; }
        [Column("PostalCode", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string PostalCode { get; set; }
        [ForeignKey("User")]
        public virtual ApplicationUser User { get; set; }
        [ForeignKey("City")]
        public virtual City City { get; set; }
    }
}