using System;
using CoreGraphics;
using UIKit;
using Foundation;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
namespace BST
{
	public partial class ViewController : UIViewController
	{
		public CGSize sizeOftheLabels{ get; set; }
		public CGSize LabelSpace{ get; set; }
		public UIScrollView myScroll{get;set;}
		public CGPoint myPos{ get; set; }
		//public List<int> myNodalArray{ get; set; }
		public BinarySearchTree myNodalArray{get;set;}
		public UILabel myLab{ get; set; }
		public int tempLabelCount{ get; set; }

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			tempLabelCount = 0;
			sizeOftheLabels = new CGSize (25, 25);
			LabelSpace = new CGSize (25,35);
			myNodalArray = new BinarySearchTree();
			lbl1.Layer.MasksToBounds = true;
			lbl1.Layer.CornerRadius = 5.0f;
			lbl1.UserInteractionEnabled = true;
			lbl2.Layer.MasksToBounds = true;
			lbl2.Layer.CornerRadius = 5.0f;

			lbl3.Layer.MasksToBounds = true;
			lbl3.Layer.CornerRadius = 5.0f;

			lbl4.Layer.MasksToBounds = true;
			lbl4.Layer.CornerRadius = 5.0f;

			lbl5.Layer.MasksToBounds = true;
			lbl5.Layer.CornerRadius = 5.0f;
			myScroll = new UIScrollView (MyNodalView.Frame);
			myScroll.ContentSize = new CGSize (LabelSpace.Width * (Math.Pow (2, myNodalArray.level)),myNodalArray.level * LabelSpace.Height);
			MyNodalView.Add (myScroll);
			GenButton.TouchUpInside += GenButton_TouchUpInside;

			CreateTree.TouchUpInside += CreateTree_TouchUpInside;
		}

		void CreateTree_TouchUpInside (object sender, EventArgs e)
		{
			print (myNodalArray.root, myScroll.Frame.Width * 0.5, 20);
		
		}
		void print(Node root, double x1, double y1)
		{

			if (root != null) {

				UILabel myLabels = new UILabel (new CGRect (x1,y1,25,25));
				myLabels.Text = root.NodeValue.ToString ();
				myScroll.Add (myLabels);

//				print (root.lesserSubNode, x1 - (25*Math.Pow(2,myNodalArray.level-(root.levelindex+1))), y1 + 50);
//				print (root.greaterSubNode, x1 + (25*Math.Pow(2,myNodalArray.level-(root.levelindex+1))), y1 + 50);
//
//

				print (root.lesserSubNode, x1 - (25*Math.Pow(2,myNodalArray.level-(root.levelindex+1))), y1 + 50);
			
				print (root.greaterSubNode, x1 + (25*Math.Pow(2,myNodalArray.level-(root.levelindex+1))), y1 + 50);

			}

		}


		void GenButton_TouchUpInside (object sender, EventArgs e)
		{
			var rndm = new System.Random ();
			int[] rndArray = new int[10];
			for (int i = 1; i <= 5; i++) {
				rndArray [i] = rndm.Next (1, 100);
			}

			lbl1.Text = rndArray [1].ToString ();
			lbl2.Text = rndArray [2].ToString ();
			lbl3.Text = rndArray [3].ToString ();
			lbl4.Text = rndArray [4].ToString ();
			lbl5.Text = rndArray [5].ToString ();
			lbl1.UserInteractionEnabled = false;

		}



		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
		//
		public override void TouchesBegan (Foundation.NSSet touches, UIEvent evt)
		{
			base.TouchesBegan (touches, evt);
			UITouch touch1 = evt.AllTouches.AnyObject as UITouch;
			CGPoint point = touch1.LocationInView (View);
		
			if (point.X > lbl1.Frame.X && point.X < lbl1.Frame.X + lbl1.Frame.Size.Width && point.Y > lbl1.Frame.Y && point.Y < lbl1.Frame.Y + lbl1.Frame.Size.Height) {

				myLab = lbl1;
			}
			if (point.X > lbl2.Frame.X && point.X < lbl2.Frame.X + lbl2.Frame.Size.Width && point.Y > lbl2.Frame.Y && point.Y < lbl2.Frame.Y + lbl2.Frame.Size.Height) {

				myLab = lbl2;
			}
			if (point.X > lbl3.Frame.X && point.X < lbl3.Frame.X + lbl3.Frame.Size.Width && point.Y > lbl3.Frame.Y && point.Y < lbl3.Frame.Y + lbl3.Frame.Size.Height) {

				myLab = lbl3;
			}
			if (point.X > lbl4.Frame.X && point.X < lbl4.Frame.X + lbl4.Frame.Size.Width && point.Y > lbl4.Frame.Y && point.Y < lbl4.Frame.Y + lbl4.Frame.Size.Height) {

				myLab = lbl4;
			}
			if (point.X > lbl5.Frame.X && point.X < lbl5.Frame.X + lbl5.Frame.Size.Width && point.Y > lbl5.Frame.Y && point.Y < lbl5.Frame.Y + lbl5.Frame.Size.Height) {

				myLab = lbl5;
			}

		
		
		
		
		}

