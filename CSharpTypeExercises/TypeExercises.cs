using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypeExercises
{
	//Note: You will need to remove the line throw new NotImplementedException() from each subprogram before calling it.
	public static class TypeExercises
	{
		// Q1: Calculator 1
		// Write to the console the results of: +. - , *, / 
		// What happens if you pass in 10 and 3? Are the results as you would expect?
		public static void Calculator(int num1, int num2)
		{
			Console.WriteLine($"{num1} + {num2} is {num1 + num2}");
			Console.WriteLine($"{num1} - {num2} is {num1 - num2}");
			Console.WriteLine($"{num1} x {num2} is {num1 * num2}");
			Console.WriteLine($"{num1} / {num2} is {num1 / num2}");
		}

		// Q2: Calculator 2
		// Write to the console the results of: +. - , *, /
		// What happens if you pass in 10 and 3 now that the parameters are doubles rather than integers?
		public static void Calculator2(double num1, double num2)
		{
			Console.WriteLine($"{num1} + {num2} is {num1 + num2}");
			Console.WriteLine($"{num1} - {num2} is {num1 - num2}");
			Console.WriteLine($"{num1} x {num2} is {num1 * num2}");
			Console.WriteLine($"{num1} / {num2} is {num1 / num2}");
		}

		// Q3: Binary Strings
		// Write to the console the number printed in Binary, Decimal and Hex formats
		public static void BinaryStrings(int num)
		{
			Console.WriteLine($"{num} in binary is {Convert.ToString(num, 2)}");
			Console.WriteLine($"{num} in decimal is {Convert.ToString(num, 10)}");
			Console.WriteLine($"{num} in hexadecimal is {Convert.ToString(num, 16)}");
		}

		// Q4: BMI
		// Calculate the BMI - Body mass index
		// Ask the user for their height in meters and their weight in kilograms
		// You will need to convert the values from string to double
		// Write the output to the console
		public static void BMICalculator()
		{
			Console.Write("What is your height in meters? ");
			string heightInput = Console.ReadLine() ?? string.Empty;

			Console.Write("What is your weight in kilograms? ");
			string weightInput = Console.ReadLine() ?? string.Empty;

			double height = Convert.ToDouble(heightInput);
			double weight = Convert.ToDouble(weightInput);

			double bmi = weight / Math.Pow(height, 2);
			Console.WriteLine($"Your BMI is {Math.Round(bmi, 1)}");
		}

		// Q5: FutureDate
		// Write to the console today's date. Return the date that it will be when the days passed in are added to the current date. 
		public static DateTime FutureDate(int days)
		{
			// The :d formats the date in short date format
			Console.WriteLine($"The date today is {DateTime.Today:d}");
			return DateTime.Today.AddDays(days);
		}

		// Q6: Leap Year
		// Return whether or not the dateTime passed in is in a leap year.
		// Feel free to use the method DateTime.IsLeapYear
		public static bool LeapYear(DateTime dateTime)
		{
			return DateTime.IsLeapYear(dateTime.Year);
		}
	}
}
	
