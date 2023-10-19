using CarsAndUsedCarsLab.Data;
using CarsAndUsedCarsLab.Models;
using CarsAndUsedCarsLab.UI;

bool continueOn = true;

VehicleDb vehicleDb = new VehicleDb();
NewVehicle vehicle = new NewVehicle();
PersonnelDb _personnelDb = PersonnelDb.Instance();
Login login = new Login();
MainMenu mainMenu = new MainMenu();

vehicleDb.CreateVehicle(6, "new");
vehicleDb.CreateVehicle(6, "used");

for (int i = 1; i < 6; i++)
{
    _personnelDb.CreatePersonnelPerson(i);
}

Console.WriteLine("Welcome to Sly Sam's Dealership!");

Console.WriteLine();

while (continueOn)
{
    login.LoginMenu();

    continueOn = mainMenu.MainDriver();

}

