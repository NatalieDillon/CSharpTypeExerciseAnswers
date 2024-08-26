namespace CSharpTypeExercises
{
	internal class Program
	{
		static void Main()
		{
			// Write code here to call each sub program in TypeExercises
			// In the case where the subprogram returns a value (a function) you should output the result with a suitable message
			// The first call has been written for you.

			// Call Q1
			TypeExercises.Calculator(10, 3);
			Console.WriteLine();

			// Call Q2
			TypeExercises.Calculator2(10, 3);
			Console.WriteLine();

			// Call Q3
			TypeExercises.BinaryStrings(38);
			Console.WriteLine();

			// Call Q4
			TypeExercises.BMICalculator();
			Console.WriteLine();

			// Call Q5
			const int days = 5;
			DateTime futureDate = TypeExercises.FutureDate(days);
			Console.WriteLine($"In {days} days it will be {futureDate:d}");
			Console.WriteLine();

			// Call Q6
			DateTime date = new (2008, 01, 01);
			bool isLeapYear = TypeExercises.LeapYear(date);
			Console.WriteLine($"{date:d} is a leap year : {isLeapYear}");

		}
	}
}