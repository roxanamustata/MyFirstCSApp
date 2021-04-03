using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public static class Extensions
    {
        public static void Display<T>(this IEnumerable<T> source)
        {
            foreach (var element in source)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }

        //I use this for displaying categories
        public static string DisplayAsString<T>(this IEnumerable<T> source)
        {
            var sb = new StringBuilder();
            foreach (var element in source)
            {
                sb.Append($"{element} ");
            }
            return sb.ToString();
        }
        
        public static void DisplayIGrouping<T>(this IEnumerable<IGrouping<int, T>> source)
        {

            foreach (IEnumerable<T> element in source)
            {
                Display(element);
            }

        }

    }
}
