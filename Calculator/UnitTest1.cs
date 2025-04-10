using System;
namespace Calculator;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        if(sum(2,2)!=4)
            throw new Exception();
    }
    int sum(int num1 , int num2)
    {
        return num1+num2;
    }
}
