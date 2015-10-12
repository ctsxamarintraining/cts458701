using System;
namespace assgn1
{
class Program
{
	static void Main()
	{

		string[, , ,] MyArray = new string[2, 2, 2, 2];
			MyArray [0, 0, 0, 0] = "one";
			MyArray [0, 0, 0, 1] = "two";
			MyArray [0, 0, 1, 0] = "three";
			MyArray [0, 0, 1, 1] = "four";
			MyArray [0, 1, 0, 0] = "five";
			MyArray [0, 1, 1, 1] = "six";
			MyArray [0, 1, 1, 0] = "seven";
			MyArray [0, 1, 1, 1] = "eight";
			MyArray [1, 0, 0, 0] = "nine";
			MyArray [1, 1, 1, 1] = "apple";
			MyArray [1, 0, 1, 0] = "mango";
			MyArray [1, 0, 1, 1] = "waterMelon";
			MyArray [1, 1, 1, 0] = "grapes";
			MyArray [0, 1, 1, 1] = "banana";
			MyArray [0, 1, 0, 1] = "apricot";
			MyArray [1, 0, 0, 1] = "cherry";
			MyArray [1, 1, 0, 0] = "custardApple";

			for (int i = 0; i < MyArray.GetLength(3); i++)
		{
				for (int y = 0; y < MyArray.GetLength(2); y++)
			{
					for (int x = 0; x < MyArray.GetLength(1); x++)
				{
						for(int z=0; z< MyArray.GetLength(0); z++)
						{
							
							Console.Write(MyArray[x, y, z, i]);

				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
	}
}