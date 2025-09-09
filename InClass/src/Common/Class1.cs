using System.Numerics;

namespace Common;

public class Class1
{
    public static T Add<T>(T a, T b)
        where T : INumber<T>
    {
        return a + b;
    }

    public bool PatternMatch(float measurement) =>
        measurement switch
        {
            > 3.0f => true,
            < 3.0f => false,
            _ => false
        };


    public void Foo()
    {
        var x = 10;
        int y = x;
    }
}
