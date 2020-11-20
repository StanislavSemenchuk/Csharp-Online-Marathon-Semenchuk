using System;
using System.Linq;

namespace Task_02
{
    public class Class1
    {
        public static double EvaluateAggregate(double[] inputData, Func<double, double, double> aggregate, Func<double, int, bool> predicate)
        {
            return inputData.Where(predicate).Aggregate(aggregate);
        }
    }
}
