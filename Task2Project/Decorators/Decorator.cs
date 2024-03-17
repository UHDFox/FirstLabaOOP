namespace Task2Project.Decorators;

public abstract class Decorator : IRegionalDateTime
{
    protected IRegionalDateTime TimeWrapper;


    public Decorator(IRegionalDateTime timeWrapper)
    {
        TimeWrapper = timeWrapper;
    }

    public abstract string ShowTime();
}