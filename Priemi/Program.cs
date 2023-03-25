using Priemi.Displays;

Input();

static void ShowMenu()
{
    Console.WriteLine(new string('-', 40));
    Console.WriteLine(new string(' ', 18) + "Dispay" + new string(' ', 18));
    Console.WriteLine(new string('-', 40));
    Console.WriteLine("1. Towns");
    Console.WriteLine("2. Univeristies");
    Console.WriteLine("3. Schools");
    Console.WriteLine("4. Students");
    Console.WriteLine("5. Exit");
}
static void Input()
{ 
    int closeOperationId = 5;
    var operation = -1;
    do
    {
        ShowMenu();
        operation = int.Parse(Console.ReadLine());
        switch (operation)
        {
            case 1:
                TownDisplay townDisplay = new TownDisplay();
                break;
            case 2:
                UniDisplay uniDisplay = new UniDisplay();
                break;
            case 3:
               SchoolDisplay schoolDisplay = new SchoolDisplay();
                    break;
            case 4:
                StudentDisplay studentDisplay = new StudentDisplay();
                break;
            default:
                break;
        }
    } while (operation != closeOperationId);
}

