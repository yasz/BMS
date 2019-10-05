using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Rent
    {
      
        public Guid RentId { get; set; }
        [Required]
        
        [StringLength(20, ErrorMessage = "书籍编号必须为10-20位数字", MinimumLength = 10)]
        public string BookNo { get; set; }

        [Required]
//        [StringLength(6, ErrorMessage = "学号必须为6位数字")]
        [RegularExpression("^.{8}|.{6}", ErrorMessage = "学号必须为6位或8位数字")]
        public string Vano { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
    }
}
