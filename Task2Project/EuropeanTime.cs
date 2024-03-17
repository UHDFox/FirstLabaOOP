using System;
using System.Globalization;

namespace Task2Project;

public sealed class EuropeanTime : IRegionalDateTime
{
    public EuropeanTime()
    {
    }
    
    public string ShowTime() => DateTime.Now.ToString("en-GB");
}