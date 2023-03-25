using Priemi.Things;
using ProektDbContext;
using ProektDbContext.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priemi.Displays
{
    public class TownDisplay
    {
        AllTown all = new AllTown();
        public void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "Towns" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all towns");
            Console.WriteLine("2. Add new town");
            Console.WriteLine("3. Update towns");
            Console.WriteLine("4. Delete town by ID");
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
        public TownDisplay()
        {
            Input();
        }
        public void Add()  
        {
            Town town = new Town();
            Console.WriteLine("Enter name:");
            town.Name = Console.ReadLine();
            all.Add(town);
        }
        public void ListAll()
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine(new String('-', 16) + "Towns" + new String(' ', 16));
            Console.WriteLine(new String('-', 40));
            var towns = all.GetAll();
            foreach (var item in towns)
            {
                Console.WriteLine("{0} {1}", item.Id, item.Name);
            }
        }
        public void Update()
        {
            Console.WriteLine("Enter ID to update:");
            int id = int.Parse(Console.ReadLine());
            Town product = all.Get(id);
            if (product != null)
            {
                Console.WriteLine("Enter name:");
                product.Name = Console.ReadLine();
                all.Update(product);
            }
            else
            {
                Console.WriteLine("Town not found!");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Enter ID to delete:");
            int id = int.Parse(Console.ReadLine());
            all.Delete(id);
            Console.WriteLine("Done.");
        }

    }
}

