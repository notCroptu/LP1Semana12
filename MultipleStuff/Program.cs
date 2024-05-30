using System;

namespace MultipleStuf
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList superList = new SuperList { 1.2, 3.4, 5.6, 7.8, 2.3 };

            superList.GetMinMax1(out double min1, out double max1);
            Console.WriteLine($"GetMinMax1 -> Min: {min1}, Max: {max1}");

            var minMax2 = superList.GetMinMax2();
            Console.WriteLine($"GetMinMax2 -> Min: {minMax2.Min}, Max: {minMax2.Max}");

            Tuple<double, double> minMax3 = superList.GetMinMax3();
            Console.WriteLine($"GetMinMax3 -> Min: {minMax3.Item1}, Max: {minMax3.Item2}");

            ValueTuple<double, double> minMax4 = superList.GetMinMax4();
            Console.WriteLine($"GetMinMax4 -> Min: {minMax4.Item1}, Max: {minMax4.Item2}");
        }
    }
}
