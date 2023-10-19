using CarsAndUsedCarsLab.Data;
using CarsAndUsedCarsLab.Models;

namespace CarsAndUsedCarsLab.UI
{
    public class PersonnelFrame
    {
        public void ShowPersonnelFrame()
        {
            int iCNT = 1;

            string formattedId;
            string formattedName;
            string formattedCarsSold;


            Console.WriteLine(String.Format("{0, -19} {1, -9} {2, -20}", "====================", "Personnel", "====================="));
            Console.WriteLine(String.Format("{0, -52}", "=                                                  ="));
            Console.WriteLine(String.Format("{0, -3} {1, -7} {2, -22} {3, -13} {4, 3}", "=", "ID", "Name", "Month's Sales", "="));
            Console.WriteLine(String.Format("{0, -3} {1, -7} {2, -22} {3, -13} {4, 3}", "=", "-----", "--------------------", "-------------", "="));

            foreach (Person person in PersonnelList.personnelPeople)
            {
                formattedId = iCNT.ToString().Length > 20 ? formattedId = iCNT.ToString().Substring(0, 10) : iCNT.ToString();

                formattedName = person.Name.Length > 20 ? formattedName = person.Name.Substring(0, 10) : person.Name;
                                
                Console.WriteLine(string.Format("{0,-3} {1, -7} {2, -22} {3,-15} {4, 1}", $"=", formattedId, formattedName, person.CarsSoldThisMonth, "="));

                iCNT++;

            }

            Console.WriteLine(String.Format("{0, -52}", "=                                                  ="));
            Console.WriteLine(String.Format("{0, -3} {1, -7} {2, -38} {3, 1}", "=", PersonnelList.personnelPeople.Count + 1, "Exit", "="));
            Console.WriteLine(String.Format("{0, -52}", "=                                                  ="));
            Console.WriteLine(String.Format("{0, -50}", "===================================================="));

            Console.WriteLine();
        }

    }

}
