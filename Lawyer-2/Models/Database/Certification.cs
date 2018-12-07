using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using Lawyer_2.Models;

namespace Lawyer_2.Models.Database
{
    [Table("Certification")]
    public class Certification : CoreTableName
    {
        [Required]
        [Column("UserId")]
        [ForeignKey("User")]
        public string UserId { get; set; }
        [ForeignKey("User")]
        public virtual ApplicationUser User { get; set; }
        [Required]
        [Column("Location", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Location { get; set; }
        [Column("Descreption", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Descreption { get; set; }
        [Required]
        [Column("StartDate", TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column("EndDate", TypeName = "date")]
        public DateTime EndDate { get; set; }
        [Column("ExpDate", TypeName = "date")]
        public DateTime ExpDate { get; set; }
    }
}