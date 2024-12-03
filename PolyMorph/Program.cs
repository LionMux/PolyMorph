class Program
{
    static void Main(string[] args)
    {
        ElectroCar car = new ElectroCar(5, 50, 145, 10, 5);
        car.Refuel(30);
        car.Move(100);
        Console.WriteLine(car);
    }
}