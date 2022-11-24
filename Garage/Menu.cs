using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Menu
    {
        private string title;
        private string name;
        private int level;

        private List<string> items = null;

        public Menu(string title, string name, int level)
        {
            Title = title;
            Name = name;
            Level = level;
            items = new List<string>();
        }

        public string Title { get => title; set => title = value; }
        public string Name { get => name; set => name = value; }
        public int Level { get=> level; set => level = value; }

     
        public void AddItemMenu(string itemName)
        {
            if ((itemName.ToUpper() != "EXIT") || (itemName.ToUpper() != "QUIT"))
            {
                items.Add(itemName);
            }
        }

        public int DrawMenu() 
        {
            int counter = 1;
            Console.Clear();
            Console.WriteLine("#####################################################");
            Console.WriteLine("\t \t "+title);
            Console.WriteLine("\n "+name+" \n");
            foreach(string menuItem in items)
            {
                Console.WriteLine(counter.ToString()+". " + menuItem);
                counter++;
            }
            if (Level == 0)
            {
                Console.WriteLine("0. Exit");
            }
            else
            {
                Console.WriteLine("0. Exit");
            }
            
            Console.WriteLine("\n #####################################################\n");
            Console.WriteLine("Please select a number: ");
            try 
            { 
                return Int16.Parse(Console.ReadLine()); 
            }
            catch (Exception e) 
            { 
                Console.WriteLine("Invalid number, Please select a number from the menu.");
                Console.WriteLine("System Error: \n"+e.ToString());
                Console.ReadKey(); 
                return -1; 
            }
        }
    }
}
