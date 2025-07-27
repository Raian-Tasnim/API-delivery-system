using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public  class Campaign
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double TargetAmount { get; set; }
        public double RaisedAmount { get; set; } = 0;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual ICollection<Donation> Donations { get; set; }
        public Campaign()
        {
            Donations = new List<Donation>();
        }
    }
}
