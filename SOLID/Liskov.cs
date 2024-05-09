namespace SOLID
{
    public class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Engine Started");
        }
    }  

    public class ElectricCar : Vehicle
    {
        public override void StartEngine()
        {
            // Electric cars don't have traditional engines
            Console.WriteLine("Electric car Engine Started");
        }
    }
    public class PetrolCar : Vehicle
    {
        public override void StartEngine()
        {
            // Petrol cars have traditional engines
            Console.WriteLine("Petrol car Engine Started");
        }
    }

    public class Driver
    {
        public void StartVehicleEngine(Vehicle vehicle)
        {
            vehicle.StartEngine();
        }
    }

    public class Liskov
    {
        public Liskov()
        {
            Driver driver = new();

            Vehicle PetrolCar = new PetrolCar();            
            Vehicle ElectricCar = new ElectricCar();

            driver.StartVehicleEngine(PetrolCar);
             driver.StartVehicleEngine(ElectricCar); // Violation of LSP
        }
    }

}

