using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class GiveOrder
    {
        [Key]
        public int Id { get; set; } // 発注ID
        [Required]
        public DateTime GiveOrdDate { get; set; } //発注日
        public DateTime? CompleteDate { get; set; } //入庫日
        [Required]
        public int StaffId { get; set; } // 社員ID

        [ForeignKey("StaffId")]
        public virtual Staff Staff { get; set; }
    }
}
