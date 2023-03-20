using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektDbContext.Model
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public int PointsForUnevirsity { get; set; }

        public int PointsForSchool { get; set; }
    }
}

