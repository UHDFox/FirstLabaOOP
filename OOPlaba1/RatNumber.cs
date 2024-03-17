public sealed class RatNumber : IEquatable<RatNumber>
{
    public int Numerator { get; private set; }

    public int Denominator { get; private set; }
    
   public RatNumber(int a, int b)
   {
       if (b == 0) throw new ArgumentException("Denominator cannot be null");
       
        Numerator = a;
        Denominator = b;
    }

    private static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }
        
        return a;
    }
   

    public override string ToString()
    {
        int NOK = FindGCD(Numerator, Denominator);
        Numerator = Numerator / NOK;
        Denominator = Denominator / NOK;
        Console.WriteLine($"{Numerator}/{Denominator}");
        return $"{Numerator}/{Denominator}";
    }
    
    
    public static RatNumber operator +(RatNumber num1, RatNumber num2)
    {
        var newNum = num1.Numerator + num2.Numerator;
        var newDenom = num1.Denominator + num2.Denominator;

        return new RatNumber(newNum, newDenom);
    }
    
    public static RatNumber operator -(RatNumber num1, RatNumber num2)
    {
        var newNum = num1.Numerator - num2.Numerator;
        var newDenom = num1.Denominator - num2.Denominator;

        return new RatNumber(newNum, newDenom);
    }
    
    public static RatNumber operator *(RatNumber num1, RatNumber num2)
    {
        var newNum = num1.Numerator * num2.Numerator;
        var newDenom = num1.Denominator * num2.Denominator;

        return new RatNumber(newNum, newDenom);
    }
    
    public static RatNumber operator /(RatNumber num1, RatNumber num2)
    {
        if (num2.Numerator == 0) 
            throw new ArgumentException("cannot divide by 0");
            
        var newNum = num1.Numerator / num2.Numerator;
        var newDenom = num1.Denominator / num2.Denominator;

        return new RatNumber(newNum, newDenom);
    }
    
    public static bool operator ==(RatNumber num1, RatNumber num2)
    {
        return num1.Equals(num2);

    }

    public static bool operator !=(RatNumber num1, RatNumber num2)
    {
          return !num1.Equals(num2);
    }

    public static bool operator >(RatNumber num1, RatNumber num2)
    {
        return num1.Numerator > num2.Numerator && num1.Denominator > num2.Denominator;
    }

    public static bool operator <(RatNumber num1, RatNumber num2)
    {
        return num1.Numerator < num2.Numerator && num1.Denominator < num2.Denominator;
    }

    public static bool operator <=(RatNumber num1, RatNumber num2)
    {
        return num1.Numerator <= num2.Numerator && num1.Denominator <= num2.Denominator;
    }

    public static bool operator >=(RatNumber num1, RatNumber num2)
    {
        return num1.Numerator >= num2.Numerator && num1.Denominator >= num2.Denominator;
    }

    public static RatNumber operator -(RatNumber num1)
    {
        return new RatNumber(-num1.Numerator, -num1.Denominator);
    }

    public bool Equals(RatNumber? other) //to make tests more comfortable
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Numerator == other.Numerator && Denominator == other.Denominator;
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is RatNumber other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Numerator, Denominator);
    }
}