		public override void TouchesMoved (Foundation.NSSet touches, UIEvent evt)
		{
			base.TouchesMoved (touches, evt);
			UITouch touch1 = evt.AllTouches.AnyObject as UITouch;		
			CGPoint point = touch1.LocationInView (View);
			if (myLab == lbl1) {
				myPos = point;
				lbl1.Center = myPos;
			}
			if (myLab == lbl2) {
				myPos = point;
				lbl2.Center = myPos;
			}
			if (myLab == lbl3) {
				myPos = point;
				lbl3.Center = myPos;
			}
			if (myLab == lbl4) {
				myPos = point;
				lbl4.Center = myPos;
			}
			if (myLab == lbl5) {
				myPos = point;
				lbl5.Center = myPos;
			}



		}

		public override void TouchesEnded (NSSet touches, UIEvent evt)
		{

			base.TouchesEnded (touches, evt);

			if (myLab == lbl1) {
			//	View.WillRemoveSubview (lbl1);
				//MyNodalView.Add (lbl1);

				if (lbl1.Frame.X > MyNodalView.Frame.X && lbl1.Frame.X < MyNodalView.Frame.X + MyNodalView.Frame.Width &&

					lbl1.Frame.Y > MyNodalView.Frame.Y && lbl1.Frame.Y < lbl1.Frame.Y + lbl1.Frame.Height) {

						int myInt = Int32.Parse (lbl1.Text.ToString());
					myNodalArray.Add (myInt);
	

				}

			}
			if (myLab == lbl2) {
				//	View.WillRemoveSubview (lbl1);
				//MyNodalView.Add (lbl1);

				if (lbl2.Frame.X > MyNodalView.Frame.X && lbl2.Frame.X < MyNodalView.Frame.X + MyNodalView.Frame.Width &&

					lbl2.Frame.Y > MyNodalView.Frame.Y && lbl2.Frame.Y <lbl2.Frame.Y + lbl1.Frame.Height) {

					int myInt = Int32.Parse (lbl1.Text.ToString());
					myNodalArray.Add (myInt);


				}

			}
			if (myLab == lbl3) {
				//	View.WillRemoveSubview (lbl1);
				//MyNodalView.Add (lbl1);

				if (lbl3.Frame.X > MyNodalView.Frame.X && lbl3.Frame.X < MyNodalView.Frame.X + MyNodalView.Frame.Width &&

					lbl3.Frame.Y > MyNodalView.Frame.Y && lbl3.Frame.Y <lbl1.Frame.Y + lbl3.Frame.Height) {

					int myInt = Int32.Parse (lbl1.Text.ToString());
					myNodalArray.Add (myInt);


				}

			}
			if (myLab == lbl4) {
				//	View.WillRemoveSubview (lbl1);
				//MyNodalView.Add (lbl1);

				if (lbl4.Frame.X > MyNodalView.Frame.X && lbl4.Frame.X < MyNodalView.Frame.X + MyNodalView.Frame.Width &&

					lbl4.Frame.Y > MyNodalView.Frame.Y && lbl4.Frame.Y <lbl4.Frame.Y + lbl1.Frame.Height) {

					int myInt = Int32.Parse (lbl1.Text.ToString());
					myNodalArray.Add (myInt);


				}

			}
			if (myLab == lbl5) {
				//	View.WillRemoveSubview (lbl1);
				//MyNodalView.Add (lbl1);

				if (lbl5.Frame.X > MyNodalView.Frame.X && lbl5.Frame.X < MyNodalView.Frame.X + MyNodalView.Frame.Width &&

					lbl5.Frame.Y > MyNodalView.Frame.Y &&lbl5.Frame.Y < lbl5.Frame.Y + lbl1.Frame.Height) {

					int myInt = Int32.Parse (lbl1.Text.ToString());
					myNodalArray.Add (myInt);


				}

			}

			myLab = null;

		}
	}
}

