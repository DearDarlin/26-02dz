using System;

public record DailyTemperature(int Min, int Max);

public class Program
{
    public static void Main()
    {
        DailyTemperature[] week = new DailyTemperature[]
        {
            new DailyTemperature(12, 25),
            new DailyTemperature(10, 23),
            new DailyTemperature(15, 26),
            new DailyTemperature(17, 25),
            new DailyTemperature(20, 31),
            new DailyTemperature(19, 32),
            new DailyTemperature(18, 33)
        };

        int maxTemp = int.MinValue;
        int dayIndex = -1;
        for (int i = 0; i < week.Length; i++)
        {
            int diff = week[i].Max - week[i].Min;
            if (diff > maxTemp)
            {
                maxTemp = diff;
                dayIndex = i;
            }
        }
        Console.WriteLine($"Day with the largest temperature difference: Day {dayIndex + 1} with a difference of {maxTemp}°C");

    }
}