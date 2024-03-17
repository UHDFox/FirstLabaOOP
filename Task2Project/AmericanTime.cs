using System;
using System.Globalization;

namespace Task2Project;

public sealed class AmericanTime : IRegionalDateTime
{
    public AmericanTime()
    {
    }
    
    public string ShowTime() => DateTime.Now.ToString("en-GB");
}