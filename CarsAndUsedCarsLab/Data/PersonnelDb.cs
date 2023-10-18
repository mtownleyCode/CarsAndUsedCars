
using CarsAndUsedCarsLab.Models;
using System.Net.Http.Headers;

namespace CarsAndUsedCarsLab.Data
{
    sealed class PersonnelDb
    {
        private PersonnelDb() { }

        private static PersonnelDb _instance;
        private static readonly object _lock = new Object();

        public static PersonnelDb Instance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PersonnelDb();
                    }

                }

                _instance = new PersonnelDb();
            }

            return _instance;

        }

        public Person? CurrentUser;

        List<string> names = new List<string>()
        {
            "Trent Smith",
            "Carrie Adams",
            "Greg Stevens",
            "Sean O'Malley",
            "Christine Conway"
        };

        public List<string> departments = new List<string>()
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
