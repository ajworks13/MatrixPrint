using System;

/*
	NOTES:
		I want it to print random characters of all types
		in a controlled speed.

		Use random to randomize.
		
*/

class Program {
  public static void Main (string[] args) {

		int[] numbers = {1,2,3,4,5,6,7,8,9};
		String[] characters = {"A","B","C","D","E"};
		String[] specialCharacters = {"!","@","#","$"};
		
		Random randInt = new Random();
		int randomNumber = randInt.Next(10);
		
		Random randStr = new Random();
		int randomString = randStr.Next(5);
		
		Random randSpec = new Random();
		int randomSpecial = randSpec.Next(4);

		switch(randomNumber){
			case 1:
				Console.WriteLine(numbers[0]);
				break;
			case 2:
				Console.WriteLine(numbers[1]);
				break;
			case 3:
				Console.WriteLine(numbers[2]);
				break;
			case 4:
				Console.WriteLine(numbers[0]);
				break;
			case 5:
				Console.WriteLine(numbers[0]);
				break;
			case 6:
				Console.WriteLine(numbers[0]);
				break;
			case 7:
				Console.WriteLine(numbers[0]);
				break;
			case 8:
				Console.WriteLine(numbers[0]);
				break;
			case 9:
				Console.WriteLine(numbers[0]);
				break;

		}


		
		
	}
}
