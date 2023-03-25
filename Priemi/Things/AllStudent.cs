using ProektDbContext;
using ProektDbContext.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priemi.Things
{
    public class AllStudents
    {
        private ProektDbContexts proektDbContexts;

        public List<Student> GetAll()
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                return proektDbContexts.Students.ToList();
            }
        }
        public Student Get(int id)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                return proektDbContexts.Students.Find(id);
            }
        }

        public void Add(Student student)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                proektDbContexts.Students.Add(student);
                proektDbContexts.SaveChanges();
            }
        }
        public void Update(Student student)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                var item = proektDbContexts.Students.Find(student.Id);
                if (item != null)
                {
                    proektDbContexts.Entry(item).CurrentValues.SetValues(student);
                    proektDbContexts.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (proektDbContexts = new ProektDbContexts())
            {
                var student = proektDbContexts.Students.Find(id);
                if (student != null)
                {
                    proektDbContexts.Students.Remove(student);
                    proektDbContexts.SaveChanges();
                }
            }
        }
    }
}

