using System.Numerics;
using testNewCalculator;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        TestNewCalculator2 test = new();
        var tmp = true;
        while (tmp)
        {
            test.WorkString();
        }
    }
}