using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double[] data = { 115, 182, 191, 31, 196, 1099, 5, 172, 10, 179, 83, 21, 20, 21, 186, 177, 195, 193, 188, 199, 62, 109, 105, 183, 110 };
            Array.Sort(data);
            int n = data.Length;
            //mean
            double mean = data.Average();
            //median
            double median;
            if (n % 2 == 0)
            {
                median = (data[n / 2 - 1] + data[n / 2]) / 2;
            }
            else
            {
                median = data[n / 2];

            }
            //mode
            double mode = data[0];
            int maxcount = 0;
            for (int i = 1; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (data[i] == data[j])
                    {
                        count++;
                    }
                }
                if (count > maxcount)
                {
                    maxcount = count;
                    mode = data[i];
                }
            }
            //variance
            double sumvar = 0;
            for (int i = 0; i < n; i++)
            {
                sumvar += Math.Pow(data[i] - mean, 2);

            }
            double variance = sumvar / n;
            //standard deviation
            double stddev = Math.Sqrt(variance);
            //percentile
            double percentile(double p)
            {
                double pos = (p / 100) * (n - 1);
                int i = (int)pos;
                double frac = pos - i;
                if (i + 1 < n)
                    return data[i] + frac * (data[i + 1] - data[i]);
                else return data[i];
            }
            double p20 = percentile(20);
            double p50 = percentile(50);
            //quartiles
            double q1 = data[n / 4];

            double q2 = data[n / 2];
            double q3 = data[(3 * n) / 4];
            //range
            double range = data[n - 1] - data[0];
            //iqr

            double Iqr = q3 - q1;




            double lower = q1 - 1.5 * Iqr;
            double upper = q3 + 1.5 * Iqr;
            foreach (int x in data)
            {
                if (x < lower || x > upper)
                {
                    Console.WriteLine(x + " Qutlier");
                }
                else
                {

                    Console.WriteLine(x + " Normal");

                }
            }
            Console.WriteLine("Mean=" + mean);
            Console.WriteLine("Median=" + median);
            Console.WriteLine("Mode=" + mode);
            Console.WriteLine("variance=" + variance);
            Console.WriteLine("p20=" + p20);
            Console.WriteLine("p50=" + p50);
            Console.WriteLine("q1=" + q1);
            Console.WriteLine("q2=" + q2);
            Console.WriteLine("q3=" + q3);
            Console.WriteLine("Range=" + range);
            Console.WriteLine("IQR=" + Iqr);
            Console.WriteLine("standard Deviation=" + stddev);
        }
    }
}
        

    


