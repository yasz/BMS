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
        public string BookNo { get; set; }
        public string Vano { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
    }
}
