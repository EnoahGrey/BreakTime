namespace BreakTime.Custom;

public class TimerLogic
{
    private int _intSec;
    public int _intMin;

    public void SetBreakTime(int time)
    {
        if (time == 5) {
            _intMin = 3;
        }
        else if (time == 10) {
            _intMin = 10;
        }
        else {
            _intMin = 15;
        }
    }
    
    public void SetTickCount()
    {
        _intSec++;
        if (_intSec == 60)
        {
            _intMin--;
            _intSec = 0;
        }
    }
    
    public string MinLeftMessage()
    {
       return _intMin.ToString().PadLeft(2, ' ') + " Minutes Left";  
    }
}