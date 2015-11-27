using System;
using System.Collections;

namespace BST
{

	public class Node
	{
		public Node greaterSubNode;
		public Node lesserSubNode;
		public int NodeValue;

		public Node ()
		{
		}

		public Node (int data)
		{
			NodeValue = data;
			greaterSubNode = null;
			lesserSubNode = null;
		}

		public Node (Node theinputnode)
		{
			greaterSubNode = theinputnode.greaterSubNode;
			lesserSubNode = theinputnode.lesserSubNode;
			NodeValue = theinputnode.NodeValue;
		}
	}

	public class BinarySearchTree
	{
		public Node root;
		public Node current_Node;
		public int level = 0;
		private int levelCalculator = 0;



		public bool Add (int data)
		{ 
			Node toAdd = new Node ();
			toAdd.NodeValue = data;
			toAdd.lesserSubNode = null;
			toAdd.greaterSubNode = null;

			levelCalculator = 0;

			if (root == null) {
				root = toAdd;
				current_Node = toAdd;
				return true;
			}

			current_Node = root;
			while (true) {
				if (current_Node.NodeValue == data) {
					return false;

				} else if (current_Node.NodeValue > data) {
					levelCalculator++;
					if (current_Node.lesserSubNode == null) {
						current_Node.lesserSubNode = toAdd;
						current_Node = toAdd;
						if (level < levelCalculator)
							level = levelCalculator;
						return true;

					} else {
						current_Node = current_Node.lesserSubNode;
					}
				} else {
					levelCalculator++;
					if (current_Node.greaterSubNode == null) {
						current_Node.greaterSubNode = toAdd;
						current_Node = toAdd;
						if (level < levelCalculator)
							level = levelCalculator;
						return true;

					} else {
						current_Node = current_Node.greaterSubNode;
					}
				}
			}
		}

		public bool Search (int searchValue)
		{
			bool searchflag = false;
			current_Node = root;

			while (true) {
				if (current_Node.NodeValue == searchValue) {
					searchflag = true;
					break;
				} else if (current_Node.NodeValue > searchValue) {
					if (current_Node.lesserSubNode == null) {
						searchflag = false;
						break;
					} else {
						current_Node = current_Node.lesserSubNode;
					}
				} else if (current_Node.NodeValue < searchValue) {
					if (current_Node.greaterSubNode == null) {
						searchflag = false;
						break;
					} else {
						current_Node = current_Node.greaterSubNode;
					}
				}
			}
			return searchflag;
		}

		public void Delete (int deleteValue)
		{
			root = DeleteKey (root, deleteValue);
		}

		private Node DeleteKey (Node theRootNode, int Key)
		{

			if (theRootNode == null)
				return theRootNode;


			if (Key < theRootNode.NodeValue) {

				theRootNode.lesserSubNode = DeleteKey (theRootNode.lesserSubNode, Key);

			} else if (Key > theRootNode.NodeValue) {

				theRootNode.greaterSubNode = DeleteKey (theRootNode.greaterSubNode, Key);

			} else {

				if (theRootNode.lesserSubNode == null) {
					return theRootNode.greaterSubNode;
				} else if (theRootNode.greaterSubNode == null) {
					return theRootNode.lesserSubNode;
				}

				// node with two children: smallest in the right subtree
				Node temp = new Node (theRootNode.greaterSubNode);
				while (true) {
					if (temp.lesserSubNode == null)
						break;
					temp = temp.lesserSubNode;
				}

				// Copy the inorder successor's content to this node

				theRootNode.NodeValue = temp.NodeValue;

				// Delete the inorder successor
				theRootNode.greaterSubNode = DeleteKey (theRootNode.greaterSubNode, temp.NodeValue);
			}
			return theRootNode;
		}

	}


}

