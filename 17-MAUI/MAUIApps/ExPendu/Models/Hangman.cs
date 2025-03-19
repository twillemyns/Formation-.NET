namespace ExPendu.Models;

public class Hangman
{
	public string Word { get; set; } = null!;

	public int NbMistakes { get; set; } = 0;
}