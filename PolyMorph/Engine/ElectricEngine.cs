public class ElectricEngine : EngineBase
{
    public ElectricEngine(int power, int energyCons) : base(power, energyCons) { }
    public void DropPower(int currentValueOfField, int maxValue) // метод который понижает мощность электродвигателя на 30% из-за низкого заряда батареи ( меньше 20% )
    {
        if (currentValueOfField * 100 / maxValue < 20)
        {
            Power *= 0.7d;
            Speed *= 0.7d;
        }
    }
    //public double CalculateDistance(int currentValueOfField, int distance)
    //{
    //    var ValueOfField20 = (currentValueOfField - CalculateValueOfConsField(distance)) / 100;
    //    if (ValueOfField20 < 20)
    //    {
    //        return distance * 0.3;
    //    }
    //    else return 0;
    //}

}