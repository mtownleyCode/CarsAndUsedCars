using CarsAndUsedCarsLab.Data;
using CarsAndUsedCarsLab.Data_Management;
using CarsAndUsedCarsLab.Models;


namespace CarsAndUsedCarsLab.UI
{
    internal class EditVehicle
    {
        public void UpdateVehicle()
        {
            int validNumber;

            bool redoLoop = true;
            bool showFrame = true;


            InventoryFrame inventoryFrame = new InventoryFrame();

            while (redoLoop)
            {
                if (showFrame)
                {
                    inventoryFrame.ShowInventoryFrame(InventoryList.availableVehicles);
                }

                Console.WriteLine("Which vehicle do you want to edit?");

                if (!int.TryParse(Console.ReadLine(), out validNumber) ||
                   (validNumber <= 0 ||
                    validNumber > InventoryList.availableVehicles.Count + 1))
                {
                    Console.WriteLine();

                    Console.WriteLine($"Enter a valid number between 1 and {InventoryList.availableVehicles.Count + 1}.");

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
                        Edit(InventoryList.availableVehicles[validNumber - 1]);
            
                        showFrame = true;
                        redoLoop = true;
                    }

                }

            }

        }

        public void Edit(Vehicle currentVehicle)
        {

            string validAnswer = "";

            bool proceed = false;
            bool redoLoop = true;
            bool newOrUsedChanged = false;
                        
            UsedVehicle usedVehicle = new UsedVehicle();


            Console.WriteLine($"The year of this vehicle is { currentVehicle.Year }. Do you want to change this? y/n");

            proceed = ValidateStringAnswer();

            if (proceed)
            {
                Console.WriteLine("What do you want the year to be?");

                currentVehicle.Year = ValidateIntAnswer();

            }                    
                       
            Console.WriteLine();

            Console.WriteLine($"The make of the vehicle is { currentVehicle.Make }. Do you want to change this? y/n");

            proceed = ValidateStringAnswer();

            if (proceed)
            {
                Console.WriteLine("What do you want the make to be?");

                currentVehicle.Make = Console.ReadLine();
                            
            }

            Console.WriteLine();

            Console.WriteLine($"The model of the vehicle is { currentVehicle.Model }. Do you want to change this? y/n");

            proceed = ValidateStringAnswer();
            
            if (proceed)
            {
                Console.WriteLine("What do you want the model to be?");

                currentVehicle.Model = Console.ReadLine();

            }

            Console.WriteLine();

            Console.WriteLine($"The model of the vehicle is { currentVehicle.Color }. Do you want to change this? y/n");

            proceed = ValidateStringAnswer();

            if (proceed)
            {
                Console.WriteLine("What do you want the color to be?");

                currentVehicle.Color = Console.ReadLine();

            }

            Console.WriteLine();

            Console.WriteLine($"The price of this vehicle is { currentVehicle.Price }. Do you want to change this? y/n");

            proceed = ValidateStringAnswer();

            if (proceed)
            {
                Console.WriteLine("What do you want the price to be?");

                currentVehicle.Price = ValidateDoubleAnswer();

            }

            Console.WriteLine();

            Console.WriteLine($"This vehicle is { currentVehicle.NewOrUsed }. Do you want to change this? y/n");

            proceed = ValidateStringAnswer();

            if (proceed)
            {
                Console.WriteLine();

                Console.WriteLine("Is this car new or used?");

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
                        if (currentVehicle.NewOrUsed != validAnswer)
                        {
                            newOrUsedChanged = true;
                        }

                        currentVehicle.NewOrUsed = validAnswer;

                        if (newOrUsedChanged)
                        {
                            if (validAnswer == "new")
                            {
                                NewVehicle newVehicle = new NewVehicle(currentVehicle.InventoryId, currentVehicle.Year, currentVehicle.Make, currentVehicle.Model, 
                                                                       currentVehicle.Color, currentVehicle.Price, validAnswer);

                                Inventory.AddVehicleToInventory(newVehicle);

                                Inventory.RemoveVehicleFromInventory(currentVehicle);

                            }

                            else
                            {
                                usedVehicle = new UsedVehicle(currentVehicle.InventoryId, currentVehicle.Year, currentVehicle.Make, currentVehicle.Model, 
                                                              currentVehicle.Color, currentVehicle.Price, 0, validAnswer);
                                Inventory.AddVehicleToInventory(usedVehicle);

                                Inventory.RemoveVehicleFromInventory(currentVehicle);
                            }

                        }


                        redoLoop = false;
                                                
                    }
                }

            }

            if (usedVehicle.NewOrUsed == "used")
            {
                Console.WriteLine();

                Console.WriteLine($"The mileage on this car is {usedVehicle.Mileage}.  Do you want to change this? y/n ");

                proceed = ValidateStringAnswer();

                if (proceed)
                {
                    usedVehicle.Mileage = ValidateDoubleAnswer();
                }

            }

        }

        public bool ValidateStringAnswer() 
        {
            string validAnswer = "";

            bool redoEditLoop = true;
            bool proceed = false;

            while (redoEditLoop)
            {
                validAnswer = Console.ReadLine().ToLower();

                if (validAnswer != "y" &&
                    validAnswer != "n")
                {
                    Console.WriteLine("Enter y or n only.");

                    redoEditLoop = true;

                    Console.WriteLine();

                }
                else
                {
                    if (validAnswer == "y")
                    {
                        proceed =  true;
                    }
                    else
                    {
                        proceed =  false;
                    }

                    redoEditLoop = false;
                }

            }

            return proceed;

        }

        public int ValidateIntAnswer()
        {
            int validInt = 0;
            int finalInt;

            bool redoIntLoop = true;

            while (redoIntLoop)
            {
                if (!int.TryParse(Console.ReadLine(), out validInt) ||
                    validInt <= 0)
                {
                    Console.WriteLine($"Enter a valid number greater than 0.");
                    redoIntLoop = true;
                }

                else
                {                    
                    redoIntLoop = false;

                }

            }

            return validInt;

        }

        public double ValidateDoubleAnswer()
        {
            double validDouble = 0;

            bool redoDoubleLoop = true;

            while (redoDoubleLoop)
            {
                if (!double.TryParse(Console.ReadLine(), out validDouble) ||
                    validDouble <= 0)
                {
                    Console.WriteLine($"Enter a valid number greater than 0.");
                    redoDoubleLoop = true;
                }

                else
                {
                    redoDoubleLoop = false;

                }

            }

            return validDouble;

        }

    }       

}

