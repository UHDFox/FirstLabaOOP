using System;
using System.Globalization;

namespace Task2Project;

public sealed class AmericanTime : IRegionalDateTime
{
    public AmericanTime(DateTime time)
    {
    }
    
    public string ShowTime()
    {
        Console.WriteLine(DateTime.Now.ToString(CultureInfo.GetCultureInfo("en-US")));
        return DateTime.Now.ToString("en-US");
    }
}