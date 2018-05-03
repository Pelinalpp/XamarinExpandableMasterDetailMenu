using ExpMenu.Views;
using System;
using Xamarin.Forms;

namespace ExpMenu.Custom
{
    public class CustomTextCell : TextCell
    {
        /// <summary>
        /// The SelectedBackgroundColor property.
        /// </summary>
        public static readonly BindableProperty SelectedBackgroundColorProperty =
            BindableProperty.Create("SelectedBackgroundColor", typeof(Color), typeof(CustomTextCell), Color.Default);

        /// <summary>
        /// Gets or sets the SelectedBackgroundColor.
        /// </summary>
        public Color SelectedBackgroundColor
        {
            get { return (Color)GetValue(SelectedBackgroundColorProperty); }
            set { SetValue(SelectedBackgroundColorProperty, value); }
        }

        public static readonly BindableProperty TargetTypeProperty =
            BindableProperty.Create("TargetType", typeof(Type), typeof(CustomTextCell), typeof(MainPage));

        public Type TargetType
        {
            get { return (Type)GetValue(TargetTypeProperty); }
            set { SetValue(TargetTypeProperty, value); }
        }
    }
}
