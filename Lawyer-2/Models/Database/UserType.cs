using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Lawyer_2.Models;

namespace Lawyer_2.Models.Database
{
    [Table("UserType")]
    public class UserType : CoreTableName
    {
        [InverseProperty("UserType")]
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}