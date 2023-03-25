using ProektDbContext.Model;
using Priemi.Things;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priemi.Displays
{
    public class UniDisplay
    {
        AllUni uni = new AllUni();
        public void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "University" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all universities");
            Console.WriteLine("2. Add new university");
            Console.WriteLine("3. Update university");
            Console.WriteLine("4. Delete university by ID");
            Console.WriteLine("5. Accepted or not");
            Console.WriteLine("6. Exit");
        }
        public void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Delete();
                        break;
                    case 5:
                        Accepted();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }


        private int closeOperationId = 6;
        public UniDisplay()
        {
            Input();
        }
        public void Add()
        {
            University university = new University();
            Console.WriteLine("Entert name:");
            university.Name = Console.ReadLine();
            Console.WriteLine("Enter Town");
            university.Id_Town = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student");
            university.Id_Student = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter points for enters");
            university.PointsToEnter = int.Parse(Console.ReadLine());
            uni.Add(university);
        }
        public void ListAll()
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine(new String('-', 16) + "Universities" + new String(' ', 16));
            Console.WriteLine(new String('-', 40));
            var un = uni.GetAll();
            foreach (var item in un)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} ", item.Id, item.Name, item.Id_Town, item.Id_Student, item.PointsToEnter);
            }
        }
        public void Update()
        {
            Console.WriteLine("Enter ID to update:");
            int id = int.Parse(Console.ReadLine());
            University un = uni.Get(id);
            if (un != null)
            {
                Console.WriteLine("Enter name:");
                un.Name = Console.ReadLine();
                Console.WriteLine("Enter town");
                un.Id_Town = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter student:");
                un.Id_Student = int.Parse(Console.ReadLine());
                Console.WriteLine("Poitns for enter");
                un.PointsToEnter = int.Parse(Console.ReadLine());
                uni.Update(un);
            }
            else
            {
                Console.WriteLine("University not found!");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Enter ID to delete:");
            int id = int.Parse(Console.ReadLine());
            uni.Delete(id);
            Console.WriteLine("Done.");
        }
        public void Accepted()
        {
            University university = new University();
            Student student = new Student();
            if (university.PointsToEnter <= student.PointsForUnevirsity)
            {
                Console.WriteLine("Accepted in " + university.Name);
            }
            else
            {
                Console.WriteLine("Not accepted");
            }
        }

    }
}

