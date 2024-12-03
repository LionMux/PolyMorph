class Car : Transport
{

    public int NumberOfDoors { get; }
    private int _distance;

    public int Distance { get { return _distance; } set { _distance = value; } }

    protected override EnergySourse EnergySourse { get; }

    public Car(int numberOfDoors, int valueOfTank, int power, int energyCons, int numberOfPlace ) : base(numberOfPlace)
    {
        NumberOfDoors = numberOfDoors;
        
        EnergySourse = new Battery(valueOfTank);

        Engine = new ElectricEngine(power, energyCons);

        AirConditioner = new AirConditioner();
    }

    public override void Move(int Distance)
    {
        Engine.CalculateValueOfConsField(Distance);

        AirConditioner airConditioner = new AirConditioner();

        if (Distance <= 0 || EnergySourse.CurrentValueOfField <= 0)
        {
            EnergySourse.DecreaseFuel(Engine.ValueOfConsField);
            Console.WriteLine($"{typeof(Car)} стоит на месте");
        }

        if (EnergySourse.CurrentValueOfField >= Engine.ValueOfConsField && Engine is ElectricEngine electricEngine && EnergySourse is Battery battery)
        {
            EnergySourse.DecreaseFuel(Engine.ValueOfConsField);

            Console.WriteLine($"{typeof(Car)} проехал {Distance - electricEngine.ColculateDistance(EnergySourse.CurrentValueOfField, Distance)} км со средней скоростью {Engine.Speed} км/ч.");

            electricEngine.DropPower(EnergySourse.CurrentValueOfField, EnergySourse.MaxValue);

            battery.CheckAmountOfEnergy();

            battery.EmergencyStopForBatterySave = airConditioner.CheckAirConditioner(EnergySourse.CurrentValueOfField);

            airConditioner.CheckForBatterySave(battery.EmergencyStopForBatterySave);
        }
        else if (EnergySourse is Battery bat)
        {
            EnergySourse.DecreaseFuel(Engine.ValueOfConsField);

            Distance = (int) Engine.MaxDistance(Distance, EnergySourse.CurrentValueOfField);

            EnergySourse.SetZeroFuel(); // все топливо израсходовано

            Console.WriteLine($"{typeof(Car)} проехал {Distance} км со средней скоростью {Engine.Speed} км/ч и остановился, так как потратил все топливо.");

            bat.EmergencyStopForBatterySave = airConditioner.CheckAirConditioner(EnergySourse.CurrentValueOfField);

            AirConditioner.CheckForBatterySave(bat.EmergencyStopForBatterySave);
        }
    }

    public override string ToString()
    {
        return $"Тип транспорта - {typeof(Car)}, максимальная скорость - {Engine.MaxSpeed}, количество дверей - {NumberOfDoors}, Емкость батареи - {EnergySourse.MaxValue} кВт*ч";
    }
}