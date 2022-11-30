using Garage;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    public enum CompanyName
    {
        ACSchnitzer,
        Adler,
        Alfer,
        Bajai,
        BMW,
        Boxer,
        Ducati,
        HarleyDavidson,
        Kawasaki,
        Peugeot,
        Saxon,
        Suzuki,
        Yamaha
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Wellcome, \nHow many space do your garage have?");
        int capacity = NumberInput();
        Menu mn = new Menu("My Garage", "Main Menu", 0);

        var airplane = new List<Airplane>();
        var boat = new List<Boat>();
        var bus = new List<Bus>();
        var car = new List<Car>();
        var motor = new List<Motorcycle>();

        mn.AddItemMenu("Reports");
        mn.AddItemMenu("Activity");

        Menu reportSMN = new Menu("My Garage", "Main Menu / Reports", 1);
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

        Garage<Vehicle> garage = new Garage<Vehicle>("My Garage", capacity);
        Vehicle v;
        string answer;
        Vehicle fv;
        (string, string) avt,fvt;

        bool exit = true;
        do
        {
            bool subLevel1Exit = true;
            switch (mn.DrawMenu())
            {
                case 0:
                    exit = false;
                    break;
                case 1: //##################################################### Report Sub Menu
                    do
                    {
                        switch (reportSMN.DrawMenu())
                        {
                            case 0: //##################################################### Back to previous menu
                                subLevel1Exit = false;
                                break;
                            case 1: //##################################################### List All
                                Console.WriteLine("Under Construction!!!");
                                Console.ReadKey();
                                break;
                            case 2: //##################################################### List Vehicle Type
                                Console.WriteLine("Under Construction!!!");
                                Console.ReadKey();
                                break;
                            case 3: //##################################################### List Vehicle
                                garage.ListAllVehicle();
                                Console.ReadKey();
                                break;
                            case 4: //##################################################### Find
                                bool subLevel2Exit = true;
                                do
                                {
                                    switch (findSMN.DrawMenu())
                                    {
                                        case 0:
                                            subLevel2Exit = false;
                                            break;
                                        case 1: //##################################################### Search by Licens Plate
                                            Console.Write("Please enter a licensePlate: ");
                                            string lp = Console.ReadLine();
                                            fv = garage.FindVehicle("LicensePlate", lp);
                                            if (fv != null)
                                            {
                                                garage.PrintHeader();
                                                garage.PrintVehicle(fv);
                                                garage.PrintFooter();
                                            }
                                            else
                                            {
                                                WriteAlert("This Vehicle not found.");
                                            }
                                            Console.ReadKey();
                                            break;
                                        case 2: //#####################################################Search by Owner
                                            Console.Write("Please enter a owner name: ");
                                            string name = Console.ReadLine();
                                            fv = garage.FindVehicle("Owner", name);
                                            if (fv != null)
                                            {
                                                garage.PrintHeader();
                                                garage.PrintVehicle(fv);
                                                garage.PrintFooter();
                                            }
                                            else
                                            {
                                                WriteAlert("This Vehicle not found.");
                                            }
                                            Console.ReadKey();
                                            break;
                                        case 3: //#####################################################Search by Type
                                            Console.WriteLine("Under Construction!!!");
                                            Console.ReadKey();
                                            break;
                                        case 4: //#####################################################Search by Color
                                            Console.Write("Please enter a color (Red, Green, Blue, Black, Gray, White, Silver, Gold): ");
                                            string color = Console.ReadLine();
                                            fv = garage.FindVehicle("Owner", color);
                                            if (fv != null)
                                            {
                                                garage.PrintHeader();
                                                garage.PrintVehicle(fv);
                                                garage.PrintFooter();
                                            }
                                            else
                                            {
                                                WriteAlert("This Vehicle not found.");
                                            }
                                            Console.ReadKey();
                                            break;
                                        case 5: //##################################################### CustomSearch
                                            Console.WriteLine("Under Construction!!!");
                                            Console.ReadKey();
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
                case 2: //########################################################################################################## Activity Sub Menu
                    do
                    {
                        switch (activitySMN.DrawMenu())
                        {
                            case 0:
                                subLevel1Exit = false; break;
                            case 1: //##################################################### Vehicle Type
                                bool subLevel2Exit = true;
                                dataSMN.Name = "Main Menu / Activity / Vehicle Type";
                                do
                                {
                                    switch (dataSMN.DrawMenu())
                                    {
                                        case 0:
                                            subLevel2Exit = false; break;
                                        case 1: //##################################################### Add
                                            Console.WriteLine("Which kind of vehicle type do you want to add? (Airplane, Boat, Bus, Car, Motorcycle)");
                                            answer = Console.ReadLine().ToUpper();
                                            avt = AddVehicleType(answer);
                                            switch (answer.ToUpper())
                                            {
                                                case "AIRPLANE":
                                                    airplane.Add(new Airplane(Airplane.Parse(avt.Item1), CompanyNameParse(avt.Item2)));
                                                    break;
                                                case "BOAT":
                                                    boat.Add(new Boat(avt.Item1,CompanyNameParse(avt.Item2)));
                                                    break;
                                                case "BUS":
                                                    bus.Add(new Bus(avt.Item1,CompanyNameParse(avt.Item2)));
                                                    break;
                                                case "CAR":
                                                    car.Add(new Car(avt.Item1, CompanyNameParse(avt.Item2)));
                                                    break;
                                                case "MOTORCYCLE":
                                                    motor.Add(new Motorcycle(CompanyNameParse(avt.Item1),Motorcycle.Parse(avt.Item2)));
                                                    break;
                                                default:
                                                    WriteAlert("You enter a wrong value.");
                                                    Console.ReadKey();
                                                    break;
                                            }
                                            break;
                                        case 2: //##################################################### Edit
                                                //Console.WriteLine("Under Construction!!!");
                                            Console.WriteLine("Which kind of vehicle type do you want to edit? (Airplane, Boat, Bus, Car, Motorcycle)");
                                            answer = Console.ReadLine().ToUpper();
                                            Console.WriteLine($"Please enter a {answer} unique name");
                                            string un = Console.ReadLine();
                                            switch (answer.ToUpper())
                                            {
                                                case "AIRPLANE":
                                                    FindType(answer, un);
                                                    break;
                                                case "BOAT":
                                                    boat.Add(new Boat(avt.Item1, CompanyNameParse(avt.Item2)));
                                                    break;
                                                case "BUS":
                                                    bus.Add(new Bus(avt.Item1, CompanyNameParse(avt.Item2)));
                                                    break;
                                                case "CAR":
                                                    car.Add(new Car(avt.Item1, CompanyNameParse(avt.Item2)));
                                                    break;
                                                case "MOTORCYCLE":
                                                    motor.Add(new Motorcycle(CompanyNameParse(avt.Item1), Motorcycle.Parse(avt.Item2)));
                                                    break;
                                                default:
                                                    WriteAlert("You enter a wrong value.");
                                                    Console.ReadKey();
                                                    break;
                                            }

                                            break;
                                        case 3: //##################################################### remove
                                                //Console.WriteLine("Under Construction!!!");
                                            break;
                                        default:
                                            break;
                                    }
                                } while (subLevel2Exit);
                                break;
                            case 2: //#####################################################Vehicle
                                dataSMN.Name = "Main Menu / Activity / Vehicle";
                                bool subLevel3Exit = true;
                                do
                                {
                                    switch (dataSMN.DrawMenu())
                                    {
                                        case 0:
                                            subLevel3Exit = false; break;
                                        case 1: //#####################################################Add
                                            v = new Vehicle();
                                            Console.WriteLine("\n\n ==> Add new Vehicle <==");
                                            Console.Write("Please enter a place of vehicle in the Garage: ");
                                            v.Place = Console.ReadLine();

                                            Console.Write("Please enter a licensePlate of vehicle: ");
                                            v.LicensePlate = Console.ReadLine();

                                            Console.Write("Please enter a color (Red, Green, Blue, Black, Gray, White, Silver, Gold): ");
                                            v.Color = Console.ReadLine();

                                            Console.Write("Please enter a owner name: ");
                                            v.Owner = Console.ReadLine();

                                            Console.Write("Please enter a fuel type (Benzine, Diesel, Gas, Electric): ");
                                            Fuel vfuel;
                                            v.Fuel = Vehicle.ConvertToFuel(Console.ReadLine().ToUpper());

                                            Console.Write("Please enter a wheels number: ");
                                            v.WheelsNumber = NumberInput();

                                            Console.Write("Please enter a vehicle max speed (KM / H): ");
                                            v.Speed = NumberInput();

                                            Console.Write("Please enter a engin size: ");
                                            v.EnginSize = NumberInput();

                                            Console.Write("Please enter a cylender numbers: ");
                                            v.Cylender = NumberInput();


                                            if (garage.Park(v) == true)
                                            {
                                                Console.WriteLine("Successfully parked the vehicle.");
                                                capacity--;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Something happen wrong and Vehicle not parked. \n Maybe the parking capacity is full.");
                                            }
                                            Console.ReadKey();
                                            break;
                                        case 2: //#####################################################Edit
                                            Console.Write("Please enter a licensePlate to edit vehicle information: ");
                                            string lp = Console.ReadLine();
                                            fv = garage.FindVehicle("LicensePlate", lp);
                                            if (fv == null)
                                            {
                                                WriteAlert("This register number not found.");
                                                Console.ReadKey();
                                            }
                                            else
                                            {

                                                WriteAlert("To change the value please enter new value otherwise just press enter.");
                                                Console.Write("place of vehicle in the Garage: ");
                                                WriteValue(fv.Place);
                                                answer = Console.ReadLine();
                                                if (answer != "") { fv.Place = answer; }

                                                Console.WriteLine("licensePlate of vehicle: ");
                                                WriteValue(fv.LicensePlate);
                                                answer = Console.ReadLine();
                                                if (answer != "") { fv.LicensePlate = answer; }

                                                Console.WriteLine("color (Red, Green, Blue, Black, Gray, White, Silver, Gold): ");
                                                WriteValue(fv.Color);
                                                answer = Console.ReadLine();
                                                if (answer != "") { fv.Color = answer; }

                                                Console.WriteLine("wheels number: ");
                                                WriteValue(fv.WheelsNumber.ToString());
                                                fv.WheelsNumber = NumberInput();

                                                Console.WriteLine("owner name: ");
                                                WriteValue(fv.Owner);
                                                answer = Console.ReadLine();
                                                if (answer != "") { fv.Owner = answer; }

                                                Console.WriteLine("vehicle max speed (KM / H): ");
                                                WriteValue(fv.Speed.ToString());
                                                fv.Speed = NumberInput();

                                                Console.WriteLine("engin size: ");
                                                WriteValue(fv.EnginSize.ToString());
                                                fv.EnginSize = NumberInput();

                                                Console.WriteLine("cylender numbers: ");
                                                WriteValue(fv.Cylender.ToString());
                                                fv.Cylender = NumberInput();

                                                Console.WriteLine("fuel type (Benzine, Diesel, Gas, Electric): ");
                                                WriteValue(fv.Fuel.ToString());
                                                answer = Console.ReadLine();
                                                if (answer != "") { fv.Fuel = Vehicle.ConvertToFuel(answer.ToUpper()); }

                                            }
                                            Console.ReadKey();
                                            break;
                                        case 3: //#####################################################remove
                                            Console.Write("Please enter a licensePlate to edit vehicle information: ");
                                            lp = Console.ReadLine();
                                            fv = garage.FindVehicle("LicensePlate", lp);
                                            if (fv == null)
                                            {
                                                WriteAlert("This register number not found.");
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                WriteAlert($"Are you sure to delete {lp}? please press 'y' to delete: ");
                                                char key = Console.ReadKey(true).KeyChar;
                                                if (key == 'y' || key == 'Y') { garage.Unpark(lp); capacity++; }
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                } while (subLevel3Exit);
                                break;
                            case 3: //#####################################################Garage Capacity
                                dataSMN.Name = "Main Menu / Activity / Garage Capacity";
                                bool subLevel4Exit = true;
                                do
                                {
                                    switch (dataSMN.DrawMenu())
                                    {
                                        case 0:
                                            subLevel4Exit = false; break;
                                        case 1: //#####################################################Add
                                            Console.WriteLine("This menu is not valid for garage caoacity");
                                            Console.ReadKey();
                                            break;
                                        case 2: //#####################################################Edit
                                            Console.WriteLine($"You have {capacity} space to park a vehicle.");
                                            Console.WriteLine("If you want to change, please enter new capacity: ");
                                            int c = NumberInput();
                                            if (c > 0) { capacity = c; }
                                            break;
                                        case 3: //#####################################################remove
                                            Console.WriteLine("This menu is not valid for garage caoacity");
                                            Console.ReadKey();
                                            break;
                                        default:
                                            break;
                                    }
                                } while (subLevel4Exit);
                                break;
                            default:
                                break;
                        }
                    } while (subLevel1Exit);
                    break;
                default:
                    break;
            }
        } while (exit);
    }

    private static (string, string) AddVehicleType(string vt)
    {
        string cn;
        switch (vt)
        {
            case "AIRPLANE":
                Console.WriteLine("Please enter airplane type (Passenger, Freight, Fighter, Powered, Unpowered, Jet): ");
                string et = Console.ReadLine();
                CompanyNamePrint();
                Console.WriteLine("Please enter company name: ");
                cn = Console.ReadLine();
               return (et, cn);
            case "BOAT":
            case "BUS":
            case "CAR":
                Console.WriteLine($"Please enter the {vt} name: ");
                string bn = Console.ReadLine() ;
                CompanyNamePrint();
                Console.WriteLine("Please enter company name: ");
                cn = Console.ReadLine();
                return (bn, cn);
            case "MOTORCYCLE":
                CompanyNamePrint();
                Console.WriteLine("Please enter company name: ");
                cn = Console.ReadLine();
                Motorcycle.MotorTypePrint();
                Console.WriteLine("Please enter the motor type:");
                string mt = Console.ReadLine();
                return (cn, mt);
            default:
                WriteAlert("You entered a wrong value.");
                return (null, null);
                break;
        }
    }
    public static void CompanyNamePrint()
    {
        int counter = 0;
        for (int i = 0; i < 60; i++) { Console.Write("-"); }
        Console.WriteLine();
        foreach (string name in Enum.GetNames(typeof(CompanyName)))
        {
            Console.Write($"| {name,15} |");
            if (counter % 3 == 2)
            {
                Console.WriteLine();
            }
            counter++;
        }
        Console.WriteLine();
        for (int i = 0; i < 60; i++) { Console.Write("-"); }
        Console.WriteLine();
    }
    public static CompanyName CompanyNameParse(string input)
    {
        switch (input)
        {
            case "ACSchnitzer":
                return CompanyName.ACSchnitzer;
            case "Adler":
                return CompanyName.Adler;
            case "Alfer":
                return CompanyName.Alfer;
            case "Bajai":
                return CompanyName.Bajai;
            case "BMW":
                return CompanyName.BMW;
            case "Boxer":
                return CompanyName.Boxer;
            case "Ducati":
                return CompanyName.Ducati;
            case "HarleyDavidson":
                return CompanyName.HarleyDavidson;
            case "Kawasaki":
                return CompanyName.Kawasaki;
            case "Peugeot":
                return CompanyName.Peugeot;
            case "Saxon":
                return CompanyName.Saxon;
            case "Suzuki":
                return CompanyName.Suzuki;
            case "Yamaha":
                return CompanyName.Yamaha;
            default:
                return CompanyName.ACSchnitzer;
        }
    }

    public static void WriteValue(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(msg);
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public static void WriteAlert(string msg)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(msg);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public static int NumberInput()
    {
        string _val = "";
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(true);
            if (key.Key != ConsoleKey.Backspace)
            {
                double val = 0;
                bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                if (_x)
                {
                    _val += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
            }
            else
            {
                if (key.Key == ConsoleKey.Backspace && _val.Length > 0)
                {
                    _val = _val.Substring(0, (_val.Length - 1));
                    Console.Write("\b \b");
                }
            }
        }
        //##################################################### Stops Receving Keys Once Enter is Pressed
        while (key.Key != ConsoleKey.Enter);
        Console.WriteLine();
        if (_val == "") { return 0; }
        return Int32.Parse(_val);
    }
}
