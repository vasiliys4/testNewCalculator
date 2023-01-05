using System;
using System.Collections.Generic;

namespace testNewCalculator
{
    internal class TestNewCalculator2
    {
        List<double> ListNumber = new List<double>();
        List<string> ListString = new List<string>();
        List<char> ListChar = new List<char>();
        string[]? ArrayNumbers;
        string? Number;
        public string[] Read2()
        {
            ListString.Clear();
            Console.WriteLine("Введите второе число");
            Number = Console.ReadLine();

            ArrayNumbers = Number.Split('+', '-');
            foreach (string number in ArrayNumbers)
            {
                ListString.Add(number);
            }
            foreach (char item in Number)
            {
                if (item == '+')
                {
                    ListChar.Add(item);
                }
                else if (item == '-')
                {
                    ListChar.Add(item);
                }
            }
            return ArrayNumbers;
        }

        public string Validator()
        {
            int j = 0;
            int LengthArray = 1;
            double result = -1;
            ListString.Add("");
            for (int i = 0; i < LengthArray; i++) 
            {
                if (Number[0] != '-')
                {
                    while (LengthArray >= i)
                    {
                        if (double.TryParse(ListString[j], out result))
                        {
                            Console.WriteLine(ListString[i]);
                            ListNumber.Add(result);
                            j++;
                            break;
                        }
                        else
                        {
                            Read2();
                            ListString.Remove("");
                            LengthArray = ArrayNumbers.Length;
                            j = 0;
                            i = 0;
                        }
                    }
                }
                else if (Nmber)
                {

                }
            }
            return Number;
        }

        public void WorkString()
        {
            double otvet = 0;
            for (int i = 0; i < ListChar.Count; i++)
            {
                if (ListChar.Count >= ListString.Count && Number[0] == '-' )
                {
                    otvet = otvet - ListNumber[0];
                }
                else if (ListChar[i] == '+')
                {
                    otvet = ListNumber[i] + ListNumber[i + 1];
                }
                else if (ListChar[i] == '-')
                {
                    otvet = ListNumber[i] - ListNumber[i + 1];
                }
            }
        }
    }
}
