﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    internal class PrimeGenerator
    {
        public List<long> GetPrimesSequential(long first, long last)
        {

            List<long> PrimesFound = new List<long>();
            int a, b, i, j, flag;

            a = Convert.ToInt32(first); // Take input

            b = Convert.ToInt32(last); // Take input

            // Explicitly handling the cases when a is less than
            // 2
            if (a == 1)
            {
                PrimesFound.Add(a);
                a++;
                if (b >= 2)
                {
                    PrimesFound.Add(a);
                    a++;
                }
            }
            if (a == 2)
            {
                PrimesFound.Add(a);
            }

            // MAKING SURE THAT a IS ODD BEFORE WE BEGIN
            // THE LOOP
            if (a % 2 == 0)
            {
                a++;
            }

            // NOTE : WE TRAVERSE THROUGH ODD NUMBERS ONLY
            for (i = a; i <= b; i = i + 2)
            {

                // flag variable to tell
                // if i is prime or not
                flag = 1;

                // WE TRAVERSE TILL SQUARE ROOT OF j only.
                // (LARGEST POSSIBLE VALUE OF A PRIME FACTOR)
                for (j = 2; j * j <= i; ++j)
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
                    PrimesFound.Add(i);
                }
            }

            return PrimesFound;

        }

        public List<long> GetPrimesParallel(long first, long last)
        {
            throw new NotImplementedException();
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