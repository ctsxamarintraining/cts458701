using System;
using UIKit;
namespace BST
{
	public class NodeView : UILabel
	{

		public int NodeValue;
		public float positionX;
		public float positionY;
		public int levelindex;

		public float mySpace;
		public NodeView ()
		{
		}
		public NodeView (int parentX,int parentY,int space)
		{
			mySpace = space * 0.5f ;
			positionX = parentX - mySpace;
			positionY = parentY + 30;
		}
	}
}

