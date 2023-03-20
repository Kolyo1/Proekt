using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektDbContext.Model
{
    public class University
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Id_Town { get; set; }
        public int Id_Student { get; set; }
        public int PointsToEnter { get; set; }
    }
}
