using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime DonationDate { get; set; } = DateTime.Now;

        [ForeignKey("Doner")]
        public int DonerId { get; set; }
        public virtual Doner Doner { get; set; }

        [ForeignKey("Campaign")]
        public int CampaignId { get; set; }
        public virtual Campaign Campaign { get; set; }

    }
}
