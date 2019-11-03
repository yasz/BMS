using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.ViewModels
{
    public class BookNoInput
    {
        [Required]
        [StringLength(20, ErrorMessage = "书籍编号必须为10-20位数字", MinimumLength = 10)]
        public string BookNo { get; set; }
    }
}
