using System.Globalization;

namespace Task2Project;

public sealed class AmericanTime : IRegionalDateTime
{
    public DateTime Time;

    public AmericanTime(DateTime? time = null)
    {
        Time = time ?? DateTime.Now;
    }
    
    public string ShowTime()
    {
        Console.WriteLine(DateTime.Now.ToString(CultureInfo.GetCultureInfo("en-US")));
        return DateTime.Now.ToString("en-US");
    }
}