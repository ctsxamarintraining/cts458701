using System;

namespace LinkedList
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Node myNode = new Node(1);
			myNode.addAnObject (2);
			myNode.addAnObject (3);
			myNode.addAnObject (4);
			myNode.PrintTheValues ();  
		}
	}
}
