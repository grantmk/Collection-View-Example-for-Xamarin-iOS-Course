using System;
using UIKit;
using Foundation;
using CoreGraphics;
using System.Collections.Generic;

namespace collectionviewapp
{
	public class CustomCollectionSource: UICollectionViewSource
	{
		public List<string> rows { get; set; }
		
		public CustomCollectionSource (List<string> _rows)
		{
			rows = _rows;
		}

		public override nint NumberOfSections (UICollectionView collectionView)
		{
			return 1;
		}

		public override nint GetItemsCount (UICollectionView collectionView, nint section)
		{
			return rows.Count;
		}

		public override bool ShouldHighlightItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			return true;
		}

		public override void ItemHighlighted (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = (CustomCollectionViewCell)collectionView.CellForItem (indexPath);
			cell.mainLabel.Alpha = 0.5f;
		}

		public override void ItemUnhighlighted (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = (CustomCollectionViewCell)collectionView.CellForItem (indexPath);
			cell.mainLabel.Alpha = 1f;
		}

		public override UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = (CustomCollectionViewCell)collectionView.DequeueReusableCell (CustomCollectionViewCell.CellID, indexPath);
			cell.UpdateCell (rows [indexPath.Row]);

			return cell;
		}
	}
}

