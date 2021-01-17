using System.Collections.Generic;

namespace HL.Aspect
{
    public class Core
	{
		public static List<int> ConvertResolutionToAspect(int witdh, int height)
		{
			if (witdh > 20000 || height > 20000)
			{
				return new List<int> { 1, 1 };
			}
			else if (witdh < 50 || height < 50)
			{
				return new List<int> { 1, 1 };
			}
			else
			{
				witdh |= 0;
				height |= 0;

				var gcd = lcm.Gcd(witdh, height);
				List<int> result = new List<int> { witdh / gcd, height / gcd };
				var result2 = height / gcd;
				return result;
			}
		}
	}
}
