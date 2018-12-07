using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using Lawyer_2.Models;

namespace Lawyer_2.Models.Database
{
    [Table("EducationalQualification")]
    public class EducationalQualification : CoreTableID
    {
        [Required]
        [Column("QualificationType")]
        [ForeignKey("Qualification")]
        public int QualificationType { get; set; }
        [ForeignKey("Qualification")]
        public virtual QualificationType Qualification { get; set; }
        [Required]
        [Column("UserId")]
        [ForeignKey("User")]
        public string UserId { get; set; }
        [ForeignKey("User")]
        public virtual ApplicationUser User { get; set; }
        [Required]
        [Column("UniversityId")]
        [ForeignKey("University")]
        public int UniversityId { get; set; }
        [ForeignKey("University")]
        public virtual University University { get; set; }
        [Required]
        [Column("CollegeId")]
        [ForeignKey("College")]
        public int CollegeId { get; set; }
        [ForeignKey("College")]
        public virtual College College { get; set; }
        [Required]
        [Column("DegreeId")]
        [ForeignKey("Degree")]
        public int DegreeId { get; set; }
        [ForeignKey("Degree")]
        public virtual Degree Degree { get; set; }
        [Required]
        [Column("QualDesc", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string QualDesc { get; set; }
        [Required]
        [Column("GraduationYear", TypeName = "date")]
        public DateTime GraduationYear { get; set; }
    }
}
