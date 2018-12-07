using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Lawyer_2.Models;

namespace Lawyer_2.Models.Database
{
    [Table("City")]
    public class City : CoreTableName
    {
        [InverseProperty("City")]
        public virtual ICollection<Address> Addresses { get; set; }
        [InverseProperty("City")]
        public virtual ICollection<Request> Requests { get; set; }
    }
}