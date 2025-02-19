using System;
using System.Collections.Generic;

//make it all in miles
class Running : Activity
{
    public double Distance { get; set; }  // Distance in miles

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / DurationMinutes) * 60;  // Speed in miles per hour
    }

    public override double GetPace()
    {
        return (DurationMinutes / Distance);  // Pace in minutes per mile
    }
}