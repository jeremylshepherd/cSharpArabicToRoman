/*
Simple Console program to convert Integers ranging 1 to 3999 into Roman numerals.
*/

using System;

namespace ShepherdJeremyArabicToRoman
{
    class Program
    {
		public static void GoRoman(int number)
		{
			string roman = "";
			int[] nums = new int[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
			string[] syms = new string[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
			int i = 12;

			while (number > 0)
			{
				int div = number / nums[i];
				number %= nums[i];
				for (int j = 0; j < div; j++)
				{
					roman += syms[i];
				}
				i--;
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(roman);
		}

		public static int GetNum()
		{
			int num;
			string val;			
			Console.Write("Enter an integer (enter -1 to quit) ");
			val = Console.ReadLine();
			num = Convert.ToInt32(val);
			return num;
		}

		public static void Main()
		{
			int number;
			number = GetNum();
			while (number != -1)
			{
				while (number < 1 || number > 3999)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("Out of range, Please choose 1 - 3999. ");
					number = GetNum();
					if (number == -1)
					{
						Console.ResetColor();
						Console.WriteLine("Goodbye!");
						System.Environment.Exit(0);
					}
				}
				GoRoman(number);
				Console.ResetColor();
				number = GetNum();
			}
			Console.WriteLine("Goodbye!");
		}
	}
}
