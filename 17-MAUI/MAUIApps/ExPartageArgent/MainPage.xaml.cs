namespace ExPartageArgent
{
	public partial class MainPage : ContentPage
	{
		private double _bill = 0;
		private double _tip = 0;
		private int _nbPerson = 1;

		private double _personalbill => _total / _nbPerson;
		private double _total => _bill + _tip * _bill;

		public MainPage()
		{
			InitializeComponent();

			PersonalPriceDisplay.Text = "0 €";
			TotalPriceDisplay.Text = "0 €";
			TipDisplay.Text = "0 €";
			TipSliderLabel.Text = "Pourboire (0%)";
			NbPersonLabel.Text = "1";
		}

		private void BillEntry_TextChanged(object? sender, TextChangedEventArgs e)
		{
			double.TryParse(e.NewTextValue, out _bill);
			UpdateValues();
		}

		private void Button10_OnClicked(object? sender, EventArgs e)
		{
			_tip = 0.1;
			UpdateValues();
		}
		private void Button15_OnClicked(object? sender, EventArgs e)
		{
			_tip = 0.15;
			UpdateValues();
		}

		private void Button20_OnClicked(object? sender, EventArgs e)
		{
			_tip = 0.2;
			UpdateValues();
		}

		private void TipSlider_OnValueChanged(object? sender, ValueChangedEventArgs e)
		{
			_tip = e.NewValue / 100;
			UpdateValues();
		}

		private void MinusButton_OnClicked(object? sender, EventArgs e)
		{
			if (_nbPerson == 1) return;
			_nbPerson--;
			UpdateValues();
		}

		private void PlusButton_OnClicked(object? sender, EventArgs e)
		{
			_nbPerson++;
			UpdateValues();
		}

		private void UpdateValues()
		{
			PersonalPriceDisplay.Text = $"{_personalbill:N2} €";
			TotalPriceDisplay.Text = $"{_total:N2} €";
			TipDisplay.Text = $"{(_tip * _bill):N2} €";
			TipSliderLabel.Text = $"Pourboire ({(_tip * 100):N2}%)";
			NbPersonLabel.Text = $"{_nbPerson}";
		}
	}

}
