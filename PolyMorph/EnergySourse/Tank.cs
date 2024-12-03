//public class Tank : EnergySourse
//{
//    public Tank(int maxValue) : base(maxValue) { } // fuelCons - колличество топлива в поезде, измеряется в литрах на 100 км

//    public override void OnOverloaded(int ValueOfField)
//    {
//        if (CurrentValueOfField + ValueOfField > MaxValue)
//        {
//            throw new ArgumentException($"Превышено максимальный объем бака!\nMaxValue = {MaxValue}");
//        }
//        CurrentValueOfField += ValueOfField;
//        Console.WriteLine($"Текущее колличество топлива в баке {CurrentValueOfField * 100.0 / MaxValue} %");
//    }

//}