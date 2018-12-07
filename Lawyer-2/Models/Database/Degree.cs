using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using Lawyer_2.Models;

namespace Lawyer_2.Models.Database
{
    [Table("Degree")]
    public class Degree : CoreTableName
    {
        [InverseProperty("Degree")]
        public virtual ICollection<EducationalQualification> EducationalQualifications { get; set; }
    }
}