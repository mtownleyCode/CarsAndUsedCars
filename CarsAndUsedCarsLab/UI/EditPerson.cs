
using CarsAndUsedCarsLab.Data;
using CarsAndUsedCarsLab.Models;
using System.Diagnostics;

namespace CarsAndUsedCarsLab.UI
{
    internal class EditPerson
    {
        public void UpdatePerson()
        {
            int validNumber = 0;

            bool redoLoop = true;
            bool showFrame = true;

            PersonnelFrame personnelFrame = new PersonnelFrame();


            while (redoLoop)
            {
                if (showFrame)
                {
                    personnelFrame.ShowPersonnelFrame();
                }

                Console.WriteLine("Which person do you want to edit?");

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
                    Console.WriteLine();

                    if (validNumber == PersonnelList.personnelPeople.Count + 1)
                    {
                        redoLoop = false;
                    }
                    else
                    {
                        Edit(PersonnelList.personnelPeople[validNumber - 1]);

                        showFrame = true;
                        redoLoop = true;
                    }

                }

            }

        }

        private void Edit(Person person)
        {
            bool proceed = false;
            bool redoDepartmentLoop = true;

            Console.WriteLine($"The name of this person is { person.Name }. Do you want to change this? y/n");

            proceed = ValidateStringAnswer();

            if (proceed)
            {
                Console.WriteLine("What is the new name?");

                person.Name = Console.ReadLine();

                Console.WriteLine();

            }

            Console.WriteLine($"This person works in the { person.Department } department. Do you want to change this? y/n");

            proceed = ValidateStringAnswer();

            if (proceed)
            {                                
                while (redoDepartmentLoop)
                {
                    Console.WriteLine("What is the new department? Remember capitalization matters.");

                    person.Department = Console.ReadLine(); 
                    if (person.Department == "" ||
                        !PersonnelDb.departments.Contains(person.Department))
                    {
                        Console.WriteLine();

                        Console.WriteLine("Enter a valid department.");

                        redoDepartmentLoop = true;

                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();

                        redoDepartmentLoop = false;
                    }
                }
            }

        }

        private bool ValidateStringAnswer()
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
                    Console.WriteLine();

                    Console.WriteLine("Enter y or n only.");

                    redoEditLoop = true;

                }
                else
                {
                    if (validAnswer == "y")
                    {
                        proceed = true;
                    }
                    else
                    {
                        proceed = false;
                    }

                    Console.WriteLine();

                    redoEditLoop = false;
                }

            }

            return proceed;

        }

    }

}
