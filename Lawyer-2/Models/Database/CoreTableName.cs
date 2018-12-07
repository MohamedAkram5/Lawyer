using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Lawyer_2.Models;

namespace Lawyer_2.Models.Database
{
    public class CoreTableName : CoreTableID
    {
        [Required]
        [Column("Name", TypeName = "nvarchar")]
        [MaxLength(50)]
        public virtual string Name { get; set; }
    }
}