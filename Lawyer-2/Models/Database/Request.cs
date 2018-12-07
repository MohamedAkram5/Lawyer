using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using Lawyer_2.Models;

namespace Lawyer_2.Models.Database
{
    [Table("Request")]
    public class Request : CoreTableID
    {
        [Required]
        [Column("RequestTypeId")]
        [ForeignKey("RequestType")]
        public int RequestTypeId { get; set; }
        [ForeignKey("RequestType")]
        public virtual RequestType RequestType { get; set; }
        [Required]
        [Column("ClientId")]
        public string ClientId { get; set; }
        public virtual ApplicationUser Client { get; set; }
        [Required]
        [Column("Title", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [Column("ReqDesc", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string ReqDesc { get; set; }
        [Required]
        [Column("RequestDate", TypeName = "datetime2")]
        public DateTime RequestDate { get; set; }
        [Required]
        [Column("EndDate", TypeName = "datetime2")]
        public DateTime EndDate { get; set; }
        [Required]
        [Column("IsApproved", TypeName = "bit")]
        public bool IsApproved { get; set; }
        [Required]
        [Column("CityId")]
        [ForeignKey("City")]
        public int CityId { get; set; }
        [ForeignKey("City")]
        public virtual City City{ get; set; }
        [Column("RequestBidId" , TypeName = "int")]
        public int RequestBidId { get; set; }
        [InverseProperty("Request")]
        public virtual ICollection<RequestBid> RequestBids { get; set; }
    }
}