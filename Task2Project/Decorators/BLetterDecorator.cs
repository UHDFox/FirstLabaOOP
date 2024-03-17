using System;
using System.Text;

namespace Task2Project.Decorators;

public sealed class BLetterDecorator : Decorator
{
    public BLetterDecorator(IRegionalDateTime timeWrapper) : base(timeWrapper)
    {
    }

    public override string ShowTime()
    {
        var res = new StringBuilder(TimeWrapper.ShowTime()).Append(" BBBB").ToString();
        Console.WriteLine(res);
        return res;
    }
}