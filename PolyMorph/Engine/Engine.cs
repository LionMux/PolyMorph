 public abstract class Engine
{

    public double Power { get; set; } // мощность двигателя в кВт
    public int EnergyCons { get; set; } // расход энергии на 100 км
    public int ValueOfConsField { get; set; }
    public int MaxSpeed { get;}
    public int Speed
    {
        get
        {
            return _speed;
        }
        set
        {
            if (value > MaxSpeed)
            {
                Console.WriteLine("Введенное значение скорости привышает возможности автомобиля, поэтому он не смог поехать");
            }
            else _speed = value;
        }
    }
    private int _speed;
    public Engine(int power, int energyCons)
    {
        Power = power;
        EnergyCons = energyCons;
        MaxSpeed =(int) Math.Cbrt(2.27 * power * 1000);
        Speed = MaxSpeed / 2;
    }
    public void CalculateValueOfConsField(int distance)
    {
        ValueOfConsField = distance * EnergyCons / 100;
    }
    public double MaxDistance(int distance, int currentValueOfField) // метод, который расчитывает дистанцию, которую может проехать двигатель с текущим колличеством топлива
    {
        ValueOfConsField = distance * EnergyCons / 100; // затрата энергии на перемещение длинной distance
        if (currentValueOfField >= ValueOfConsField)
        {
            return distance;
        }
        else
        {
            return currentValueOfField * 100 / ValueOfConsField;
        }
    }
    public double Horsepower()
    {
        const double conversionFactor = 1.341; // коэффициент пересчета кВт в л.с.
        return Power * conversionFactor;
    }

}