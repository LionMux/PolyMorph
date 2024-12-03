public class AirConditioner
{
    private bool _statusOfConditioner = false;

    public void TurnOnAirConditioner()
    {
        _statusOfConditioner = true;
        Console.WriteLine("Кондиционер включен");
    }

    public void TurnOffAirConditioner()
    {
        _statusOfConditioner = false;
        Console.WriteLine("Кондиционер выключен");
    }


    public void CheckForBatterySave(bool emergencyStopOfConditioner)
    {
        if (emergencyStopOfConditioner == true && _statusOfConditioner == true)
        {
            Console.WriteLine("Так как заряд батареи ниже 20%, то был отключен кондиционер");
            TurnOffAirConditioner();
        }
        else if (emergencyStopOfConditioner == false && _statusOfConditioner == true)
        {
            Console.WriteLine("Включен кондиционер");
            TurnOnAirConditioner();
        }
    }
}