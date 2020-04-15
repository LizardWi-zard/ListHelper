using System;
using System.Collections.Generic;

namespace HelperList
{
    class Program
    {           
        static void Main(string[] args)
        {

            List<object> numbers = new List<object>() { 1, 2, 2, 2, 3, 4, 6, 3, 3, 3, 5 };
            List<object> unique = numbers.GetUnique();
            List<object> duplicates = numbers.GetDuplicates();

            foreach (object item in unique)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (object item in duplicates)
            {
                Console.Write(item + " ");
            }


            /*
            List<string> words = new List<string>();
            List<bool> statments = new List<bool>();
            List<decimal> decimals = new List<decimal>();
            */

        }
    }

    public static class ListHelper
    {
        public static List<T> GetUnique<T>(this List<T> givenList) 
        {
            List<T> outPutList = new List<T>();
            foreach (var checkable in givenList)
            {
                if (!outPutList.Contains(checkable))
                {
                    outPutList.Add(checkable);
                }
            }
            return outPutList;
        }

        public static List<T> GetDuplicates<T>(this List<T> givenList)
        {
            List<T> temp = new List<T>();
            List<T> result = new List<T>();

            foreach (var checkable in givenList)
            {
                if (temp.Contains(checkable))
                {
                    result.Add(checkable);
                } 
                else
                {
                    temp.Add(checkable);
                }
            }
            return result;
        }
    }
}
