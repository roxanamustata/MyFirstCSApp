
using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class Program
    {


        static void Main(string[] args)
        {

#if DEBUG
            Console.WriteLine("Debug version");
#endif
            DisplayArray(DivideArray(0, 10));

        }

        public static int[] DivideArray(int MinValue, int MaxValue)
        {

            var Result = new int[3];
            try
            {
                var Numbers = CreateArrayDivisibleByThree();
                Console.WriteLine("Please enter a divisor: ");
                int Divisor = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < Numbers.Length; i++)
                {
                    var Temp = Divide(Numbers[i], Divisor);

                    if (Temp >= MinValue && Temp <= MaxValue)
                    {
                        Result[i] = Divide(Numbers[i], Divisor);
                    }
                }
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Exception occured: {0} ", ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception occured: {0} ", ex.Message);
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception occured: {0} ", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured: {0} ", ex.Message);
            }
            finally
            {
                Console.WriteLine("End of division");
            }

            return Result;

        }



        public static int Divide(int Dividend, int Divisor)
        {
            int result = 0;

            try
            {
                result = Dividend / Divisor;

            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Exception:{0}", ex);
            }
            return result;
        }


        public static int[] CreateArrayDivisibleByThree()
        {

            int[] Numbers = new int[3];

            Console.WriteLine("Please enter 3 numbers: ");

            for (int i = 0; i < Numbers.Length; i++)
            {

                var x = Convert.ToInt32(Console.ReadLine());

                if (x % 3 == 0)
                {
                    Numbers[i] = x;
                }
                else
                {
                    throw new CustomException();
                }
            }
            return Numbers;
        }

        public static void DisplayArray(int[] Array)
        {
            var sb = new StringBuilder();
            sb.Append("[ ");
            for (int i = 0; i < Array.Length - 1; i++)
            {
                sb.Append($"{Array[i]}, ");
            }
            sb.Append($"{Array[^1]} ]");
            Console.WriteLine(sb.ToString());
        }


    }

}

