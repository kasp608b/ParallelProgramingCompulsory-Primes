using System;
using System.CodeDom;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    internal class PrimeGenerator
    {

        static readonly object theLock = new object();

        public List<long> GetPrimesSequential(long first, long last)
        {

            List<long> primesFound = new List<long>();
            int a, b, i, j, flag;

            a = Convert.ToInt32(first); // Take input

            b = Convert.ToInt32(last); // Take input

            // Traverse each number in the interval
            // with the help of for loop
            for (i = a; i <= b; i++)
            {

                // Skip 0 and 1 as they are
                // neither prime nor composite
                if (i == 1 || i == 0)
                    continue;

                // flag variable to tell
                // if i is prime or not
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                // flag = 1 means i is prime
                // and flag = 0 means i is not prime
                if (flag == 1)
                {
                    primesFound.Add(i);
                }
                   
            }

            primesFound.Sort();
            return primesFound;

        }

        public List<long> GetPrimesParallel(long first, long last)
        {
            object theLock = new object();

            List<long> primesFound = new List<long>();
            int a, b, i, j, flag;

            a = Convert.ToInt32(first); // Take input

            b = Convert.ToInt32(last); // Take input


            // Explicitly handling the cases when a is less than
            // 2
            if (a == 0)
            {
                a++;
            }
            if (a == 1)
            {

                a++;
                if (b >= 2)
                {
                    primesFound.Add(a);
                    a++;
                }
            }
            if (a == 2)
            {
                primesFound.Add(a);
            }

            Parallel.For(a, b + 1, i =>
            {
               
                // flag variable to tell
                // if i is prime or not
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                // flag = 1 means i is prime
                // and flag = 0 means i is not prime
                if (flag == 1)
                {
                    lock (theLock)
                    {
                        primesFound.Add(i);
                    }

                }
            });

            primesFound.Sort();
            return primesFound;

        }


        public void MeasureTime(Action ac, string name)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("starting " + name);
            ac.Invoke();
            sw.Stop();
            Console.WriteLine(name + " Total Time = {0:f3} sec.", sw.Elapsed.TotalSeconds);

        }
    }
}
