namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
             var firstCar = new Car();
            firstCar.Make = "Toyota";
            firstCar.Model = "Camry";
            firstCar.Year = 1996;
            Console.WriteLine($"My first car was a {firstCar.Year} {firstCar.Make} {firstCar.Model}.");
        }
    }
}
