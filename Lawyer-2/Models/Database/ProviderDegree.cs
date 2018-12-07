using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Lawyer_2.Models;

namespace Lawyer_2.Models.Database
{
    public class ProviderDegree : CoreTableName
    {
        [InverseProperty("ProviderDegree")]
        public virtual ICollection<UserProviderDegree> UserProviderDegrees { get; set; }
    }
}