namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car.InfoCar infoCar = new Car.InfoCar();
            infoCar.Name = "Test";
            Console.WriteLine("Test");
            Console.ReadKey();
        }
    }
}

namespace Car
{
     public class InfoCar
    {
        public string Name { get; set; }
    }
}