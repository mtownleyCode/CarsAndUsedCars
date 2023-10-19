using CarsAndUsedCarsLab.Data;

namespace CarsAndUsedCarsLab.UI
{
    internal class Login
    {

        static PersonnelDb _personnelDb = PersonnelDb.Instance();
    
        public void LoginMenu()
        {
            int validNumber = 0;

            bool redoLoop = true;
            bool showFrame = true;

            PersonnelFrame personnelFrame = new PersonnelFrame();
            MainMenu mainMenu = new MainMenu();


            while (redoLoop)
            {
                if (showFrame)
                {
                    personnelFrame.ShowPersonnelFrame();
                }
                
                Console.WriteLine("Who is logging in?");

                if (!int.TryParse(Console.ReadLine(), out validNumber) ||
                   (validNumber <= 0 ||
                    validNumber > PersonnelList.personnelPeople.Count + 1))
                {
                    Console.WriteLine();

                    Console.WriteLine($"Enter a valid number between 1 and {PersonnelList.personnelPeople.Count + 1}.");

                    redoLoop = true;
                    showFrame = false;

                    Console.WriteLine();
                }

                else
                {
                    if (validNumber == PersonnelList.personnelPeople.Count + 1)
                    {
                        redoLoop = false;
                    }
                    else
                    {
                        _personnelDb.CurrentUser = PersonnelList.personnelPeople[validNumber - 1];                        

                        redoLoop = false;

                    }

                }

            }

        }

    }

}
