
using CarsAndUsedCarsLab.Data;

namespace CarsAndUsedCarsLab.UI
{
    public class ViewInventory
    {
        public void ViewFullInventory()
        {
            int validNumber;

            bool redoLoop = true;
            bool showFrame = true;

                        
            InventoryFrame inventoryFrame = new InventoryFrame();
            VehicleDetails vehicleDetails = new VehicleDetails();

            while (redoLoop)
            {
                if (showFrame)
                {
                    inventoryFrame.ShowInventoryFrame(InventoryList.availableVehicles);
                }

                Console.WriteLine("Which vehicle do you want to view?");
                

                if (!int.TryParse(Console.ReadLine(), out validNumber) ||
                   (validNumber <= 0 ||
                    validNumber > InventoryList.availableVehicles.Count + 1))
                {
                    Console.WriteLine();

                    Console.WriteLine($"Enter a valid number between 1 and { InventoryList.availableVehicles.Count + 1 }.");
                    
                    redoLoop = true;
                    showFrame = false;

                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine();

                    if (validNumber == InventoryList.availableVehicles.Count + 1)
                    {
                        redoLoop = false;
                    }
                    else
                    {
                        vehicleDetails.ViewSingleVehicle(InventoryList.availableVehicles[validNumber - 1]);

                        showFrame = true;
                        redoLoop = true;
                    }

                }

            }

        }

        public void ViewNewOnlyInventory()
        {
            int validNumber;

            bool redoLoop = true;
            bool showFrame = true;


            InventoryFrame inventoryFrame = new InventoryFrame();
            VehicleDetails vehicleDetails = new VehicleDetails();

            var newVehicles = InventoryList.availableVehicles.Where(i => i.NewOrUsed == "new").ToList();


            while (redoLoop)
            {
                if (showFrame)
                {
                    inventoryFrame.ShowInventoryFrame(newVehicles);
                }

                Console.WriteLine("Which vehicle do you want to view?");


                if (!int.TryParse(Console.ReadLine(), out validNumber) ||
                   (validNumber <= 0 ||
                    validNumber > InventoryList.availableVehicles.Count + 1))
                {
                    Console.WriteLine();

                    Console.WriteLine($"Enter a valid number between 1 and { newVehicles.Count + 1 }.");

                    redoLoop = true;
                    showFrame = false;

                    Console.WriteLine();

                }

                else
                {
                    Console.WriteLine();

                    if (validNumber == newVehicles.Count + 1)
                    {
                        redoLoop = false;
                    }
                    else
                    {
                        vehicleDetails.ViewSingleVehicle(newVehicles[validNumber - 1]);

                        showFrame = true;
                        redoLoop = true;

                    }

                }

            }

        }

        public void ViewUsedOnlyInventory()
        {
            int validNumber;

            bool redoLoop = true;
            bool showFrame = true;

            InventoryFrame inventoryFrame = new InventoryFrame();
            VehicleDetails vehicleDetails = new VehicleDetails();

            var usedVehicles = InventoryList.availableVehicles.Where(i => i.NewOrUsed == "used").ToList();


            while (redoLoop)
            {
                if (showFrame)
                {
                    inventoryFrame.ShowInventoryFrame(usedVehicles);
                }

                Console.WriteLine("Which vehicle do you want to view?");


                if (!int.TryParse(Console.ReadLine(), out validNumber) ||
                   (validNumber <= 0 ||
                    validNumber > InventoryList.availableVehicles.Count + 1))
                {
                    Console.WriteLine();

                    Console.WriteLine($"Enter a valid number between 1 and { usedVehicles.Count + 1 }.");

                    redoLoop = true;
                    showFrame = false;

                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine();

                    if (validNumber == usedVehicles.Count + 1)
                    {
                        redoLoop = false;
                    }
                    else
                    {
                        vehicleDetails.ViewSingleVehicle(usedVehicles[validNumber - 1]);

                        showFrame = true;
                        redoLoop = true;
                    }

                }

            }

        }

    }

}