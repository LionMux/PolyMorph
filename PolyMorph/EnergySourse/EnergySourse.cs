public abstract class EnergySourse
{
    public int MaxValue { get; } // максимальный объем хранилища энергии
    public int CurrentValueOfField
    {
        get
        {
            return _currentValueOfField;
        }
        protected set
        {
            _currentValueOfField = value;
            CurrentValueOfFieldP = _currentValueOfField * 100 / MaxValue;
        }

    }

    public int CurrentValueOfFieldP { get; protected set; } // текущее колличество энергии в %
    
    private int _currentValueOfField;

    public EnergySourse(int maxValue)
    {
        MaxValue = maxValue;
    }

    public void SetFuelValue(int valueOfField)
    {
        if (CurrentValueOfField + valueOfField > MaxValue)
        {
            CurrentValueOfField = MaxValue;
            OnOverloaded(valueOfField);
        }
        else
        {
            CurrentValueOfField += valueOfField;
            OnCharging(CurrentValueOfField);
        }
    }

    protected virtual void OnOverloaded(int valueOfField) 
    { 
    }

    protected virtual void OnCharging(int valueOfField) 
    { 
    }
  

    public void DecreaseFuel(int valueD)
    {
        if (CurrentValueOfField > valueD)
        {
            CurrentValueOfField -= valueD;
        }
        else
        {
            CurrentValueOfField = 0;
        }       
    }

    public void SetZeroFuel()
    {
        CurrentValueOfField = 0;
    }
    public virtual void CheckAmountOfEnergy()
    {
    }
}