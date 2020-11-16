using System;
using System.Collections.Generic;
namespace Task_3
{
	public class ShowPower
	{
		public static IEnumerable<double> SuperPower(int numb, int deg) 
		{
			double result = 1;

			if (numb == 0) 
			{
				yield return 0;
			}
			else if (deg > 0)
			{
				for (int i = 0; i < deg; i++)
				{
					result *= numb;
					yield return result;
				}
			}
			else if (deg == 0)
			{
				yield return result;
			}
			else 
			{
				for (int i = 0; i > deg; i--)
				{
					yield return result /= numb;
				}
			}
		}
	}
}

