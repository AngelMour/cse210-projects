using System;
using System.Collections.Generic;

//This is in kilometers
class Swimming : Activity
{
    public int Laps { get; set; }  // Laps swum

    public override double GetDistance()
    {
        return (Laps * 50.0) / 1000;  // Distance in kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationMinutes) * 60;  // Speed in kilometers per hour
    }

    public override double GetPace()
    {
        return DurationMinutes / GetDistance();  // Pace in minutes per kilometer
    }
}