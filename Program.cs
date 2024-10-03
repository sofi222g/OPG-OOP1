namespace Polymorfi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> vehicle = new List<string>();
            //vehicle.Add("Toyota");

            CarFerry ferry = new CarFerry("Heavy", 1000);

            Vehicle Volvo = new Vehicle("123", 1800);

            ferry.addVehicle(Volvo);
        }
    }
}
