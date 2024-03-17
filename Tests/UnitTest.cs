namespace Tests;

public sealed class UnitTest
{
    [Theory]
    [InlineData(1, 3, 2, 5, false)]
    [InlineData(1, 1, 1, 1, true)]
    [InlineData(2, 4, 4, 2, false)]
    public void EqualsOperator_ValidNumbers_ResultShouldBeCorrect(int n1, int n2, int n3, int n4, bool expected)
    {
        var ratNum = new RatNumber(n1, n2);
        var ratNum2 = new RatNumber(n3, n4);
        
        Assert.Equivalent(ratNum.Equals(ratNum2), expected);
    }
    
    [Theory]
    [InlineData(1, 3, 2, 5, true)]
    [InlineData(2, 4, 4, 6, true)]
    [InlineData(1, 1, 1, 1, false)]
    public void NotEqualOperator_ValidNumbers_ResultShouldBeCorrect(int n1,int n2,int n3,int n4,bool expected)
    {
        var ratNum = new RatNumber(n1, n2);
        var ratNum2 = new RatNumber(n3, n4);
        
        Assert.Equivalent(!ratNum.Equals(ratNum2), expected);
    }
    
    [Theory]
    [InlineData(1,3, 2, 5, 3, 8)]
    [InlineData(1,1, 1, 1, 2, 2)]
    [InlineData(1,2, 2, 1, 3, 3)]
    public void Addition_ValidNumbers_ResultShouldBeCorrect(int n1, int n2, int n3, int n4, int n5, int n6)
    {
        var ratNum = new RatNumber(n1, n2);
        var ratNum2 = new RatNumber(n3, n4);
        var test = new RatNumber(n5, n6);
        
        Assert.Equivalent(ratNum + ratNum2, test);
    }
    
    [Theory]
    [InlineData(5,5, 1, 1, 4, 4)]
    [InlineData(5,5, 6, 6, -1, -1)]
    [InlineData(5, 3, 5, 8, 0, -5)]
    [InlineData(1, 2, -3, -4, 4, 6)]
    public void Subtraction_ValidNumbers_ResultShouldBeCorrect(int n1, int n2, int n3, int n4, int n5, int n6)
    {
        var ratNum = new RatNumber(n1, n2);
        var ratNum2 = new RatNumber(n3, n4);
        var test = new RatNumber(n5, n6);
        
        Assert.Equivalent(ratNum - ratNum2, test);
    }
    
    [Theory]
    [InlineData(1, 1, -1, -1, true)]
    [InlineData(5, 3, -5, -3, true)]
    [InlineData(1, 1, 1, -1, false)]
    [InlineData(1, 1, -1, 1, false)]
    [InlineData(0, 1, 0, -1, true)]
    public void Negation_ValidNumbers_ResultShouldBeCorrect(int n1, int n2, int n3, int n4, bool expected)
    {
        var ratNum = new RatNumber(n1, n2);
        Assert.Equivalent((-ratNum).Equals(new RatNumber(n3, n4)), expected);
    }
    
    [Theory]
    [InlineData(4, 6, 2, 3, 2, 2, true)]
    [InlineData(9, 6, 3, 6, 3, 1, true)]
    [InlineData(1, 1, 1, 1, 1, 1, true)]
    public void Division_ValidNumbers_ResultShouldBeCorrect(int n1, int n2, int n3, int n4, int n5, int n6, bool expected)
    {
        var ratNum = new RatNumber(n1, n2);
        var ratNum2 = new RatNumber(n3, n4);
        
        Assert.Equivalent((ratNum / ratNum2).Equals(new RatNumber(n5, n6)), expected);
    }

    [Theory]
    [InlineData(2, 2, 0, 1)]
    [InlineData(1, 1, 0, 5)]
    public void Division_SecondNumberIsZero_ThrowsArgumentException(int n1, int n2, int n3, int n4)
    {
        var ratNum1 = new RatNumber(n1, n2);
        var ratNum2 = new RatNumber(n3, n4);
        
        Assert.Throws<ArgumentException>(() => ratNum1 / ratNum2);
    }

    [Theory]
    [InlineData(4, 6, 2, 3, true)]
    [InlineData(1, 1, 1, 1, true)]
    [InlineData(1, 2, 2, 3, false)]
    [InlineData(1, 2, 3, 2, false)]
    public void EqualOrBigger_ValidNumbers_ResultShouldBeCorrect(int n1, int n2, int n3, int n4, bool expected)
    {
        var ratNum = new RatNumber(n1, n2);
        var ratNum2 = new RatNumber(n3, n4);
        
        Assert.Equivalent(ratNum >= ratNum2, expected);
    }
    
    [Theory]
    [InlineData(4, 6, 2, 3, false)]
    [InlineData(1, 1, 1, 1, true)]
    [InlineData(1, 2, 2, 3, true)]
    [InlineData(1, 2, 3, 2, true)]
    public void EqualOrLower_ValidNumbers_ResultShouldBeCorrect(int n1, int n2, int n3, int n4, bool expected)
    {
        var ratNum = new RatNumber(n1, n2);
        var ratNum2 = new RatNumber(n3, n4);
        
        Assert.Equivalent(ratNum <= ratNum2, expected);
    }


    [Theory]
    [InlineData(1, 0)]
    [InlineData(2, 0)]
    public void ClassConstructor_DenominatorIsZero_ThrowsArgumentException(int n1, int n2)
    {
        Assert.Throws<ArgumentException>(() => new RatNumber(n1, n2));
    }
}