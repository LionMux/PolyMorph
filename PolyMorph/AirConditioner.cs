public class AirConditioner
{
    private bool _statusOfConditioner = false;

    public void TurnOnAirConditioner()
    {
            _statusOfConditioner = true;        
    }

    public void TurnOffAirConditioner()
    {
        _statusOfConditioner = false;
        Console.WriteLine("Кондиционер выключен");
    }

    public bool CheckAirConditioner(int currentValueOfFieldP)
    {
        if (currentValueOfFieldP < 20)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void CheckForBatterySave(bool emergencyStopOfConditioner)
    {
        if (emergencyStopOfConditioner == true && _statusOfConditioner == true)
        {
            Console.WriteLine("Так как заряд батареи ниже 20%, то был отключен кондиционер");
        }
        else if (emergencyStopOfConditioner == false && _statusOfConditioner == true)
        {
            Console.WriteLine("Включен кондиционер");
        }
    }
}