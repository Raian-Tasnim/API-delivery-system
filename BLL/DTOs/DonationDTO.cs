using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DonationDTO
    {
        public int Id { get; set; }
        [Required]
        public double Amount { get; set; }
        public DateTime DonationDate { get; set; } = DateTime.Now;
    }
}
