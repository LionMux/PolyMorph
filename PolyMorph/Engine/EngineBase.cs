public abstract class EngineBase
{
    private const double conversionFactor = 1.341; // коэффициент пересчета кВт в л.с.

    private double _speed;
    private double power;

    public double Power
    {
        get => power;
        protected set
        {
            if (value >= 0)
            {
                power = value;
            }
        }
    } // мощность двигателя в кВт
    public int EnergyCons { get; } // расход энергии на 100 км
    public int MaxSpeed { get; }
    public double Speed
    {
        get => _speed;
        protected set
        {
            if (value > MaxSpeed || value < 0)
            {
                Console.WriteLine("Введенное значение скорости привышает возможности автомобиля, поэтому он не смог поехать");
                _speed = 0;
            }
            else
            {
                _speed = value;
            }
        }
    }

    public double Horsepower { get; }

    public EngineBase(int power, int energyCons)
    {
        Power = power;
        EnergyCons = energyCons;
        MaxSpeed = (int)Math.Cbrt(96 * power * 1000);
        Speed = MaxSpeed / 2;
        Horsepower = Power * conversionFactor;
    }

    public int CalculateValueOfConsField(int distance)
    {
        return distance * EnergyCons / 100;
    }

    public double GetMaxDistance(int distance, int currentValueOfField) // метод, который расчитывает дистанцию, которую может проехать двигатель с текущим колличеством топлива
    {
        var valueOfConsField = distance * EnergyCons / 100; // затрата энергии на перемещение длинной distance
        if (currentValueOfField >= valueOfConsField)
        {
            return distance;
        }
        else
        {
            return currentValueOfField * 100 / valueOfConsField;
        }
    }
}