﻿namespace Task4;

public class BirdCount
{
    
     int[] _birdsPerDay ;

    public BirdCount(int[] birds)
    {
        _birdsPerDay = birds;
    }
public void IncrementTodaysCount()
    {
        _birdsPerDay[_birdsPerDay.Length - 1]++; 
    }
       public int Today()
    {
        return _birdsPerDay[_birdsPerDay.Length - 1]; 
    }
}
