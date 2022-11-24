internal class Program
{
    private static void Main(string[] args)
    {
        bool exit = true;
        do
        {
            switch (DrawMainMenu()) {
                case 0:
                    exit= false;
                    break;
                default:
                    break;  
            }
                
                
        }while(exit);
    }

    private static int DrawMainMenu()
    {
        Console.Clear();
        Console.WriteLine("#####################################################");
        Console.WriteLine("\t \t My Garage");
        Console.WriteLine("\n Main Menu\n");
        Console.WriteLine("1. Show Garage");
        Console.WriteLine("2. Reports");
        Console.WriteLine("3. Activity");
        Console.WriteLine("0. Exit");
        Console.WriteLine("Please select a number: ");
        try { return (Int16.Parse(Console.ReadLine())); }
        catch (Exception e){ Console.WriteLine("Invalid number, Please select a number from the menu."); Console.ReadKey(); return 100; }
        
    }
}