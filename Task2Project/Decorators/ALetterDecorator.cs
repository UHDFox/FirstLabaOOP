using System;
using System.Text;

namespace Task2Project.Decorators;

public sealed class ALetterDecorator : Decorator
{
    public ALetterDecorator(IRegionalDateTime timeWrapper) : base(timeWrapper)
    {
    }

    public override string ShowTime()
    {
        var res = new StringBuilder(TimeWrapper.ShowTime()).Insert(0, "AAA ").ToString();
        return res;
    }
}