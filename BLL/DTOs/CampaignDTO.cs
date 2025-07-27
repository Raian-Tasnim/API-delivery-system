using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CampaignDTO
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double TargetAmount { get; set; }

        public double RaisedAmount { get; set; } = 0;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
