using System;

namespace LinkedList
{
	public class Node
	{
		public int data;
		Node next;
		public Node (int value)
		{
			next = null;
			data = value;

		}

		public void addAnObject(int ValuetobeAdded)
		{


			if (next == null) {

				next = new Node (ValuetobeAdded);


			} else {



				next.addAnObject (ValuetobeAdded);



			}

		}


		public void PrintTheValues()
		{
			Console.WriteLine (data);
			if (next != null) {
				next.PrintTheValues ();

			}



		}

	}
}

