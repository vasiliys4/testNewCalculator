using System;
using System.Collections.Generic;

namespace testNewCalculator
{
    internal class TestNewCalculator2
    {
        public List<double> NumbersFromTheExample = new List<double>();
        List<string> StringPotentialNumber = new List<string>();
        List<char> MathematicalSymbols = new List<char>();
        string[]? TemporaryContainer { get; set; }
        string? ReadIsConsole { get; set; }

        string[] Reading()
        {
            MathematicalSymbols.Clear();
            StringPotentialNumber.Clear();
            NumbersFromTheExample.Clear();
            Console.WriteLine("Введите пример:");
            ReadIsConsole = Console.ReadLine();

            TemporaryContainer = ReadIsConsole.Split('+','-','*','/','^','(',')');
            foreach (string number in TemporaryContainer)
            {
                if (number != "")
                {
                    StringPotentialNumber.Add(number);
                }
            }
            foreach (char item in ReadIsConsole)
            {
                switch (item)
                {
                    case '+':
                        MathematicalSymbols.Add(item);
                        break;
                    case '-':
                        MathematicalSymbols.Add(item);
                        break;
                    case '*':
                        MathematicalSymbols.Add(item);
                        break;
                    case '/':
                        MathematicalSymbols.Add(item);
                        break;
                    case '^':
                        MathematicalSymbols.Add(item);
                        break;
                    case '(':
                        MathematicalSymbols.Add(item);
                        break;
                    case ')':
                        MathematicalSymbols.Add(item);
                        break;
                }
            }
            return TemporaryContainer;
        }

        List<double> Validation()
        {
            int j = 0;
            int LengthArray = 1;
            StringPotentialNumber.Add("");
            for (int i = 0; i < LengthArray; i++) 
            {
                while (LengthArray >= i)
                {
                    if (double.TryParse(StringPotentialNumber[j], out var result))
                    {
                        NumbersFromTheExample.Add(result);
                        j++;
                        break;
                    }
                    else
                    {
                        Reading();
                        StringPotentialNumber.Remove("");
                        LengthArray = StringPotentialNumber.Count;
                        j = 0;
                        i = 0;
                    }
                }
            }
            return NumbersFromTheExample;
        }

        public void Calculation()
        {            
            Validation();
            double result = 1;
            for (int g = 0; g < MathematicalSymbols.Count; g++)
            {
                List<double> NumbersInParentheses = new List<double>();
                List<char> MathematicalSymbolsInParentheses = new List<char>();
                if (MathematicalSymbols[g] == '(')
                {
                    for (int j = g + 1; j < MathematicalSymbols.Count; j++)
                    {
                        if (MathematicalSymbols[j] == ')')
                        {
                            NumbersInParentheses.Add(NumbersFromTheExample[j - 1]);
                            NumbersFromTheExample.RemoveAt(j - 1);
                            break;
                        }
                        else
                        {
                            NumbersInParentheses.Add(NumbersFromTheExample[j - 1]);
                            MathematicalSymbolsInParentheses.Add(MathematicalSymbols[j]);
                            NumbersFromTheExample.RemoveAt(j - 1);
                            MathematicalSymbols.RemoveAt(j);
                            j -= 1;
                        }                        
                    }
                    for (int i = 0; i < MathematicalSymbolsInParentheses.Count; i++)
                    {
                        if (MathematicalSymbols[i] == '^')
                        {
                            for (int j = 0; j < NumbersInParentheses[i + 1]; j++)
                            {
                                result = result * NumbersInParentheses[i];
                            }
                            NumbersInParentheses[i] = result;
                            NumbersInParentheses.RemoveAt(i + 1);
                            MathematicalSymbolsInParentheses.RemoveAt(i);
                            i -= 1;
                        }
                    }
                    result = NumbersInParentheses[0];
                    for (int i = 0; i < MathematicalSymbolsInParentheses.Count; i++)
                    {
                        if (MathematicalSymbolsInParentheses[i] == '*')
                        {
                            result = NumbersInParentheses[i] * NumbersInParentheses[i + 1];
                            NumbersInParentheses[i] = result;
                            NumbersInParentheses.RemoveAt(i + 1);
                            MathematicalSymbolsInParentheses.RemoveAt(i);
                            i -= 1;

                        }
                        else if (MathematicalSymbolsInParentheses[i] == '/')
                        {
                            result = NumbersInParentheses[i] / NumbersInParentheses[i + 1];
                            NumbersInParentheses[i] = result;
                            NumbersInParentheses.RemoveAt(i + 1);
                            MathematicalSymbolsInParentheses.RemoveAt(i);
                            i -= 1;
                        }
                    }
                    result = NumbersInParentheses[0];
                    for (int i = 0; i < MathematicalSymbolsInParentheses.Count; i++)
                    {
                        if (MathematicalSymbolsInParentheses[i] == '+')
                        {
                            result = result + NumbersInParentheses[i + 1];
                        }
                        else if (MathematicalSymbolsInParentheses[i] == '-')
                        {
                            result = result - NumbersInParentheses[i + 1];
                        }
                    }
                    NumbersFromTheExample.Insert(g, result);
                    MathematicalSymbols.Remove('(');
                    MathematicalSymbols.Remove(')');
                }
            }

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
            StringPotentialNumber.Clear();
        }
    }
}
