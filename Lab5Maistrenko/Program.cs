using Lab5.Implementation;
using System;
using System.Collections.Generic;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var customList = new CustomList<int>(new List<int> { 1, 4, 9, 16, 25 });
            var iterator = customList.GetIterator();

            Console.WriteLine("In order: ");
            while (!iterator.Finished())
            {
                Console.WriteLine(iterator.Current);
                iterator = iterator.Next();
            }

            Console.WriteLine("In reverse: ");

            iterator = customList.GetReverseIterator();
            while (!iterator.Finished())
            {
                Console.WriteLine(iterator.Current);
                iterator = iterator.Next();
            }
        }
    }
}
