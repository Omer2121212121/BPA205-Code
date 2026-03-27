using Vehicle_Management_System.Models;

namespace Vehicle_Management_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car("Mercedes", "C-Class", 2020, "Hibrid", 4);
            Car myCar2 = new Car("BMW", "M4", 1899, "Diesel", 2);
            Motorcycle myMotorcycle = new Motorcycle("Yamaha", "MT-07", 2019, "Gasoline", 4);
            Truck myTruck = new Truck("Ford", "F-150", 2021, 1000);
            Garage myGarage = new Garage();
            myGarage.AddVehicle(myCar1);
            myGarage.AddVehicle(myCar2);
            myGarage.AddVehicle(myMotorcycle);
            myGarage.AddVehicle(myTruck);
            myGarage.ShowAllVehicles();
        }
    }
}
