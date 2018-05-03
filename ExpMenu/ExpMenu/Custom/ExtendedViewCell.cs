using Xamarin.Forms;

namespace ExpMenu.Custom
{
    public class ExtendedViewCell : ViewCell
    {
        public static BindableProperty IsVisibleProperty = BindableProperty.Create("IsVisible", typeof(bool), typeof(ExtendedViewCell), true);

        public bool IsVisible
        {
            get { return (bool)GetValue(IsVisibleProperty); }
            set { SetValue(IsVisibleProperty, value); }
        }

        public static readonly BindableProperty SelectedBackgroundColorProperty =
            BindableProperty.Create("SelectedBackgroundColor",
                                    typeof(Color),
                                    typeof(ExtendedViewCell),
                                    Color.Default);

        public Color SelectedBackgroundColor
        {
            get { return (Color)GetValue(SelectedBackgroundColorProperty); }
            set { SetValue(SelectedBackgroundColorProperty, value); }
        }
    }
}
