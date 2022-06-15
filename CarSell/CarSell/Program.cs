using System;
using System.Collections.Generic;

namespace CarSell
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(@"*********************************************
Welcome to Car Store
*********************************************");
            Store st = Store.GetStore();
            st.PopulateCarsForTest();

            repeatAction(st);

        }

        static void repeatAction(Store st)
        {
            // Ask for first action
            Console.Write(@"
Select one of these actions
[1] Search a car
[2] Display all cars
type number: ");
            string step1 = Console.ReadLine();

            if (step1 == "1")
            {
                searchCar(st);
            }
            else if(step1 == "2")
            {
                displayCarsTable(st.Cars);
            } else
            {
                Console.WriteLine("\nWRONG INPUT");
            }

            Console.WriteLine("*********************************************");
            repeatAction(st);
        }

        static void searchCar(Store st)
        {
            string selection = getSelection();
            if (selection == "1")
            {
                Console.WriteLine("\nYou choosed Model, Enter model name you want to search: (e.g.: Malibu)");
                string model = Console.ReadLine().Trim();
                displayCarsTable(st.SearchCarByModel(model));
            }
            else if (selection == "2")
            {
                List<Car> result = st.SearchCarByIndustry(chooseIndustry());
                displayCarsTable(result);
            }
        }

        // Display cars list as table
        static void displayCarsTable(List<Car> carList)
        {
            if (carList.Count <= 0)
            {
                Console.WriteLine("\nNO CARS FOUND");
                return;
            }
            Console.WriteLine();
            Console.Write("Model".PadRight(25, ' '));
            Console.Write('|');
            Console.Write("Brand".PadRight(15, ' '));
            Console.Write('|');
            Console.Write("Price".PadRight(10, ' '));
            Console.Write('|');
            Console.WriteLine("Year".PadRight(10, ' '));
            Console.WriteLine("—".PadRight(60, '—'));

            foreach (Car car in carList)
            {
                Console.Write(car.Model.PadRight(25, ' '));
                Console.Write('|');
                Console.Write(car.Brand.PadRight(15, ' '));
                Console.Write('|');
                Console.Write(car.Price.ToString().PadRight(10, ' '));
                Console.Write('|');
                Console.WriteLine(car.ProductionYear.ToString().PadRight(10, ' '));
            }

            Console.WriteLine();
        }

        // Ask user for search selection: by Model or by Industry
        static string getSelection()
        {
            Console.WriteLine(@"
How do you want to search, type number of: 
[1] Model
[2] Industry Type");
            string q = Console.ReadLine();

            if (q != "1" && q != "2")
            {
                Console.WriteLine("WRONG INPUT!");
                return getSelection();
            }
            else
            {
                return q;
            }
        }

        static Industry chooseIndustry()
        {
            Console.WriteLine("\nYou choosed Industy Type, type one of these: \n");
            Array allIndustries = Enum.GetValues(typeof(Industry));
            foreach (Industry i in allIndustries)
            {
                Console.WriteLine(i);
            }

            Console.Write("\nType here: ");
            string industrySelected = Console.ReadLine().ToLower();

            if (Enum.IsDefined(typeof(Industry), industrySelected))
            {
                return (Industry)Enum.Parse(typeof(Industry), industrySelected);
            }
            else
            {
                Console.WriteLine("WRONG INPUT!");
                return chooseIndustry();
            }
        }
    }
}
