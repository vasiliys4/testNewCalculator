using System.Numerics;
using testNewCalculator;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        TestNewCalculator2 test = new();
        test.Validator();
//        //string[] Number1 = new string[2];
//        //string[] Read1()
//        //{
//        //    string Number;
            
//        //    for (int i = 0; i < 2; i++)
//        //    {
//        //        Console.WriteLine("Введите первое число: ");
//        //        Number = Console.ReadLine();
//        //        Number1[i] = Number;
//        //    }
//        //    //for (int i = 0; i < Number1.Length; i++)
//        //    //{
//        //    //    Console.WriteLine(Number1[i]);
//        //    //}
//        //    //Console.ReadKey();
//        //    return Number1;
//        //}

//        //double[] Validation1()
//        //{
//        //    Read1();
//        //    double result1 = -1;
//        //    double[] KricDushi = new double[2];
//        //    for (int i = 0; i < Number1.Length; i++)
//        //    {
//        //        //string[] KricDushi = new string[2];                
//        //        string number1 = "";
//        //        var tmp = true;
//        //        while (tmp)
//        //        {
//        //            if (double.TryParse(number1, out result1))
//        //            {
//        //                KricDushi[i] = result1;
//        //                tmp = false;
//        //            }
//        //            else if ()
//        //            {

//        //            }
//        //            else
//        //            {
//        //                number1 = Number1[i];
//        //            }                   
//        //        }
//        //    }

//        //    for (int i = 0; i < KricDushi.Length; i++)
//        //    {
//        //        Console.WriteLine(KricDushi[i]);
//        //    }
//        //    Console.ReadLine();
//        //    return KricDushi;
//        //}
//        //Validation1();


// double[] Validation2()
//{
//            double[] govno = new double[2];
//            double result2 = -1;
//            for (int i = 0; i < 2; i++)
//            {

//                var number2 = "";
//                var tmp = true;
//                while (tmp)
//                {
//                    if (double.TryParse(number2, out result2))
//                    {
//                        govno[i] = result2;
//                        tmp= false;
//                    }
//                    else
//                    {
//                        number2 = Read2();
//                    }
//                }
//            }
//            //for (int i = 0; i < govno.Length; i++)
//            //{
//            //    Console.WriteLine(govno[i]);
//            //}
//            return govno;
//        }

//string Read2()
//{
//    Console.WriteLine("Введите второе число");
//    var Number2 = Console.ReadLine();
//    return Number2;
//}   
//        //void Plus(double[] govno)
//        //{
//        //    for (int i = 0; i < govno.Length - 1; i++)
//        //    {
//        //        double Result = govno[i] + govno[i + 1];
//        //        Console.WriteLine($"Результат:\n{govno[0]} + {govno[1]} = {Result}");
//        //    }
//        //}
//        //var e = Validation2();
//        //Plus(e);

//        double Validator()
//        {
            
//            string[] array = Read2().Split('+', '-', '*', '/');
//            for (int i = 0; i < array.Length; i++)
//            {
//                var tmp = true;
//                double result2 = -1;
//                while (tmp)
//                {
//                    if (double.TryParse(array[i], out result2))
//                    {
                        
//                        tmp = false;
//                    }
//                    else
//                    {
//                        Console.WriteLine("\nВы ввели неверные данные");
//                        Validator();
//                    }
//                }
//            }

//        Validator();
    }
}