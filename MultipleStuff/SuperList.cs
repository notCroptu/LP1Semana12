using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuf
{
    public class SuperList : List<double>
    {
        public void GetMinMax1(out double min, out double max)
        {
            Sort();
            min = -1;
            max = -1;

            if (Count != 0)
            {
                min = this[0];
                max = this[Count - 1];
            }
        }
        public struct MinMax
        {
            public double Min { get; set; }
            public double Max { get; set; }
        }
        public MinMax GetMinMax2()
        {
            Sort();
            double min = -1;
            double max = -1;

            if (Count != 0)
            {
                min = this[0];
                max = this[Count - 1];
            }

            return new MinMax { Min = min, Max = max };
        }
        public Tuple<double, double> GetMinMax3()
        {
            Sort();
            double min = -1;
            double max = -1;

            if (Count != 0)
            {
                min = this[0];
                max = this[Count - 1];
            }

            return new Tuple<double, double>(min, max);
        }
        public (double Min, double Max) GetMinMax4()
        {
            Sort();
            double min = -1;
            double max = -1;

            if (Count != 0)
            {
                min = this[0];
                max = this[Count - 1];
            }

            return (min, max);
        }
    }
}