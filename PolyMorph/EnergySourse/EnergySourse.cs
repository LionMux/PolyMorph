public abstract class EnergySourse
{
    private int _currentValueOfField;

    public int MaxValue { get; } // максимальный объем хранилища энергии
    public int CurrentValueOfField
    {
        get
        {
            return _currentValueOfField;
        }
        protected set
        {
            if (_currentValueOfField != value)
            {
                _currentValueOfField = value;
                CurrentValueOfFieldP = _currentValueOfField * 100 / MaxValue;
                OnCurrentValueOfFieldChanged();
            }
        }

    }

    public int CurrentValueOfFieldP { get; protected set; } // текущее колличество энергии в %

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
    public virtual void DecreaseFuel(int value)
    {
        if (CurrentValueOfField > value)
        {
            CurrentValueOfField -= value;
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

    protected virtual void OnOverloaded(int valueOfField)
    {
    }

    protected virtual void OnCharging(int valueOfField)
    {
    }

    protected virtual void OnCurrentValueOfFieldChanged()
    {
    }


    
}