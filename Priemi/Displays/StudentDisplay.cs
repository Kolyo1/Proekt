using ProektDbContext.Model;
using Priemi.Things;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priemi.Displays
{
    public  class StudentDisplay
    {
       AllStudents students= new AllStudents();
        public void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "Students" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all students");
            Console.WriteLine("2. Add new student");
            Console.WriteLine("3. Update student");
            Console.WriteLine("4. Delete student by ID");
            Console.WriteLine("5. Exit");
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
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }


        private int closeOperationId = 5;
        public StudentDisplay()
        {
            Input();
        }
        public void Add()
        {
            Student student = new Student();
            Console.WriteLine("Entert name:");
            student.FirstName = Console.ReadLine();
            student.SecondName = Console.ReadLine();
            student.LastName = Console.ReadLine();
            Console.WriteLine("Enter points for Uni");
            student.PointsForUnevirsity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter points for school");
            student.PointsForSchool = int.Parse(Console.ReadLine());
            students.Add(student);
        }
        public void ListAll()
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine(new String('-', 16) + "Students" + new String(' ', 16));
            Console.WriteLine(new String('-', 40));
            var st = students.GetAll();
            foreach (var item in st)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", item.Id, item.FirstName, item.SecondName, item.LastName, item.PointsForUnevirsity, item.PointsForSchool);
            }
        }
        public void Update()
        {
            Console.WriteLine("Enter ID to update:");
            int id = int.Parse(Console.ReadLine());
            Student st = students.Get(id);
            if (st != null)
            {
                Console.WriteLine("Enter name:");
                st.FirstName = Console.ReadLine();
                st.SecondName = Console.ReadLine();
                st.LastName = Console.ReadLine();
                Console.WriteLine("Enter pointsUni:");
                st.PointsForUnevirsity = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter pointsShool:");
                st.PointsForSchool = int.Parse(Console.ReadLine());
                students.Update(st);
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Enter ID to delete:");
            int id = int.Parse(Console.ReadLine());
            students.Delete(id);
            Console.WriteLine("Done.");
        }

    }
}

