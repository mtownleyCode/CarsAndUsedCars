
using CarsAndUsedCarsLab.Models;

namespace CarsAndUsedCarsLab.Data
{
    public class PersonnelDb
    {

        public static Person? CurrentUser;

        public static List<string> names = new List<string>()
        {
            "Trent Smith",
            "Carrie Adams",
            "Greg Stevens",
            "Sean O'Malley",
            "Christine Conway"
        };

        public static List<string> departments = new List<string>()
        {
            "Leader",
            "Sales",
            "Human Resources",

        };
        
       
       public void CreatePersonnelPerson(int id)
        {            
            int randomDepartment;

            Person newPerson = new Person();

            var rnd = new Random();

            newPerson.Id = id;
            newPerson.Name = names[newPerson.Id - 1];

            randomDepartment = rnd.Next(0, departments.Count);
            newPerson.Department = departments[randomDepartment];
            
            if (departments[randomDepartment] != "Human Resources") 
            {
                newPerson.CarsSoldThisMonth = rnd.Next(0, 11);

            }
            newPerson.NumberOfTimesTMOTM = rnd.Next(0, 12 - PersonnelList.personnelPeople.Sum(s => s.NumberOfTimesTMOTM));
            
            PersonnelList.personnelPeople.Add(newPerson);            

        }
            
    }

}
