class Program
{
    static void Main(string[] args)
    {
        Car car = new Car(5, 50, 145, 10, 5);
        car.Refuel(30);
        car.Move(100, 200);
        Console.WriteLine(car);
    }
}