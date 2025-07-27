using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CampaignRepo : Repo, IRepo<Campaign, int, Campaign>
    {
        public Campaign Create(Campaign obj)
        {
            db.Campaigns.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Campaigns.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Campaign> Read()
        {
            return db.Campaigns.ToList();
        }

        public Campaign Read(int id)
        {
            return db.Campaigns.Find(id);
        }

        public Campaign Update(Campaign obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
