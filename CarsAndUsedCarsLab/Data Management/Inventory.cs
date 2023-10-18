using CarsAndUsedCarsLab.Data;

using CarsAndUsedCarsLab.Models;

namespace CarsAndUsedCarsLab.Data_Management
{
    public class Inventory
    {
        public static void AddVehicleToInventory(Vehicle vehicle)
        {            
            InventoryList.availableVehicles.Add(vehicle);
        }

        public static void RemoveVehicleFromInventory(Vehicle vehicle)
        {
            InventoryList.availableVehicles.Remove(vehicle);
        }               

    }

}
