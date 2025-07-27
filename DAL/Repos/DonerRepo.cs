using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class DonerRepo : Repo, IRepo<Doner, int, Doner>,IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = db.Doners.FirstOrDefault(u => u.DName.Equals(username) &&
            password.Equals(password));
            if (data != null) return true;
            return false;
        }

        public Doner Create(Doner obj)
        {
            db.Doners.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;

        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Doners.Remove(ex);
            return db.SaveChanges() > 0;
        }



        public List<Doner> Read()
        {
            return db.Doners.ToList();
        }

        public Doner Read(int id)
        {
            return db.Doners.Find(id);
        }



        public Doner Update(Doner obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;

        }
    }
}
