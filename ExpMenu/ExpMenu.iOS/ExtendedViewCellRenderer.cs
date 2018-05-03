using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using ExpMenu.iOS;
using ExpMenu.Custom;

[assembly:ExportRenderer(typeof(ExtendedViewCell), typeof(ExtendedViewCellRenderer))]
namespace ExpMenu.iOS
{
    public class ExtendedViewCellRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            var view = item as ExtendedViewCell;

            //cell.Hidden = view.IsVisible;
            //view.IsEnabled = view.IsVisible;

            cell.BackgroundColor = view.SelectedBackgroundColor.ToUIColor();
            //cell.TextLabel.TextColor = UIColor.White;
            // Disable native cell selection color style
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;

            return cell;
        }

    }
}
