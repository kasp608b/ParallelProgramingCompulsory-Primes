using System;
using System.CodeDom;
using System.Collections;
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
        public List<long> GetPrimesSequential(long first, long last)
        {

            List<long> PrimesFound = new List<long>();

            for (long i = first; i <= last; i++)
            {
                if (IsPrime(i))
                {
                    PrimesFound.Add(i);
                }
            }

            return PrimesFound;

        }

        public List<long> GetPrimesParallel(long first, long last)
        {

            ConcurrentQueue<long> PrimesFound = new ConcurrentQueue<long>();
            Parallel.For(first, last, (i) =>
            {
                if (IsPrime(i))
                {
                    PrimesFound.Enqueue(i);
                }
            });

            List<long> sortedPrimes = PrimesFound.ToList<long>();
            sortedPrimes.Sort();

            return sortedPrimes;

        }


        public void MeasureTime(Action ac, string name)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("starting " + name);
            ac.Invoke();
            sw.Stop();
            Console.WriteLine(name + " Total Time = {0:f3} sec.", sw.Elapsed.TotalSeconds);

        }

        private bool IsPrime(long number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (long i = 3; i * i <= number; i += 2)
                if (number % i == 0)
                    return false;
            return true;
        }

    }
}
