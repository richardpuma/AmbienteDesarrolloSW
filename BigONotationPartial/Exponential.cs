using System;
using System.Diagnostics;

namespace BigONotationPartial
{
    class Exponential
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Exponential exponential = new Exponential();
            ExponentialExampleType exponentialExampleType = ExponentialExampleType.Fibonacci;
            switch (exponentialExampleType)
            {
                case ExponentialExampleType.Fibonacci:
                    int valor = 150;
                    exponential.Fibonacci(valor);
                    break;
            }
            Console.WriteLine("Time elapsed: {0:0.00} seconds", Math.Round(stopWatch.ElapsedMilliseconds / 1000.0, 2));
            Console.ReadLine();
        }

        /// Complexity: O(2^N)
        internal void Fibonacci(int n)
        {
            if (n < 0)
            {
                throw new Exception("n can not be less than zero");
            }
            Int32 a = 0,b=1,aux=0;

            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Valor {0} = {1}", i, a);
                }
                else
                {
                    aux = a;
                    a = b;
                    b = aux + a;
                    Console.WriteLine("Valor {0} = {1}", i, a);
                }
            }
        }
    }
}
