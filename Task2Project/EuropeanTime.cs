using System.Globalization;

namespace Task2Project;

public sealed class EuropeanTime : IRegionalDateTime
{
    public DateTime Time;

    public EuropeanTime(DateTime? time = null)
    {
        Time = time ?? DateTime.Now;
    }
    
    public string ShowTime()
    {
        Console.WriteLine(DateTime.Now.ToString(CultureInfo.GetCultureInfo("en-GB")));
        return DateTime.Now.ToString("en-GB");
    }
}