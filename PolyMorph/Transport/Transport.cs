﻿internal abstract class Transport
{
    protected abstract EnergySourse EnergySourse { get; }
    protected Engine Engine { get;  set; }
    protected AirConditioner AirConditioner { get;  set; }
    
    public int NumberOfPlace { get;}

    protected Transport(int numberOfPlace)
    {
        NumberOfPlace = numberOfPlace;
    }

    public abstract void Move(int distance);
    //TODO: Предоставить внешний интерфейс
    public void Refuel(int valOfFuel)
    {
        try
        {
            EnergySourse.SetFuelValue(valOfFuel);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}