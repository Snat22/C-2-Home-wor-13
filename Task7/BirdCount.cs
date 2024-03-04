namespace Task7;

public class BirdCount
{
     int[] _birdsPerDay ;

    public BirdCount(int[] birds)
    {
        _birdsPerDay = birds;
    }


    public int BusyDays()
    {
        return _birdsPerDay.Count(count => count >= 5); 
    }
}
