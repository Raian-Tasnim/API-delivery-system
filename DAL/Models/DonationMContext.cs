using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class DonationMContext:DbContext
    {
        public DbSet<Doner> Doners { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Donation> Donations { get; set; }

        public DbSet<Token> Tokens { get; set; }

    }

}

