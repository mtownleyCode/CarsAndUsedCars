namespace CarsAndUsedCarsLab.Models
{
    public class UsedVehicle : Vehicle
    {
        public double Mileage;


        public UsedVehicle() 
        {
            InventoryId = 0;
            Year = 0;
            Make = "";
            Model = "";
            Color = "";
            NewOrUsed = "";
            Price = 0;

            Mileage = 0;

        }

        public UsedVehicle(int inventoryId, int year, string make, string model, string color, double price, double mileage, string newOrUsed) : 
            base (inventoryId, year, make, model, color, newOrUsed, price)
        {
           Mileage = mileage;

        }

    }

}
