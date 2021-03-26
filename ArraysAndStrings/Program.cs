using System;
using System.Text;

namespace ArraysAndStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            //One size array
            int[] Numbers = new int[5] { 1, 2, 3, 4, 5 };

            // Prints the one size array and the sum of its elements
            // I used Stringbuilder for displaying the array
            Console.WriteLine("The sum of elements " + DisplayArray(Numbers) + "is: " + SumElementsOfArray(Numbers));

            //Two size array
            int[][] Array = new int[4][] {
                new int[] { 0, 0, 0},
                new int[]  { 1, 1, 1},
                new int[] { 2, 2, 2},
                new int[] { 3, 3, 3 } };

            //Prints the two sized array in the format of a matrix
            // I used Stringbuilder for displaying the array
            Console.WriteLine(DisplayArray(Array));


            string s1 = "Hello";
            string s2 = "Hello";
            compareStringsByReference(ref s1, ref s2);


        }
        public static StringBuilder DisplayArray(int[] Array)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            for (int i = 0; i < Array.Length - 1; i++)
            {
                sb.Append(Array[i] + ", ");
            }
            sb.Append(Array[Array.Length - 1] + "} ");
            return sb;
        }

        public static StringBuilder DisplayArray(int[][] array)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("The matrix is: ");

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sb.Append(array[i][j] + " ");
                }
                sb.AppendLine();
            }

            return sb;
        }


        public static int SumElementsOfArray(int[] array)
        {
            int Sum = 0;
            foreach (int element in array)
            {
                Sum += element;
            }

            return Sum;

        }

        public static int SumElementsOfArray(int[][] array)
        {
            int Sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Sum += array[i][j];
                }
            }

            return Sum;

        }


        public static void compareStringsByReference(ref string s1, ref string s2)
        {
            if (s1.GetHashCode() == s2.GetHashCode())
            {
                Console.WriteLine("Strings have same reference");
            }
            else
            {
                Console.WriteLine("Strings don't have same reference");
            }
        }

    }

}
