using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Lawyer_2.Models;

namespace Lawyer_2.Models.Database
{
    [Table("Rate")]
    public class Rate : CoreTableID
    {
        [Required]
        [Column("ClientId" , Order = 0)]
        [ForeignKey("Client")]
        public string ClientId { get; set; }
        [Required]
        [Column("ProviderId", Order = 1)]
        [ForeignKey("Provider")]
        public string ProviderId { get; set; }
        [Required]
        [Column("RateDegree")]
        public int RateDegree { get; set; }
        [ForeignKey("Client")]
        public virtual ApplicationUser Client { get; set; }
        [ForeignKey("Provider")]
        public virtual ApplicationUser Provider { get; set; }
    }
}