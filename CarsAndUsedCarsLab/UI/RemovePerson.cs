using CarsAndUsedCarsLab.Data;
using CarsAndUsedCarsLab.Data_Management;
using CarsAndUsedCarsLab.Models;


namespace CarsAndUsedCarsLab.UI
{
    internal class RemovePerson
    {        
        public void RemovePersonel()
        {
            int validNumber = 0;

            string validAnswer = "";

            bool showFrame = true;
            bool redoPersonLoop = true;
            bool redoProceedLoop = true;
            bool redoRemove = true;

            Person person = new Person();
            PersonnelFrame personnelFrame = new PersonnelFrame();

            PersonnelDb _personnelDb = PersonnelDb.Instance();


            while (redoPersonLoop)
            {
                redoProceedLoop = true;
                redoRemove = true ;

                if (showFrame)
                {
                    personnelFrame.ShowPersonnelFrame();
                }

                Console.WriteLine("Which person do you want to remove?");

                if (!int.TryParse(Console.ReadLine(), out validNumber) ||
                   (validNumber <= 0 ||
                    validNumber > PersonnelList.personnelPeople.Count + 1))
                {
                    Console.WriteLine();

                    Console.WriteLine($"Enter a valid number between 1 and { PersonnelList.personnelPeople.Count + 1 }.");

                    Console.WriteLine();
                    
                    redoPersonLoop = true;
                    showFrame = false;

                }
                else
                {
                    while (redoProceedLoop)
                    {
                        if (validNumber == PersonnelList.personnelPeople.Count + 1)
                        {
                            redoPersonLoop = false;
                        }

                        else if (PersonnelList.personnelPeople[validNumber - 1] == _personnelDb.CurrentUser)
                        {
                            Console.WriteLine();
                            
                            Console.WriteLine("You cannot delete the current user.");
                            
                            Console.WriteLine();

                            redoPersonLoop = true;
                            showFrame = false;

                            break;

                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("This action will permenently delete this person. Proceed?");

                            validAnswer = Console.ReadLine().ToLower();

                            if (validAnswer != "yes" &&
                                validAnswer != "no")
                            {
                                Console.WriteLine("Enter yes or no only.");

                                Console.WriteLine();

                                redoProceedLoop = true;

                            }

                            else
                            {
                                if (validAnswer == "yes")
                                {
                                    person = PersonnelList.personnelPeople[validNumber - 1];
                                    Personnel.RemovePersonnel(person);

                                    redoProceedLoop = false;

                                    Console.WriteLine();

                                }
                                else
                                {
                                    Console.WriteLine();

                                    redoProceedLoop = false;

                                }

                            }

                            while (redoRemove)
                            {
                                Console.WriteLine("Do you want to remove another person?");

                                validAnswer = Console.ReadLine().ToLower();

                                if (validAnswer != "yes" &&
                                    validAnswer != "no")
                                {
                                    Console.WriteLine();

                                    Console.WriteLine("Enter yes or no only.");

                                    Console.WriteLine();

                                    redoRemove = true;
                                }

                                else
                                {
                                    if (validAnswer == "yes")
                                    {
                                        Console.WriteLine();

                                        redoProceedLoop = false;
                                        redoRemove = false;
                                        redoPersonLoop = true;
                                        

                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        redoRemove = false;
                                        redoPersonLoop = false;

                                    }

                                }

                            }

                        }

                    }

                        showFrame = true;

               }

            }

        }

    }

}
