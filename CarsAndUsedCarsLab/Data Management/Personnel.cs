using CarsAndUsedCarsLab.Data;
using CarsAndUsedCarsLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCarsLab.Data_Management
{
    internal class Personnel
    {
        public static void AddPersonnel(Person person) => PersonnelList.personnelPeople.Add(person);

        public static void RemovePersonnel(Person person) => PersonnelList.personnelPeople.Remove(person);

    }

}
