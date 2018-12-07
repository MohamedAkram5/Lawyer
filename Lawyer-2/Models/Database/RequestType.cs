using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Lawyer_2.Models.Database
{
    [Table("RequestType")]
    public class RequestType : CoreTableName
    {
        [InverseProperty("RequestType")]
        public virtual ICollection<Request> Requests { get; set; }
    }
}