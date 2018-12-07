using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Lawyer_2.Models;

namespace Lawyer_2.Models.Database
{
    [Table("RequestBid")]
    public class RequestBid : CoreTableID
    {
        [Required]
        [Column("RequestId")]
        [ForeignKey("Request")]
        public int RequestId { get; set; }
        [ForeignKey("Request")]
        public virtual Request Request { get; set; }
        [Required]
        [Column("ProviderId")]
        public string ProviderId { get; set; }
        public virtual ApplicationUser Provider { get; set; }
        [Required]
        [Column("ReqBidDesc", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string ReqBidDesc { get; set; }
        [Required]
        [Column("ReqBidValue")]
        public float ReqBidValue { get; set; }
    }
}