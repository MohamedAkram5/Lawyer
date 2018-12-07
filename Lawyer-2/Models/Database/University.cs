using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace Lawyer_2.Models.Database
{
    [Table("University")]
    public class University : CoreTableName
    {
        [InverseProperty("University")]
        public virtual ICollection<EducationalQualification> EducationalQualifications { get; set; }
    }
}