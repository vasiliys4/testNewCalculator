using System;
using System.Collections.Generic;

namespace testNewCalculator
{
    internal class TestNewCalculator2
    {
        List<double> NumbersFromTheExample = new List<double>();
        List<string> ListString = new List<string>();
        List<char> MathematicalSymbols = new List<char>();
        string[]? TemporaryContainer { get; set; }
        string? ReadIsConsole { get; set; }

        string[] Read()
        {
            MathematicalSymbols.Clear();
            ListString.Clear();
            NumbersFromTheExample.Clear();
            Console.WriteLine("Введите пример:");
            ReadIsConsole = Console.ReadLine();

            TemporaryContainer = ReadIsConsole.Split('+', '-','*','/','^');
            foreach (string number in TemporaryContainer)
            {
                ListString.Add(number);
            }
            foreach (char item in ReadIsConsole)
            {
                if (item == '+')
                {
                    MathematicalSymbols.Add(item);
                }
                else if (item == '-')
                {
                    MathematicalSymbols.Add(item);
                }
                else if (item == '*')
                {
                    MathematicalSymbols.Add(item);
                }
                else if (item == '/')
                {
                    MathematicalSymbols.Add(item);
                }
                else if (item == '^')
                {
                    MathematicalSymbols.Add(item);
                }
            }
            return TemporaryContainer;
        }

        void Validator()
        {
            int j = 0;
            int LengthArray = 1;
            ListString.Add("");
            for (int i = 0; i < LengthArray; i++) 
            {
                while (LengthArray >= i)
                {
                    if (double.TryParse(ListString[j], out var result))
                    {
                        NumbersFromTheExample.Add(result);
                        j++;
                        break;
                    }
                    else
                    {
                        Read();
                        ListString.Remove("");
                        LengthArray = TemporaryContainer.Length;
                        j = 0;
                        i = 0;
                    }
                }
            }
        }

        public void WorkString()
        {
            Validator();           
            double result = 1;
            for (int i = 0; i < MathematicalSymbols.Count; i++)
            {
                if (MathematicalSymbols[i] == '^') 
                { 
                    for (int j = 0; j < NumbersFromTheExample[i + 1]; j++)
                    { 
                        result = result * NumbersFromTheExample[i];                        
                    }
                    NumbersFromTheExample[i] = result;
                    NumbersFromTheExample.RemoveAt(i + 1);
                    MathematicalSymbols.RemoveAt(i);
                    i -= 1;
                }                
            }
            result = NumbersFromTheExample[0];
            for (int i = 0; i < MathematicalSymbols.Count; i++)
            {
                if (MathematicalSymbols[i] == '*')
                {
                    result = NumbersFromTheExample[i] * NumbersFromTheExample[i + 1];
                    NumbersFromTheExample[i] = result;
                    NumbersFromTheExample.RemoveAt(i + 1);
                    MathematicalSymbols.RemoveAt(i);
                    i -= 1;

                }
                else if(MathematicalSymbols[i] == '/')
                {
                    result = NumbersFromTheExample[i] / NumbersFromTheExample[i + 1];
                    NumbersFromTheExample[i] = result;
                    NumbersFromTheExample.RemoveAt(i + 1);
                    MathematicalSymbols.RemoveAt(i);
                    i -= 1;
                }
            }
            result = NumbersFromTheExample[0];
            for (int i = 0; i < MathematicalSymbols.Count; i++)
            {                
                if (MathematicalSymbols[i] == '+')
                {
                    result = result + NumbersFromTheExample[i + 1];
                }
                else if (MathematicalSymbols[i] == '-')
                {
                    result = result - NumbersFromTheExample[i + 1];
                }
            }
            Console.Clear();
            Console.WriteLine($"{ReadIsConsole} = {result}");
            ListString.Clear();
        }
    }
}
