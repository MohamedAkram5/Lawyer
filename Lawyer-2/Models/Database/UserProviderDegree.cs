using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Lawyer_2.Models;

namespace Lawyer_2.Models.Database
{
    public class UserProviderDegree : CoreTableID
    {
        [ForeignKey("ProviderDegree")]
        [Column("ProviderDegreeId")]
        public int ProviderDegreeId { get; set; }
        [ForeignKey("ProviderDegree")]
        public virtual ProviderDegree ProviderDegree { get; set; }
        [ForeignKey("User")]
        [Column("UserId")]
        public string UserId { get; set; }
        [ForeignKey("User")]
        public virtual ApplicationUser User { get; set; }
    }
}