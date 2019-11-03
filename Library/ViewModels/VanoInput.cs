using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.ViewModels
{
    public class VanoInput
    {
        [Required]
        [RegularExpression("^.{8}|.{6}", ErrorMessage = "学号必须为6位或8位数字")]
        public string Vano { get; set; }
    }
}
