using System.Diagnostics;
using ExPendu.Models;
using ExPendu.ViewModels;
using Microsoft.Maui.Controls;

namespace ExPendu
{
	public partial class MainPage : ContentPage
	{
		private Hangman _hangman;

		private string _findingWord = "";


		public MainPage()
		{
			InitializeComponent();
			BindingContext = new BindingKeyboardViewModel();
		}

		protected override void OnAppearing()
		{
			var words = new List<string> { "CHAT", "CHIEN", "MAISON", "VOITURE", "POMME", "TABLE", "CHAISE" };

			var random = new Random();
			var randomWord = words[random.Next(words.Count)];

			_hangman = new Hangman() { Word = randomWord };

			for (var i = 0; i < randomWord.Length; i++)
			{
				_findingWord += "_";
			}

			WordLabel.Text = _findingWord;
		}

		private void btnLetter_Clicked(object sender, EventArgs e)
		{
			if (sender is not Button button) return;
			var letter = Convert.ToChar(button.Text);

			button.BackgroundColor = Color.Parse("grey");

			if (!_hangman.Word.Contains(letter))
			{
				_hangman.NbMistakes++;
				MistakesLabel.Text = $"Nombre d'erreurs: {_hangman.NbMistakes}/7";
				HangmanImage.Source = $"hangman_0{_hangman.NbMistakes}.png";

				if (_hangman.NbMistakes != 7) return;
				WinLoseLabel.Text = "Perdu !";

				return;
			}

			var newFindingWord = "";
			var i = 0;
			foreach (var t in _hangman.Word)
			{
				newFindingWord += t == letter ? t : _findingWord[i];
				i++;
			}

			_findingWord = newFindingWord;
			WordLabel.Text = _findingWord;
			if (!_findingWord.Contains('_')) WinLoseLabel.Text = "Gagné !";
		}

	}

}
