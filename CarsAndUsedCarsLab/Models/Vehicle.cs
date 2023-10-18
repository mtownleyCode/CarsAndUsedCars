namespace CarsAndUsedCarsLab.Models
{
    public abstract class Vehicle
    {
        public int InventoryId { get; set; }
        public int Year { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string NewOrUsed { get; set; }

        public double Price { get; set; }


        public Vehicle()
        {
            InventoryId = 0;
            Year = 0;
            Make = "";
            Model = "";
            Color = "";
            NewOrUsed = "";
            Price = 0;

        }

        public Vehicle(int inventoryId, int year, string make, string model, string color, string newOrUsed, double price)
        {
            InventoryId = inventoryId;
            Year = year;
            Make = make;
            Model = model;
            Color = color;
            NewOrUsed = newOrUsed;
            Price = price;

        }

    }
}
