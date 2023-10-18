
using CarsAndUsedCarsLab.Data;
using CarsAndUsedCarsLab.Data_Management;
using CarsAndUsedCarsLab.Models;

namespace CarsAndUsedCarsLab.UI
{
    public class RemoveVehicle
    {
        static PersonnelDb personnelDb = PersonnelDb.Instance();

        public void SellVehicleFromInventory()
        {
            int validNumber = 0;

            string validAnswer = "";

            bool showFrame = true;
            bool redoInventoryLoop = true;
            bool redoProceed;
            bool redoRemove;
            
        
            InventoryFrame inventoryFrame = new InventoryFrame();
            
            while (redoInventoryLoop)
            {
                redoProceed = true;
                redoRemove = true;

                if (showFrame)
                {
                    inventoryFrame.ShowInventoryFrame(InventoryList.availableVehicles);
                }
                                
                Console.WriteLine("Which vehicle do you want to sell?");

                if (!int.TryParse(Console.ReadLine(), out validNumber) ||
                   (validNumber <= 0 ||
                    validNumber > InventoryList.availableVehicles.Count))
                {
                    Console.WriteLine();

                    Console.WriteLine($"Enter a valid number between 1 and { InventoryList.availableVehicles.Count + 1 }.");

                    Console.WriteLine();

                    redoInventoryLoop = true;
                }
                else
                {
                    while (redoProceed)
                    {
                        Console.WriteLine();
                        Console.WriteLine("This action will permenently delete this vehicle. Proceed?");

                        validAnswer = Console.ReadLine().ToLower();

                        if (validAnswer != "yes" &&
                            validAnswer != "no")
                        {
                            Console.WriteLine("Enter yes or no only.");
                            Console.WriteLine();
                            redoInventoryLoop = true;
                        }

                        else
                        {
                            if (validAnswer == "yes")
                            {
                                Person person = personnelDb.CurrentUser;
                                person.CarsSoldThisMonth++;

                                Console.WriteLine();

                                if (person.CarsSoldThisMonth > 1)
                                {
                                    Console.WriteLine($"Congratulations {person.Name} you have now sold {person.CarsSoldThisMonth} vehicles this month.");
                                }
                                else
                                {
                                    Console.WriteLine($"Congratulations {person.Name} you have now sold {person.CarsSoldThisMonth} vehicle this month.");
                                }

                                Vehicle vehicle = InventoryList.availableVehicles[validNumber -1];
                                Inventory.RemoveVehicleFromInventory(vehicle);
                                
                                Console.WriteLine();
                                
                                while (redoRemove)
                                {
                                    Console.WriteLine("Do you want to sell another vehicle?");

                                    validAnswer = Console.ReadLine().ToLower();

                                    if (validAnswer != "yes" &&
                                        validAnswer != "no")
                                    {
                                        Console.WriteLine("Enter yes or no only.");
                                        Console.WriteLine();
                                        redoRemove = true;
                                    }

                                    else
                                    {
                                        if (validAnswer == "yes")
                                        {
                                            redoProceed = false;
                                            redoRemove = false;
                                            redoInventoryLoop = true;

                                            Console.WriteLine();

                                        }
                                        else
                                        {
                                            redoProceed = false;
                                            redoRemove = false;
                                            redoInventoryLoop = false;

                                        }

                                    }

                                }

                            }
                            else
                            {
                                Console.WriteLine();

                                redoProceed = false;
                            }

                        }

                    }

                }

                redoRemove = true;

            }

        }

    }

}
