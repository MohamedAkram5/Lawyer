using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Lawyer_2.Models;

namespace Lawyer_2.Models.Database
{
    [Table("Telephone")]
    public class Telephone : CoreTableID
    {
        [Required]
        [Column("UserId")]
        [ForeignKey("User")]
        public string UserId { get; set; }
        [ForeignKey("User")]
        public virtual ApplicationUser User { get; set; }
        [Required]
        [Column("Phone", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Phone { get; set; }
    }
}