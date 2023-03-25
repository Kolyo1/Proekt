using ProektDbContext;
using ProektDbContext.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priemi.Things
{
    public class AllSchool
    {
        private ProektDbContexts proektDbContexts;

        public List<School> GetAll()
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                return proektDbContexts.Schools.ToList();
            }
        }
        public School Get(int id)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                return proektDbContexts.Schools.Find(id);
            }
        }

        public void Add(School school)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                proektDbContexts.Schools.Add(school);
                proektDbContexts.SaveChanges();
            }
        }
        public void Update(School school)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                var item = proektDbContexts.Schools.Find(school.Id);
                if (item != null)
                {
                    proektDbContexts.Entry(item).CurrentValues.SetValues(school);
                    proektDbContexts.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                var school = proektDbContexts.Schools.Find(id);
                if (school != null)
                {
                    proektDbContexts.Schools.Remove(school);
                    proektDbContexts.SaveChanges();
                }
            }
        }
    }
}

