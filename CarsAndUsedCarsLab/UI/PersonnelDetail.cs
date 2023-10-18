using CarsAndUsedCarsLab.Models;

namespace CarsAndUsedCarsLab.UI
{
    internal class PersonnelDetail
    {
        public void ViewSinglePerson(Person person)
        {
            string validAnswer = "";
            string formattedName;
            string formattedDepartment;

            bool redoLoop = true;

            formattedName = person.Name.Length > 16 ? formattedName = person.Name.Substring(0, 16) : person.Name;

            formattedDepartment = person.Department.Length > 16 ? formattedDepartment = person.Department.Substring(0, 16) : person.Department;
           
            while (redoLoop)
            {
                Console.WriteLine();

                Console.WriteLine(String.Format("{0,-18} {1,-10} {2, 3} {3, 18}", "==================", "Person ID#", person.Id, $"=================="));
                Console.WriteLine(String.Format("{0,-51}", "=                                                  ="));
                Console.WriteLine(String.Format("{0,-4} {1,-5} {2, -19} {3, -13} {4, -4} {5, -1}", "=", "Name:", formattedName, "Month's Sales:", person.CarsSoldThisMonth, "="));
                Console.WriteLine(String.Format("{0,-51}", "=                                                  ="));
                Console.WriteLine(String.Format("{0,-4} {1,-5} {2, -17} {3, -14} {4, -4} {5, -1}", "=", "Dept:", formattedDepartment, "Team Member OTM:", person.NumberOfTimesTMOTM, "="));
                Console.WriteLine(String.Format("{0,-51}", "=                                                  ="));
                Console.WriteLine(String.Format("{0,-50}", "===================================================="));

                Console.WriteLine();

                Console.WriteLine("Type exit when you are done viewing this person.");

                validAnswer = Console.ReadLine().ToLower();

                if (validAnswer != "exit")
                {
                    Console.WriteLine("Type exit only.");
                  
                    redoLoop = true;                                        

                }

                else
                {
                    redoLoop = validAnswer == "exit" ? false : true;
                    Console.WriteLine() ;

                }

            }

        }
        
    }

}
