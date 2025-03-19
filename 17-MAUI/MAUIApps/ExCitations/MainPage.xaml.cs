namespace ExCitations
{
	public partial class MainPage : ContentPage
	{
		private List<string> Quotes = [];


		public MainPage()
		{
			InitializeComponent();

		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			await LoadMauiAsset();

			var rdm = new Random();

			QuoteLabel.Text = Quotes[rdm.Next(Quotes.Count)];
		}

		async Task LoadMauiAsset()
		{
			// On charge l'élément sous forme de flux binaire
			await using var stream = await FileSystem.OpenAppPackageFileAsync("quotes.txt");
			using var reader = new StreamReader(stream);

			// On regarde si on est en fin de fichier ou pas (s'il y a encore des données à lire)
			while (reader.Peek() >= 0)
			{
				// Pour chaque ligne, on va ajouter le texte à notre Set de chaines de caractères
				var lineToAdd = await reader.ReadLineAsync();
				if (!string.IsNullOrEmpty(lineToAdd)) Quotes.Add(lineToAdd);
			}
		}

		private void Button_OnClicked(object? sender, EventArgs e)
		{
			var rdm = new Random();

			QuoteLabel.Text = Quotes[rdm.Next(Quotes.Count)];

			GradientStop1.Color = Color.FromRgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
			GradientStop2.Color = Color.FromRgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
		}
	}

}
