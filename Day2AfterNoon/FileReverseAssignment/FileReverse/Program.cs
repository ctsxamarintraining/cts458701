using System;
using System.IO;
namespace FileReverse
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			FileStream fileStream1 = new FileStream("MyFile.txt", FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter writer1 = new StreamWriter(fileStream1);
			writer1.Write("This is a file with text format");
			writer1.Close();


			TextReader tr = new StreamReader ("MyFile.txt");
			string StringFile=tr.ReadToEnd();
			char []StringArray = StringFile.ToCharArray();
			Array.Reverse(StringArray);
			string str = new string(StringArray);
			Console.WriteLine (str);
			tr.Close();


			FileStream FileStream2= new FileStream("MyReversedFile.txt", FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter writer2 = new StreamWriter(FileStream2);
			writer2.Write(str);
			writer2.Close();



		}
	}
}
