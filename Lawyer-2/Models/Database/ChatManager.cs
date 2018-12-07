using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Lawyer_2.Models;

namespace Lawyer_2.Models.Database
{
    public class ChatManager : CoreTableID
    {
        [Required]
        [Column("ClientId", Order = 0)]
        [ForeignKey("Client")]
        public string ClientId { get; set; }
        [Required]
        [Column("ProviderId", Order = 1)]
        [ForeignKey("Provider")]
        public string ProviderId { get; set; }
        [ForeignKey("Client")]
        public virtual ApplicationUser Client { get; set; }
        [ForeignKey("Provider")]
        public virtual ApplicationUser Provider { get; set; }
        [Required]
        [Column("Available" , TypeName = "bit")]
        public bool Available { get; set; }
    }
}