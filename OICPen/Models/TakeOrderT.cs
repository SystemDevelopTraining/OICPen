using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class TakeOrderT
    {
        [Key]
        public int Id { get; set; } //注文ID
        [Required]
        public DateTime TakeOrdDate { get; set; } // 注文日
        public DateTime? ShipDate { get; set; } // 出庫日
        [Required]
        public int ClientId { get; set; } // 会員ID

        [ForeignKey("ClientId")]
        public virtual ClientT Client { get; set; }
    }
}
