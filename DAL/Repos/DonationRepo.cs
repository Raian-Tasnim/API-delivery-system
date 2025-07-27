using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DonationRepo : Repo, IRepo<Donation, int, Donation>
    {
        public Donation Create(Donation obj)
        {
            db.Donations.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Donations.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Donation> Read()
        {
            return db.Donations.ToList();
        }

        public Donation Read(int id)
        {
            return db.Donations.Find(id);
        }

        public Donation Update(Donation obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
