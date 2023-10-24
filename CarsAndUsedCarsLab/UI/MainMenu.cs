using CarsAndUsedCarsLab.Data;
using System.Reflection.Metadata.Ecma335;

namespace CarsAndUsedCarsLab.UI
{
    public class MainMenu
    {
        public bool MainDriver()
        {
            int iCNT = 1;
            int validNumber;
            int numOfMenuItems = 0;

            string formattedItem = "";
            
            bool exit = false;
            bool redoLoop = true;
            bool continueOn = true;

            Action action;

            MenuItems menuItems = new MenuItems();
            
            Console.WriteLine();

            while (!exit)
            {
                Console.WriteLine(String.Format("{0,-21} {1,-9} {2, -21}", "=====================", "Main Menu", "====================="));
                Console.WriteLine(String.Format("{0, -54}", "=                                                   ="));
                Console.WriteLine(String.Format("{0,-13} {1,-6} {2, 32}", "=", "Action", "="));
                Console.WriteLine(String.Format("{0,-6} {1,-6} {2, -37} {3, 1}", "=", "---", "--------------------------------", "="));

                if (PersonnelDb.CurrentUser.Department.ToLower() == "leader")
                {
                    foreach (var entry in menuItems.leaderMenu)
                    {
                        if (entry.Value.ToLower() != "exit")
                        {
                            Console.WriteLine(String.Format("{0,-6} {1,-6} {2, -36} {3, 1}", "=", entry.Key, entry.Value, " = "));
                        }
                        else
                        {
                            Console.WriteLine(String.Format("{0, -54}", "=                                                   ="));
                            Console.WriteLine(String.Format("{0,-6} {1,-6} {2, -36} {3, 1}", "=", entry.Key, entry.Value, " = "));
                        }

                    }

                    numOfMenuItems = menuItems.leaderMenu.Count;

                }

                if (PersonnelDb.CurrentUser.Department.ToLower() == "human resources")
                {
                    foreach (var entry in menuItems.hrMenu)
                    {
                        if (entry.Value.ToLower() != "exit")
                        {
                            Console.WriteLine(String.Format("{0,-6} {1,-6} {2, -36} {3, 1}", "=", entry.Key, entry.Value, " = "));
                        }
                        else
                        {
                            Console.WriteLine(String.Format("{0, -54}", "=                                                   ="));
                            Console.WriteLine(String.Format("{0,-6} {1,-6} {2, -36} {3, 1}", "=", entry.Key, entry.Value, " = "));
                        }

                    }

                    numOfMenuItems = menuItems.hrMenu.Count;

                }

                if (PersonnelDb.CurrentUser.Department.ToLower() == "sales")
                {
                    foreach (var entry in menuItems.salesMenu)
                    {
                        if (entry.Value.ToLower() != "exit")
                        {
                            Console.WriteLine(String.Format("{0,-6} {1,-6} {2, -36} {3, 1}", "=", entry.Key, entry.Value, " = "));
                        }
                        else
                        {
                            Console.WriteLine(String.Format("{0, -54}", "=                                                   ="));
                            Console.WriteLine(String.Format("{0,-6} {1,-6} {2, -36} {3, 1}", "=", entry.Key, entry.Value, " = "));
                        }

                        numOfMenuItems = menuItems.salesMenu.Count;

                    }

                }

                Console.WriteLine(String.Format("{0, -54}", "=                                                   ="));
                Console.WriteLine(String.Format("{0,-54}", "====================================================="));

                Console.WriteLine();
                Console.Write("Enter a selection: ");

                while (redoLoop)
                {

                    if (!int.TryParse(Console.ReadLine(), out validNumber) ||
                       (validNumber <= 0 ||
                        validNumber > numOfMenuItems))
                    {
                        Console.WriteLine($"Enter a valid number between 1 and { numOfMenuItems + 1}.");
                        redoLoop = true;
                    }

                    else
                    {
                        if (validNumber == numOfMenuItems - 1)
                        {
                            continueOn = true;
                        }
                        if (validNumber == numOfMenuItems)
                        {
                            redoLoop = false;
                            exit = true;
                            continueOn = false;
                        }
                        else
                        {
                            Console.WriteLine();

                            if (PersonnelDb.CurrentUser.Department.ToLower() == "leader")
                            {
                                action = menuItems.GetLeaderMenuPath(validNumber);
                                action();

                            }

                            if (PersonnelDb.CurrentUser.Department.ToLower() == "human resources")
                            {
                                action = menuItems.GetHrMenuPath(validNumber);
                                action();

                            }

                            if (PersonnelDb.CurrentUser.Department.ToLower() == "sales")
                            {
                                action = menuItems.GetSalesMenuPath(validNumber);
                                action();

                            }

                            Console.WriteLine();

                            redoLoop = false;

                        }

                    }

                }

                redoLoop = true;
           
            }

            return continueOn;

        }

    }

}
