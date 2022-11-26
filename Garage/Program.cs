using Garage;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Menu mn = new Menu("My Garage", "Main Menu",0);
        mn.AddItemMenu("Reports");
        mn.AddItemMenu("Activity");

        Menu reportSMN = new Menu("My Garage", "Main Menu / Reports",1);
        reportSMN.AddItemMenu("List All");
        reportSMN.AddItemMenu("List Vehicle Type");
        reportSMN.AddItemMenu("List Vehicle");
        reportSMN.AddItemMenu("Find / Search");

        Menu activitySMN = new Menu("My Garage", "Main Menu / Activity", 1);
        activitySMN.AddItemMenu("Vehicle Type");
        activitySMN.AddItemMenu("Vehicle");
        activitySMN.AddItemMenu("Garage Capacity");

        Menu dataSMN = new Menu("My Garage", "Main Menu / Activity", 2);
        dataSMN.AddItemMenu("Add");
        dataSMN.AddItemMenu("Edit");
        dataSMN.AddItemMenu("remove");

        Menu findSMN = new Menu("My Garage", "Main Menu / Reports / Find", 2);
        findSMN.AddItemMenu("Search by Licens Plate");
        findSMN.AddItemMenu("Search by Owner");
        findSMN.AddItemMenu("Search by Type");
        findSMN.AddItemMenu("Search by Color");
        findSMN.AddItemMenu("CustomSearch");


        bool exit = true;
        do
        {
            bool subLevel1Exit = true;
            switch (mn.DrawMenu()) {
                case 0:
                    exit= false;
                    break;
                case 1: //##################################################### Report Sub Menu
                    do
                    {
                        switch (reportSMN.DrawMenu())
                        {
                            case 0: //Back to previous menu
                                subLevel1Exit= false;
                                break;
                            case 1: //List All
                                
                                break; 
                            case 2: // List Vehicle Type
                                break;
                            case 3: // List Vehicle
                                break;
                            case 4: // Find
                                bool subLevel2Exit = true;
                                do
                                {
                                    switch (findSMN.DrawMenu())
                                    {
                                        case 0:
                                            subLevel2Exit = false;
                                            break;
                                        case 1: //Search by Licens Plate
                                            break;
                                        case 2: //Search by Owner
                                            break;
                                        case 3: //Search by Type
                                            break;
                                        case 4: //Search by Color
                                            break;
                                        case 5: //CustomSearch
                                            break;
                                        default:
                                            break;
                                    }
                                } while (subLevel2Exit);
                                break;
                            default:
                                break;
                        }
                    } while (subLevel1Exit);
                        
                    break;
                case 2: //##################################################### Activity Sub Menu
                    do
                    {
                        switch (activitySMN.DrawMenu())
                        {
                            case 0:
                                subLevel1Exit = false; break;
                            case 1: //Vehicle Type
                                bool subLevel2Exit = true;
                                dataSMN.Name = "Main Menu / Activity / Vehicle Type";
                                do
                                {
                                    switch (dataSMN.DrawMenu())
                                    {
                                        case 0:
                                            subLevel2Exit = false; break;
                                        case 1: //Add
                                            //Console.WriteLine("Under Construction!!!");
                                            break;
                                        case 2: //Edit
                                            //Console.WriteLine("Under Construction!!!");
                                            break;
                                        case 3: //remove
                                            //Console.WriteLine("Under Construction!!!");
                                            break;
                                        default:
                                            break;
                                    }
                                } while (subLevel2Exit);
                                break;
                            case 2: //Vehicle
                                dataSMN.Name = "Main Menu / Activity / Vehicle";
                                bool subLevel3Exit = true;
                                do
                                {
                                    switch (dataSMN.DrawMenu())
                                    {
                                        case 0:
                                            subLevel3Exit = false; break;
                                        case 1: //Add
                                            Console.WriteLine("\n\n ==> Add new Vehicle <==");
                                            Console.Write("Please enter a place of vehicle in the Garage: ");
                                            string vplace = Console.ReadLine();
                                            Console.Write("Please enter a licensePlate of vehicle: ");
                                            string vlicensePlate = Console.ReadLine();
                                            Console.Write("Please enter a color (Red, Green, Blue, Black, Gray, White, Silver, Gold): ");
                                            string vcolor = Console.ReadLine();
                                            Console.Write("Please enter a wheels number: ");
                                            int vwheels=Int32.Parse(Console.ReadLine());
                                            Console.Write("Please enter a owner name: ");
                                            string vname = Console.ReadLine();
                                            Console.Write("Please enter a vehicle max speed (KM / H): ");
                                            int vspeed = Int32.Parse(Console.ReadLine());
                                            Console.Write("Please enter a engin size: ");
                                            int venginSize = Int32.Parse(Console.ReadLine());
                                            Console.Write("Please enter a cylender numbers: ");
                                            int vcylender = Int32.Parse(Console.ReadLine());
                                            Console.Write("Please enter a fuel type (Benzine, Diesel, Gas, Electric): ");
                                            Fuel vfuel;
                                            switch (Console.ReadLine().ToUpper())
                                            {
                                                case "BENZINE":
                                                    vfuel=Fuel.Benzine; break;
                                                case "DIESEL":
                                                    vfuel=Fuel.Diesel; break;
                                                case "GAS":
                                                    vfuel=Fuel.Gas; break;
                                                case "ELECTRIC":
                                                    vfuel = Fuel.Electric; break;
                                                default:
                                                    vfuel= Fuel.Benzine; break;
                                            }
                                            Vehicle v = new Vehicle(vplace, vlicensePlate, vcolor, vwheels, vname, vspeed, venginSize, vcylender, vfuel);

                                            break;
                                        case 2: //Edit
                                            Console.Write("Please enter a licensePlate to edit vehicle information: ");
                                            string lp = Console.ReadLine();
                                            Garage<Vehicle> vehicle = new Garage<Vehicle>();
                                            foreach (Vehicle v1 in vehicle) { 
                                                if (v1.LicensePlate == lp)
                                                {
                                                    Console.Write("place ==> " + v1.Place);
                                                    Console.Write("licensePlate ==> "+ v1.LicensePlate);
                                                    Console.Write("color ==> "+ v1.Color);
                                                    Console.Write("wheels number ==> : "+v1.WheelsNumber);
                                                    Console.Write("owner name ==> : "+v1.Owner);
                                                    Console.Write("max speed (KM / H) ==> "+v1.Speed);
                                                    Console.Write("engin size ==> "+v1.EnginSize);
                                                    Console.Write("cylender numbers ==> "+v1.Cylender);
                                                    Console.Write("fuel type ==> "+v1.Fuel);
                                                }
                                            }
                                            Console.ReadKey();
                                            break;
                                        case 3: //remove
                                            break;
                                        default:
                                            break;
                                    }
                                } while (subLevel3Exit);
                                break;
                            case 3: //Garage Capacity
                                dataSMN.Name = "Main Menu / Activity / Garage Capacity";
                                bool subLevel4Exit = true;
                                do
                                {
                                    switch (dataSMN.DrawMenu())
                                    {
                                        case 0:
                                            subLevel4Exit = false; break;
                                        case 1: //Add

                                            break;
                                        case 2: //Edit
                                            break;
                                        case 3: //remove
                                            break;
                                        default:
                                            break;
                                    }
                                } while (subLevel4Exit);
                                break;
                            default:
                                break;
                        }
                    }while(subLevel1Exit);
                    break;
                default:
                    break;  
            }
        }while(exit);
    }
}