using System;

namespace ConsoleApp1
{
    class Program
    {
        enum Operacao { Addition, Subtraction, Division, Multiplication }

        //Forma tradicional
        //static int SolveOperation(int a, int b, Operacao operation)
        //{
        //    var total = 0;

        //    switch (operation)
        //    {
        //        case Operacao.Addition:
        //            total = a + b;
        //            break;

        //        case Operacao.Subtraction:
        //            total = Math.Abs(a - b);
        //            break;

        //        case Operacao.Division:
        //            total = a / b;
        //            break;

        //        case Operacao.Multiplication:
        //            total = a * b;
        //            break;

        //        default:
        //            total = 0;
        //            break;
        //    }
        //    return total;
        //}


        //Switch expressions
        static int SolveOperation(int a, int b, Operacao operation)
        {

            var total = operation switch
            {
                Operacao.Addition => a + b,
                Operacao.Subtraction => Math.Abs(a - b),
                Operacao.Division => ((Func<int>)(() =>
                {
                    try
                    {
                        return a / b;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }))(),
                Operacao.Multiplication => a * b,
                _ => 0
            };

            return total;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(SolveOperation(5, 7, Operacao.Multiplication));
        }
    }
}
