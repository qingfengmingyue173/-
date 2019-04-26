using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("数组；6,8,7,5,9,3,5,7,4,2,1,1，5,求最大值");
			int[] shuzu = new int[] { 6, 8, 7, 5, 9, 3, 5, 7, 4, 2, 1, 1, 5 };
			Console.WriteLine("预设最大值为0");
			int max = 0;
			for (int i = 0; i < shuzu.Length - 1; i++)
			{
				if (max < shuzu[i])
				{
					Console.WriteLine($"进行第{i + 1}次比较{max} < {shuzu[i]}最大值为{shuzu[i]}");
					max = shuzu[i];
				}
				else
				{
					Console.WriteLine($"进行第{i + 1}次比较{max} > {shuzu[i]}最大值为{max}");
				}

			}
			Console.Read();
		}
	}
}
