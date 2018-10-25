using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    class TakeOrder
    {
        [Key]
        public int Id { get; set; } //注文ID
        [Required]
        public DateTime TakeOrdDate { get; set; } // 注文日
        public DateTime ShipDate { get; set; } // 出庫日
        [Required]
        public int StaffId { get; set; } // 社員ID

        [ForeignKey("StaffId")]
        public virtual Staff Staff { get; set; }
    }
}
