//class Train : Transport
//{
//    public bool HightSpeedTrain { get; private set; }
//    public Train(int maxSpeed, int numberOfPlace, int valueOfTank, int fuelCons) : base(maxSpeed, numberOfPlace, valueOfTank)
//    {
//        EnergySourse = new Tank(valueOfTank, fuelCons);
//        NumberOfPlace = numberOfPlace;
//        Console.WriteLine($"Данный поезд имеет максимальное колличество посадочных мест: {NumberOfPlace} человека");
//    }
//    public void SignalSound()
//    {
//        Console.WriteLine("Ту туууууууууууу");
//    }
//    public override void Move(int speed, int distance)
//    {
//        if (distance <= 0 || EnergySourse.CurrentValueOfField <= 0)
//        {
//            Console.WriteLine($"{typeof(Train)} стоит на месте");
//            return;
//        }
//        int maxCons = EnergySourse.EnergyCons * distance / 100;
//        if (EnergySourse.CurrentValueOfField >= maxCons)
//        {
//            EnergySourse.DecreaseFuel(maxCons);
//            Console.WriteLine($"{typeof(Train)} проехал {distance} км со средней скоростью {speed} км/ч.");
//        }
//        else
//        {
//            EnergySourse.ZeroFuel(); // все топливо израсходовано
//            Console.WriteLine($"{typeof(Train)} проехал {EnergySourse.MaxDistance(distance)} км со средней скоростью {speed} км/ч и остановился на дозаправку.Осталось проехать {distance - EnergySourse.MaxDistance(distance)} км.");
//        }
//    }
//    public override string ToString()
//    {
//        return $"Тип транспорта - {typeof(Train)}, максимальная скорость - {MaxSpeed}, количество пассажирных мест - {NumberOfPlace}";
//    }
//}

////class airplane : transport
////{
////    private airsize _size;
////    public airplane(int numberofplase, airsize airsize)
////    {
////        numberofplace = numberofplase;
////        _size = airsize;
////        console.writeline($"колличество посадочных мест: {numberofplace} человек");
////        getsize();
////    }

////    public void getsize()
////    {
////        switch (_size)
////        {
////            case airsize.big:
////                console.writeline("ваш самолет весит около 400 тонн");
////                break;
////            case airsize.medium:
////                console.writeline("ваш самолет весит около 35 тонн");
////                break;
////            case airsize.small:
////                console.writeline("ваш самолет весит около 5 тонн");
////                break;
////        }
////    }

////    public override void move(int speed)
////    {
////        console.writeline($"самолет взлетает и летит со скоростью {speed} км/ч");
////    }
////}

////public enum airsize
////{
////    big,
////    small,
////    medium
////}