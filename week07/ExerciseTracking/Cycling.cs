using System;
using System.Collections.Generic;

//make it all in miles
class Cycling : Activity
{
    public double Speed { get; set; }  // Speed in miles per hour

    public override double GetDistance()
    {
        return (Speed * DurationMinutes) / 60;  // Distance in miles
    }

    public override double GetSpeed()
    {
        return Speed;  // Already in miles per hour
    }

    public override double GetPace()
    {
        return 60 / Speed;  // Pace in minutes per mile
    }
}