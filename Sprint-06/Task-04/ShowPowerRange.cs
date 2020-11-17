using System;
using System.Collections.Generic;

namespace Task_04
{
    public class ShowPowerRange
    {
        public static IEnumerable<double> PowerRanger(int deg, int start, int finish)
        {
            if (start > 0 && finish > 0 && start < finish && deg != 0)
            {
                int startRange = (int)Math.Ceiling(Math.Pow(start, 1.0 / deg));

                while (Math.Pow(startRange, deg) <= finish)
                {
                    yield return Math.Pow(startRange, deg);
                    startRange++;
                }
            }
            else if (deg == 0)
            {
                yield return 1;
            }
            else
            {
                yield return 0;
            }
        }
    }
}
