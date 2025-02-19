using System;
using System.Collections.Generic;

abstract class Activity
{
    public DateTime Date { get; set; }
    public int DurationMinutes { get; set; }

    // Abstract methods to be implemented in derived classes!!
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Common method to get the summary
    public string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({DurationMinutes} min): Distance {GetDistance():0.0}, Speed: {GetSpeed():0.0}, Pace: {GetPace():0.0} min per {(GetType().Name == "Running" ? "mile" : "km")}";
    }
}
