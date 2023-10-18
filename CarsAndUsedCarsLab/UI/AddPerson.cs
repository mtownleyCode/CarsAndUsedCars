using CarsAndUsedCarsLab.Data;
using CarsAndUsedCarsLab.Models;

namespace CarsAndUsedCarsLab.UI
{
    internal class AddPerson
    {
        bool redoLoop = true;

        public void AddNewPersonnel() 
        {
            string name = "";
            string department = "";

            Console.WriteLine("Name:");
            while (redoLoop)
            {
                name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("Enter a valid name.");
                    redoLoop = true;
                }
                else
                {
                    redoLoop = false;
                }
            }

            Console.WriteLine();

            redoLoop = true;

            Console.WriteLine("Department:");
            while (redoLoop)
            {
                department = Console.ReadLine();
                if (department == "" ||
                    !PersonnelDb.Instance().departments.Contains(department))
                {
                    Console.WriteLine();

                    Console.WriteLine("Enter a valid department. Remember capitalization matters.");
                    
                    redoLoop = true;
                    
                }
                else
                {
                    redoLoop = false;
                }
            }

            Person newPerson = new Person(PersonnelList.personnelPeople.Max(i => i.Id + 1), name, department);

            PersonnelList.personnelPeople.Add(newPerson);

        }

    }

}
