using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Lawyer_2.Models.Database
{
    [Table("QualificationType")]
    public class QualificationType : CoreTableName
    {
        [InverseProperty("Qualification")]
        public virtual ICollection<EducationalQualification> EducationalQualifications { get; set; }
    }
}