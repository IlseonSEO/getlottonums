using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeLottoClass
{
	class Program
	{
		static void Main(string[] args)
		{
			Numbers num = new Numbers();
			num.CreateNumbers();
		}
	}
	public class Numbers
	{
		public void CreateNumbers()
		{
			//1.로또번호는 1부터 45까지 이다.
			int min = 1;
			int max = 46;

			//2.로또는 중복되지 않는 6개의 숫자를 뽑는다.
			int numberCount = 6;

			Random ran = new Random();
			List<int> list = new List<int>();

			while (list.Count < numberCount)
			{
				int randomNum = ran.Next(min, max);
				if (list.Contains(randomNum) == false)
				{
					list.Add(randomNum);
					Console.WriteLine(randomNum);
				}
			}

			Console.ReadKey();
		}
	}
}
