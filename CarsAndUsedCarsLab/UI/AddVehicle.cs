using CarsAndUsedCarsLab.Data;
using CarsAndUsedCarsLab.Data_Management;
using CarsAndUsedCarsLab.Models;


namespace CarsAndUsedCarsLab.UI
{
    public class AddVehicle
    {
        public void AddVehicleToInventory()
        {
            int validInt = 0;
            int year = 0;

            string make = "";
            string model = "";
            string color = "";
            string validAnswer = "";

            double validDouble = 0;
            double mileage = 0;
            double price = 0;

            bool redoLoop = true;


            Console.WriteLine();

            Console.WriteLine("Enter the vehicle's information.");

            Console.WriteLine();

            Console.Write("Year: ");
            while (redoLoop)
            {
                if (!int.TryParse(Console.ReadLine(), out validInt) ||
                    validInt <= 0)
                {
                    Console.WriteLine($"Enter a valid number greater than 0.");
                    redoLoop = true;
                }

                else
                {
                    year = validInt;
                    redoLoop = false;
                }

            }

            Console.WriteLine();

            Console.Write("Make: ");
            make = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Color: ");
            color = Console.ReadLine();
            Console.WriteLine();

            redoLoop = true;

            Console.Write("Price: ");
            while (redoLoop)
            {
                if (!double.TryParse(Console.ReadLine(), out validDouble) ||
                    validDouble <= 0)
                {
                    Console.WriteLine($"Enter a valid number greater than 0.");
                    redoLoop = true;
                }

                else
                {
                    price = validDouble;
                    redoLoop = false;
                }

            }

            Console.WriteLine();


            Console.WriteLine("Is this vehicle new or used?");

            redoLoop = true;

            while (redoLoop)
            {
                validAnswer = Console.ReadLine().ToLower();

                if (validAnswer != "new" &&
                    validAnswer != "used")
                {
                    Console.WriteLine("Enter new or used only.");
                    Console.WriteLine();
                    redoLoop = true;
                }

                else
                {
                    if (validAnswer == "new")
                    {
                        Console.WriteLine();
                        NewVehicle newVehicle = new NewVehicle(InventoryList.availableVehicles.Max(i => i.InventoryId + 1), year, make, model, color, price, validAnswer);

                        Inventory.AddVehicleToInventory(newVehicle);

                    }
                    else
                    {
                        redoLoop = true;

                        Console.WriteLine();

                        Console.Write("Mileage: ");
                        while (redoLoop)
                        {
                            if (!double.TryParse(Console.ReadLine(), out validDouble) ||
                                validDouble <= 0)
                            {
                                Console.WriteLine($"Enter a valid number greater than 0.");
                                redoLoop = true;
                            }

                            else
                            {
                                mileage = validDouble;
                                redoLoop = false;
                            }

                        }

                        UsedVehicle usedVehicle = new UsedVehicle(InventoryList.availableVehicles.Max(i => i.InventoryId + 1), year, make, model, color, price, mileage, validAnswer);

                        Inventory.AddVehicleToInventory(usedVehicle);

                    }

                    redoLoop = false;

                }
                
            }

        }

    }

}
