using System;

namespace GarbageCollection
{
	class Garbage1
	{
		int[] a1 = new int[100];
		string[] a2 = new string[100];
	}
	class Garbage2:Garbage1
	{
		int[] b = new int[10000];
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			MainClass.createGarbage (1000);
			Console.WriteLine (GC.GetTotalMemory(false));
			GC.Collect();
			Console.WriteLine (GC.GetTotalMemory(false));

		}

		static void createGarbage(int x)
		{
			Garbage1 garb;
			for (int i = 0; i < x; i++) 
			{
				garb = new Garbage1 ();
			}
		}

	}

}