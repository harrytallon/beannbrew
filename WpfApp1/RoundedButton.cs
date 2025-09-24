using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public class RoundedButton : Button
    {
        public static readonly DependencyProperty CornerProperty =
            DependencyProperty.Register(nameof(Corner), typeof(CornerRadius), typeof(RoundedButton), new PropertyMetadata(new CornerRadius(0)));

        public CornerRadius Corner
        {
            get => (CornerRadius)GetValue(CornerProperty);
            set => SetValue(CornerProperty, value);
        }

        static RoundedButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RoundedButton), new FrameworkPropertyMetadata(typeof(RoundedButton)));
        }
    }
}
