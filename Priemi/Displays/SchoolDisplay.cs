using ProektDbContext.Model;
using Priemi.Things;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priemi.Displays
{
    public class SchoolDisplay
    {
        AllSchool sc = new AllSchool();
        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "School" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all schools");
            Console.WriteLine("2. Add new school");
            Console.WriteLine("3.Update school");
            Console.WriteLine("4. Delete school by ID");
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
        public SchoolDisplay()
        {
            Input();
        }
        public void Add()
        {
            School school = new School();
            Console.WriteLine("Entert name:");
            school.Name = Console.ReadLine();
            Console.WriteLine("Enter Town");
            school.Id_Town = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student");
            school.Id_Student = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter points for enters");
            school.PointsToEnter = int.Parse(Console.ReadLine());
            sc.Add(school);
        }
        public void ListAll()
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine(new String('-', 16) + "Schools" + new String(' ', 16));
            Console.WriteLine(new String('-', 40));
            var un = sc.GetAll();
            foreach (var item in un)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} ", item.Id, item.Name, item.Id_Town, item.Id_Student, item.PointsToEnter);
            }
        }
        public void Update()
        {
            Console.WriteLine("Enter ID to update:");
            int id = int.Parse(Console.ReadLine());
            School s = sc.Get(id);
            if (s != null)
            {
                Console.WriteLine("Enter name:");
                s.Name = Console.ReadLine();
                Console.WriteLine("Enter town");
                s.Id_Town = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter student:");
                s.Id_Student = int.Parse(Console.ReadLine());
                Console.WriteLine("Poitns for enter");
                s.PointsToEnter = int.Parse(Console.ReadLine());
                sc.Update(s);
            }
            else
            {
                Console.WriteLine("School not found!");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Enter ID to delete:");
            int id = int.Parse(Console.ReadLine());
            sc.Delete(id);
            Console.WriteLine("Done.");
        }
        public void Accepted()
        {
            School school = new School();
            Student student = new Student();
            if (school.PointsToEnter <= student.PointsForUnevirsity)
            {
                Console.WriteLine("Accepted in " + school.Name);
            }
            else
            {
                Console.WriteLine("Not accepted");
            }
        }
    }
}

