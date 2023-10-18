
using CarsAndUsedCarsLab.Models;

namespace CarsAndUsedCarsLab.Data
{
    public class VehicleDb
    {
        List<string> carMakes = new List<string>()
        {
            "Chevy",
            "Ford",
            "Dodge",
            "Toyota",
            "Honda"
        };

        List<string> carModels = new List<string>()
        {
            "Silverado",
            "F-150",
            "Ram",
            "Supra",
            "Civic"

        };
        
        List<string> carColors = new List<string>()
        {
            "White",
            "Blue",
            "Red",
            "Yellow"
        };
        
        public void CreateVehicle(int numberOfCars, string newOrUsed)
        {                      

            for (int i = 1; i <= numberOfCars; i++)
            {
                if (newOrUsed == "new")
                {
                    CreateNewVehicle();
                }
                else
                {
                    CreateUsedVehicle();
                }

            }

        }
        public void CreateNewVehicle()
        {            
            int randomMakeModel;

            NewVehicle newVehicle = new NewVehicle();

            var rnd = new Random();

            newVehicle.InventoryId = rnd.Next(1, 999);
            newVehicle.Year = rnd.Next(1930, 2023);

            randomMakeModel = rnd.Next(0, carMakes.Count);
            newVehicle.Make = carMakes[randomMakeModel];
            newVehicle.Model = carModels[randomMakeModel];
            newVehicle.Color = carColors[rnd.Next(0, carColors.Count)];
            newVehicle.Price = rnd.Next(30000, 100000);
            newVehicle.NewOrUsed = "new";

            InventoryList.availableVehicles.Add(newVehicle);

        }

        public void CreateUsedVehicle()
        {
            int randomMakeModel;

            UsedVehicle usedVehicle = new UsedVehicle();

            var rnd = new Random();

            usedVehicle.InventoryId = rnd.Next(1, 999);
            usedVehicle.Year = rnd.Next(1930, 2023);

            randomMakeModel = rnd.Next(0, carMakes.Count);
            usedVehicle.Make = carMakes[randomMakeModel];
            usedVehicle.Model = carModels[randomMakeModel];
            usedVehicle.Color = carColors[rnd.Next(0, carColors.Count)];
            usedVehicle.Mileage = rnd.Next(0, 100000);
            usedVehicle.Price = rnd.Next(30000, 100000);
            usedVehicle.NewOrUsed = "used";

            InventoryList.availableVehicles.Add(usedVehicle);
        }
    
    }

}
