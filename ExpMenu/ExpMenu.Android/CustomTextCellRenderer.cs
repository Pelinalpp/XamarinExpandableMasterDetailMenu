using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using System.ComponentModel;

using ExpMenu.Custom;
using ExpMenu.Droid;

[assembly: ExportRenderer(typeof(CustomTextCell), typeof(CustomTextCellRenderer))]
namespace ExpMenu.Droid
{
    public class CustomTextCellRenderer : TextCellRenderer
    {
        private Android.Views.View cellCore;
        private Drawable unselectedBackground;
        private bool selected;

        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            cellCore = base.GetCellCore(item, convertView, parent, context);

            // Save original background to rollback to it when not selected,
            // We assume that no cells will be selected on creation.
            selected = false;
            unselectedBackground = cellCore.Background;

            return cellCore;
        }

        protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnCellPropertyChanged(sender, args);

            if (args.PropertyName == "IsSelected")
            {
                // I had to create a property to track the selection because cellCore.Selected is always false.
                // Toggle selection
                selected = !selected;

                if (selected)
                {
                    var customTextCell = sender as CustomTextCell;
                    cellCore.SetBackgroundColor(customTextCell.SelectedBackgroundColor.ToAndroid());
                }
                else
                {
                    cellCore.SetBackground(unselectedBackground);
                }
            }
        }
    }
}