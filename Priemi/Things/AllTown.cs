using ProektDbContext;
using ProektDbContext.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priemi.Things
{
    public class AllTown
    {
        private ProektDbContexts proektDbContexts;

        public List<Town> GetAll()
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                return proektDbContexts.Towns.ToList();
            }
        }
        public Town Get(int id)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                return proektDbContexts.Towns.Find(id);
            }
        }

        public void Add(Town town)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                proektDbContexts.Towns.Add(town);
                proektDbContexts.SaveChanges();
            }
        }
        public void Update(Town town)
        {
            using (proektDbContexts = new ProektDbContexts ())
            {
                var item = proektDbContexts.Towns.Find(town.Id);
                if (item != null)
                {
                    proektDbContexts.Entry(item).CurrentValues.SetValues(town);
                    proektDbContexts.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                var town = proektDbContexts.Towns.Find(id);
                if (town != null)
                {
                    proektDbContexts.Towns.Remove(town);
                    proektDbContexts.SaveChanges();
                }
            }
        }
    }
}

