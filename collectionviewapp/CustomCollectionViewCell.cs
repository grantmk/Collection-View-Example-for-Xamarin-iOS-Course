using System;
using UIKit;
using Foundation;
using CoreGraphics;

namespace collectionviewapp
{
	public class CustomCollectionViewCell: UICollectionViewCell
	{
		public UILabel mainLabel, subLabel;
		public static NSString CellID = new NSString("customCollectionCell");

		[Export ("initWithFrame:")]
		public CustomCollectionViewCell (CGRect frame) : base(frame)
		{
			BackgroundView = new UIView { BackgroundColor = UIColor.Orange };

			ContentView.Layer.BorderColor = UIColor.Blue.CGColor;
			ContentView.Layer.BorderWidth = 4.0f;
			ContentView.BackgroundColor = UIColor.White;

			mainLabel = new UILabel ();
			subLabel = new UILabel ();

			ContentView.AddSubviews (new UIView[] { mainLabel, subLabel });
		}

		public void UpdateCell (string text) {
			mainLabel.Text = text;
			subLabel.Text = text;
			mainLabel.Frame = new CGRect (5, 5, ContentView.Bounds.Width, 26);
			subLabel.Frame = new CGRect (5, 35, ContentView.Bounds.Width, 26);
		}
	}
}

