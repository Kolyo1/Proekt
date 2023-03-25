using ProektDbContext;
using ProektDbContext.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priemi.Things
{
    public class AllUni
    {
        private ProektDbContexts proektDbContexts;

        public List<University> GetAll()
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                return proektDbContexts.Universities.ToList();
            }
        }
        public University Get(int id)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                return proektDbContexts.Universities.Find(id);
            }
        }

        public void Add(University university)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                proektDbContexts.Universities.Add(university);
                proektDbContexts.SaveChanges();
            }
        }
        public void Update(University university)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                var item = proektDbContexts.Universities.Find(university.Id);
                if (item != null)
                {
                    proektDbContexts.Entry(item).CurrentValues.SetValues(university);
                    proektDbContexts.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                var university = proektDbContexts.Universities.Find(id);
                if (university != null)
                {
                    proektDbContexts.Universities.Remove(university);
                    proektDbContexts.SaveChanges();
                }
            }
        }
    }
}

