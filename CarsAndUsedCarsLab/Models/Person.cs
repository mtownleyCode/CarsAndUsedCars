namespace CarsAndUsedCarsLab.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public int CarsSoldThisMonth { get; set; }
        // TMOTH = Team Member of the Month
        public int NumberOfTimesTMOTM { get; set; }


        public Person()
        {
            Id = 0;
            Name = "";
            Department = "";
            CarsSoldThisMonth = 0;
            NumberOfTimesTMOTM = 0;
        }

        public Person(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;

        }

    }

}
