namespace Skistar.Models
{
    public interface IHasEngine
    {

    }
    public class Car : Vehicle, IHasEngine
    {
        public Truck Truck { get; set; } 
        public string Make { get; set; }
    }

    public class Truck : Vehicle
    {
        public override void Cargo()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            Car car = new Car();
            car.Truck = new Truck();
            car.Make = "asfas";
        }
    }

    public class Vehicle
    {
        public int Id { get; set; }
        public void Run()
        {
            // sdfa 
        }

        public virtual void Cargo()
        {
            // sdfa 
        }
    }

}
