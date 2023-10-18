using CarsAndUsedCarsLab.Data;
using CarsAndUsedCarsLab.Models;

namespace CarsAndUsedCarsLab.UI
{
    public class InventoryFrame
    {
        public void ShowInventoryFrame(List<Vehicle> vehicles)
        {
            int iCNT = 1;

            string formattedMake;
            string formattedModel;
            string formattedColor;


            iCNT = 1;

            Console.WriteLine(String.Format("{0, -18} {1, -14} {2, -19}", "==================", "Inventory List", "==================="));
            Console.WriteLine(String.Format("{0, -54}", "=                                                   ="));
            Console.WriteLine(String.Format("{0, -11} {1, -13} {2, -13} {3, -11} {4, 1}", "=", "Make", "Model", "Color", "="));
            Console.WriteLine(String.Format("{0, -4} {1, -6} {2, -13} {3, -13} {4, -11} {5, -1}", "=", "---", "----------", "----------", "--------", "="));

            foreach (Vehicle vehicle in vehicles)
            {
                formattedMake = vehicle.Make.Length > 10 ? formattedMake = vehicle.Make.Substring(0, 10) : vehicle.Make;

                formattedModel = vehicle.Model.Length > 10 ? formattedModel = vehicle.Model.Substring(0, 10) : vehicle.Model;

                formattedColor = vehicle.Color.Length > 10 ? formattedColor = vehicle.Color.Substring(0, 10) : vehicle.Color;

                Console.WriteLine(String.Format("{0,-4} {1,-6} {2, -13} {3, -13} {4,-10} {5, 2}", $"=", iCNT, formattedMake, formattedModel, formattedColor, "="));

                iCNT++;

            }

            Console.WriteLine(String.Format("{0, -54}", "=                                                   ="));
            Console.WriteLine(String.Format("{0, -4} {1, -6} {2, -39} {3, 1}", "=", vehicles.Count + 1, "Exit", "="));
            Console.WriteLine(String.Format("{0, -54}", "=                                                   ="));
            Console.WriteLine(String.Format("{0, -51}", "====================================================="));

            Console.WriteLine();
        }

    }
}
