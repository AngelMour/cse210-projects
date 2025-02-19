using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Create activities
        var activities = new List<Activity>
        {
            new Running { Date = new DateTime(2025, 2, 17), DurationMinutes = 30, Distance = 3.0 },
            new Cycling { Date = new DateTime(2025, 2, 17), DurationMinutes = 30, Speed = 15.0 },
            new Swimming { Date = new DateTime(2025, 2, 17), DurationMinutes = 30, Laps = 20 }
        };

        // Print summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}