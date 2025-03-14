using Android.OS;

namespace ExColor
{
    public partial class MainPage : ContentPage
    {
        private Color _color;

        private int _red = 255;
        private int _green = 255;
        private int _blue = 255;

        public MainPage()
        {
            InitializeComponent();

            _color = Color.FromRgb(_red, _green, _blue);

            ChangeValues();
        }

        private void RedSlider_OnValueChanged(object? sender, ValueChangedEventArgs e)
        {
            _red = (int) e.NewValue;
            _color = Color.FromRgb(_red, _green, _blue);

            ChangeValues();
        }

        private void GreenSlider_OnValueChanged(object? sender, ValueChangedEventArgs e)
        {
            _green = (int) e.NewValue;
            _color = Color.FromRgb(_red, _green, _blue);

            ChangeValues();
        }

        private void BlueSlider_OnValueChanged(object? sender, ValueChangedEventArgs e)
        {
            _blue = (int) e.NewValue;
            _color = Color.FromRgb(_red, _green, _blue);

            ChangeValues();
        }

        private void Button_OnClicked(object? sender, EventArgs e)
        {
            var rdm = new Random();

            _red = rdm.Next(256);
            _green = rdm.Next(256);
            _blue = rdm.Next(256);

            RedSlider.Value = _red;
            GreenSlider.Value = _green;
            BlueSlider.Value = _blue;

            _color = Color.FromRgb(_red, _green, _blue);

            ChangeValues();
        }

        private void ChangeValues()
        {
            Page.BackgroundColor = _color;
            DisplayColorLabel.Text = $"Couleur: {_color.ToHex()}";
            RectangleColor.Fill = _color;
        }
    }

}
