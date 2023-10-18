using CarsAndUsedCarsLab.UI;

namespace CarsAndUsedCarsLab.Models
{
    public class NewVehicle : Vehicle
    {
        public NewVehicle() 
        {
            InventoryId = 0;
            Year = 0;
            Make = "";
            Model = "";
            Color = "";
            NewOrUsed = "";
            Price = 0;
        
        }

        public NewVehicle(int inventoryId, int year, string make, string model, string color, double price, string newOrUsed) :
            base(inventoryId, year, make, model, color, newOrUsed, price)
        {

        }

    }

}
