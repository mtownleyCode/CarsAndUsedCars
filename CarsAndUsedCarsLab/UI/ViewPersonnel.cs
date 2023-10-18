
using CarsAndUsedCarsLab.Data;

namespace CarsAndUsedCarsLab.UI
{
    public class ViewPersonnel
    {
        public void ViewAllPesonnel()
        {
            int validNumber;

            bool redoLoop = true;
            bool showFrame = true;
            
            PersonnelFrame personnelFrame = new PersonnelFrame();
            PersonnelDetail personnelDetail = new PersonnelDetail();

            while (redoLoop)
            {
                if (showFrame)
                {
                    personnelFrame.ShowPersonnelFrame();
                }

                Console.WriteLine("Which person do you want to view?");

                if (!int.TryParse(Console.ReadLine(), out validNumber) ||
                   (validNumber <= 0 ||
                    validNumber > PersonnelList.personnelPeople.Count + 1))
                {
                    Console.WriteLine();

                    Console.WriteLine($"Enter a valid number between 1 and { PersonnelList.personnelPeople.Count + 1 }.");
                    
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
                        personnelDetail.ViewSinglePerson(PersonnelList.personnelPeople[validNumber - 1]);

                        redoLoop = true;

                    }

                    showFrame = true;

                }

            }

        }
   
    }

}