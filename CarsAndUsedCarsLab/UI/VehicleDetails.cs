using CarsAndUsedCarsLab.Models;
using System.Globalization;


namespace CarsAndUsedCarsLab.UI
{
    internal class VehicleDetails
    {
        public void ViewSingleVehicle(Vehicle vehicle)
        {
            string validAnswer = "";                    
            string formattedMake;
            string formattedModel;
            string formattedColor;
            string formattedPrice = vehicle.Price.ToString("C", CultureInfo.CurrentCulture);

            bool redoLoop = true;

            formattedMake = vehicle.Make.Length > 13 ? formattedMake = vehicle.Make.Substring(0, 13) : vehicle.Make;

            formattedModel = vehicle.Model.Length > 13 ? formattedModel = vehicle.Model.Substring(0, 13) : vehicle.Model;

            formattedColor = vehicle.Color.Length > 13 ? formattedColor = vehicle.Color.Substring(0, 13) : vehicle.Color;

            Console.WriteLine(String.Format("{0,-14} {1,-10} {2, 3} {3, -8} {4, -14}", "==============", 
                                            "Inventory#", vehicle.InventoryId, $"( {new CultureInfo("en-US", false).TextInfo.ToTitleCase(vehicle.NewOrUsed) } )", "=============="));
            Console.WriteLine(String.Format("{0,-52}", "=                                                   ="));
            Console.WriteLine(String.Format("{0,-6} {1,-5} {2, -18} {3, -5} {4, -13} {5, -1}", "=", "Year:", vehicle.Year, "Make:", formattedMake, "="));
            Console.WriteLine(String.Format("{0,-52}", "=                                                   ="));
            Console.WriteLine(String.Format("{0,-5} {1,-5} {2, -17} {3, -6} {4, -13} {5, -1}", "=", "Model:", formattedModel, "Price:", formattedPrice, "="));
            Console.WriteLine(String.Format("{0,-52}", "=                                                   ="));
            if (vehicle.NewOrUsed == "used")
            {
                UsedVehicle usedVehicle = (UsedVehicle)vehicle;
                string formattedMileage = usedVehicle.Mileage.ToString().Length > 13 ? formattedMileage = usedVehicle.Mileage.ToString().Substring(0, 13) : usedVehicle.Mileage.ToString();
                
                Console.WriteLine(String.Format("{0,-5} {1,-6} {2, -15} {3, -6} {4, -13} {5, -1}", "=", "Color:", formattedColor, "Mileage:", formattedMileage, "="));
                Console.WriteLine(String.Format("{0,-52}", "=                                                   ="));
                Console.WriteLine(String.Format("{0,-5} {1, -6} {2, -38} {3, -1}", "=", "Price:", formattedPrice, "="));
                
            }
            else
            {
                Console.WriteLine(String.Format("{0,-5} {1,-6} {2, -38} {3, -1}", "=", "Color:", formattedColor, "="));
            }
            
            Console.WriteLine(String.Format("{0,-52}", "=                                                   ="));
            Console.WriteLine(String.Format("{0,-51}", "====================================================="));

            while (redoLoop)
            {
                Console.WriteLine();

                Console.WriteLine("Type exit when you are done viewing this vehicle.");

                validAnswer = Console.ReadLine().ToLower();

                if (validAnswer != "exit")
                {
                    Console.WriteLine("Enter exit only.");
                    redoLoop = true;
                }

                else
                {
                    redoLoop = validAnswer == "exit" ? false : true;

                    Console.WriteLine();
                }

            }

        }
        
    }

}
