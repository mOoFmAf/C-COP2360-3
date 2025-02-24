// Nicholas Corrente

using System;

class Program {
	
	static int divide(int a, int b) {
		return a / b;
	}
	// takes in the strings as an argument to the program itself rather than asking for user input
	static void Main(string[] args) {
		
		int len = args.Length;
		int a, b, c = 0;
		
		if (args[0] == "help") {
			Console.WriteLine("Type two whole number separated by spaces when running the program like so");
			Console.WriteLine(".\\try.exe 20 2");
			Console.WriteLine("This should give you 10");
			return;
		}
		
		if (len < 2) {
			Console.WriteLine("ERROR: too few args"); 
			return;
		} // just takes the first two args as string
		string str1 = args[0];
		string str2 = args[1];
		
		try {
			a = Convert.ToInt32(str1);
			b = Convert.ToInt32(str2);
			
			c = divide(a, b);
		} catch (FormatException e) {
			Console.WriteLine(e.Message);
			Console.WriteLine("Use an integer number.");
			return;
		} catch (DivideByZeroException e) {
			Console.WriteLine(e.Message);
			return;
		} catch (OverflowException e) {
			Console.WriteLine(e.Message);
			return;
		} catch (Exception e) {
			Console.WriteLine(e.Message);
			return;
		}
		
		Console.WriteLine(str1 + "/" + str2 + " = " + Convert.ToString(c));

	}
}
