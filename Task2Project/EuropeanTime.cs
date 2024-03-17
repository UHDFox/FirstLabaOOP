using System;
using System.Globalization;

namespace Task2Project;

public sealed class EuropeanTime : IRegionalDateTime
{
    public EuropeanTime(DateTime time)
    {
    }
    
    public string ShowTime()
    {
        Console.WriteLine(DateTime.Now.ToString(CultureInfo.GetCultureInfo("en-GB")));
        return DateTime.Now.ToString("en-GB");
    }
}