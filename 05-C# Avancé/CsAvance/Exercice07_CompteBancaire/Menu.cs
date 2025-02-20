namespace Exercice07_CompteBancaire;

public class Menu(string title, params List<KeyValuePair<string, Action>> actions)
{
    public string Title { get; set; } = title;

    public List<KeyValuePair<string, Action>> Actions { get; set; } = actions;

    public Action? Choose(int choice)
    {
        for (var i = 1; i < Actions.Capacity; i++)
        {
            if (i == choice)
            {
                return Actions[i].Value;
            }
        }
        return null;
    }

    public override string ToString()
    {
        var value = $"===== {Title} =====\n\n";
        var i = 1;
        foreach (var action in Actions)
        {
            value += $"{i}. {action.Key}\n";
            i++;
        }

        value += "Faites votre choix : ";

        return value;
    }
}