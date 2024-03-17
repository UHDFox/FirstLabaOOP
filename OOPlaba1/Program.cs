using Task2Project;
using Task2Project.Decorators;


namespace OOPlaba1;


public class Program
{
    static void Main(string[] args)
    {
        var ratNum = new RatNumber(-1, 3);
        var ratNum2 = new RatNumber(-2, -5);

        ratNum.ToString();
        ratNum2.ToString();
        var res = ratNum + ratNum2;
        Console.WriteLine($"{res.Numerator}, {res.Denominator}");


        IRegionalDateTime time = new AmericanTime();
        time.ShowTime();
        time = new ALetterDecorator(time);
        time.ShowTime();
        
        time = new BLetterDecorator(time);
        time.ShowTime();

        time = new EuropeanTime();
        
        time = new BLetterDecorator(time);
        time.ShowTime();


        RatNumber rn = new RatNumber(0, 1);
        Console.WriteLine($"{-rn.Numerator }, {-rn.Denominator}");
    }
}
