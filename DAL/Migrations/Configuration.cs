namespace DAL.Migrations
{
    using DAL.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.DonationMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.DonationMContext context)
        {
           /* var random = new Random();

          
            var doners = new List<Doner>();
            for (int i = 1; i <= 10; i++)
            {
                doners.Add(new Doner
                {
                    DName = "Doner" + i,
                    DPass = Guid.NewGuid().ToString().Substring(0, 20),
                    Email = $"doner{i}@example.com",
                    PhoneNumber = "01" + random.Next(100000000, 999999999).ToString(),
                    Address = "Address " + i,
                    RegistrationDate = DateTime.Now.AddDays(-i),
                   
                    TotalDonatedAmount = random.Next(100, 5000),
                    LastDonationDate = DateTime.Now.AddDays(-random.Next(1, 30))
                });
            }

            context.Doners.AddOrUpdate(d => d.Email, doners.ToArray());
            context.SaveChanges();

            
            var campaigns = new List<Campaign>
            {
                    new Campaign
                    {
                        Title = "Education for All",
                        Description = "Support education of underprivileged children.",
                        TargetAmount = 50000,
                        RaisedAmount = 0,
                        StartDate = DateTime.Now.AddDays(-30),
                        EndDate = DateTime.Now.AddDays(60),
                        IsActive = true
                    },
                    new Campaign
                    {
                        Title = "Medical Aid",
                        Description = "Help provide free medical treatment.",
                        TargetAmount = 75000,
                        RaisedAmount = 0,
                        StartDate = DateTime.Now.AddDays(-15),
                        EndDate = DateTime.Now.AddDays(45),
                        IsActive = true
                    },
                    new Campaign
                    {
                        Title = "Flood Relief",
                        Description = "Donate for recent flood victims.",
                        TargetAmount = 100000,
                        RaisedAmount = 0,
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(30),
                        IsActive = true
                    }
            };

                context.Campaigns.AddOrUpdate(c => c.Title, campaigns.ToArray());
                context.SaveChanges();
                var savedDoners = context.Doners.ToList();
                var savedCampaigns = context.Campaigns.ToList();

            var donations = new List<Donation>();

            for (int i = 0; i < 10; i++)
            {
                var donor = savedDoners[i];
                var campaign = savedCampaigns[random.Next(savedCampaigns.Count)];

                var amount = random.Next(100, 3000);
                donations.Add(new Donation
                {
                    DonerId = donor.Id,
                    CampaignId = campaign.Id,
                    Amount = amount,
                    DonationDate = DateTime.Now.AddDays(-random.Next(1, 15))
                });

               
                campaign.RaisedAmount += amount;
                donor.TotalDonatedAmount += amount;
                donor.LastDonationDate = DateTime.Now;
            }

            context.Donations.AddOrUpdate(d => new { d.DonerId, d.CampaignId }, donations.ToArray());
            context.SaveChanges();*/



        }
    }
}
