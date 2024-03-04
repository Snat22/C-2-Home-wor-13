namespace Task6;

public class BirdCount
{

     int[] _birdsPerDay ;

    public BirdCount(int[] birds)
    {
        _birdsPerDay = birds;
    }

    
    public int CountForFirstDays(int days)
    {
        return _birdsPerDay.Take(days).Sum();
    }
}
