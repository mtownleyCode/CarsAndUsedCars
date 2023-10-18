
using CarsAndUsedCarsLab.UI;

namespace CarsAndUsedCarsLab.Data
{
    public class MenuItems
    {
        ViewInventory viewInventory = new ViewInventory();
        AddVehicle addVehicle = new AddVehicle();
        EditVehicle editVehicle = new EditVehicle();
        RemoveVehicle removeVehicle = new RemoveVehicle();
        ViewPersonnel viewPersonnel = new ViewPersonnel();
        EditPerson editPerson = new EditPerson();
        AddPerson addPerson = new AddPerson();
        RemovePerson removePerson = new RemovePerson();
        Login login = new Login();

        public Action GetLeaderMenuPath(int pathNumber)
        {
            Action menuPath = null;

            Dictionary<int, Action> leaderMenuCalls = new Dictionary<int, Action>()
            {
                { 1, viewInventory.ViewNewOnlyInventory },
                { 2, viewInventory.ViewUsedOnlyInventory },
                { 3, viewInventory.ViewFullInventory },
                { 4, addVehicle.AddVehicleToInventory },
                { 5, editVehicle.UpdateVehicle },
                { 6, removeVehicle.SellVehicleFromInventory },
                { 7, viewPersonnel.ViewAllPesonnel },
                { 8, editPerson.UpdatePerson },
                { 9, addPerson.AddNewPersonnel },
                { 10, removePerson.RemovePersonel },
                { 11, login.LoginMenu },

            };

            leaderMenuCalls.TryGetValue(pathNumber, out menuPath);

            return menuPath;
        }

        public Action GetHrMenuPath(int pathNumber)
        {
            Action menuPath = null;

            Dictionary<int, Action> hrMenuCalls = new Dictionary<int, Action>()
            {
                { 1, viewPersonnel.ViewAllPesonnel },
                { 2, editPerson.UpdatePerson },
                { 3, addPerson.AddNewPersonnel },
                { 4, removePerson.RemovePersonel },
                { 5, login.LoginMenu },

            };

            hrMenuCalls.TryGetValue(pathNumber, out menuPath);

            return menuPath;
        }

        public Action GetSalesMenuPath(int pathNumber)
        {
            Action menuPath = null;

            Dictionary<int, Action> hrMenuCalls = new Dictionary<int, Action>()
            {
                { 1, viewInventory.ViewNewOnlyInventory },
                { 2, viewInventory.ViewUsedOnlyInventory },
                { 3, viewInventory.ViewFullInventory },
                { 4, addVehicle.AddVehicleToInventory },
                { 5, editVehicle.UpdateVehicle },
                { 6, removeVehicle.SellVehicleFromInventory },
                { 7, login.LoginMenu },

            };

            hrMenuCalls.TryGetValue(pathNumber, out menuPath);

            return menuPath;
        }

        public Dictionary<int, string> leaderMenu = new Dictionary<int, string>()
        {
            { 1, "View New Inventory" },
            { 2, "View Used Inventory" },
            { 3, "View Full Inventory" },
            { 4, "Add Vehicle" },
            { 5, "Edit Vehicle" },
            { 6, "Sell Vehicle" },
            { 7, "View Personnel" },
            { 8, "Edit Personnel" },
            { 9, "Add Personnel" },
            { 10, "Remove Personnel" },
            { 11, "Change User" },
            { 12, "Exit" }
        };

        public Dictionary<int, string> hrMenu = new Dictionary<int, string>()
        {
            { 1, "View Personnel" },
            { 2, "Edit Personnel" },
            { 3, "Add Personnel" },
            { 4, "Remove Personnel" },
            { 5, "Change User" },
            { 6, "Exit" }
        };

        public Dictionary<int, string> salesMenu = new Dictionary<int, string>()
        {
            { 1, "View New Inventory" },
            { 2, "View Used Inventory" },
            { 3, "View Inventory" },
            { 4, "Add Vehicle" },
            { 5, "Edit Vehicle" },
            { 6, "Sell Vehicle" },
            { 7, "Change User" },
            { 8, "Exit" }
        };

    }

}
