using CarsAndUsedCarsLab.Data;
using CarsAndUsedCarsLab.Models;
using CarsAndUsedCarsLab.UI;

VehicleDb vehicleDb = new VehicleDb();
NewVehicle vehicle = new NewVehicle();
PersonnelDb _personnelDb = PersonnelDb.Instance();
Login login = new Login();

vehicleDb.CreateVehicle(6, "new");
vehicleDb.CreateVehicle(6, "used");

for (int i = 1; i < 6; i++)
{
    _personnelDb.CreatePersonnelPerson(i);
}

login.LoginMenu();


