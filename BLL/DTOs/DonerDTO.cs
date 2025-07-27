using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DonerDTO
    {
        public int Id { get; set; }
        [Required]

        public string DName { get; set; }
        [Required]
        public string DPass { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]

        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        [Required]


        public double TotalDonatedAmount { get; set; }
        public DateTime? LastDonationDate { get; set; }
    }
}
