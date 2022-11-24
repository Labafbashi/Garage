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

                                            break;
                                        case 2: //Edit
                                            break;
                                        case 3: //remove
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

                                            break;
                                        case 2: //Edit
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