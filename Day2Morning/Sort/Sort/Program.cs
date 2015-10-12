using System;
using System.Collections;

namespace Sort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person[] personArray = new Person[5];

			personArray [0] = new Person( "John", 30 );
			personArray [1] = new Person("Mathew", 26 );
			personArray [2] = new Person( "Alex", 19 );
			personArray [3] = new Person("Phil", 28 );
			personArray [4] = new Person("Ram", 35 );

			Array.Sort(personArray, Person.SortByName);

			for (int i = 0; i < personArray.Length; i++) {

				Console.WriteLine (personArray[i].name);
			}
		}
	}
}
