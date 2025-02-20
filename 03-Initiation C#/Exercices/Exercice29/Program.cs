var alphabet = new int[26];

for (int i = 0; i < 26; i++) 
    alphabet[i] = 65 + i;

for (var i = 0; i < alphabet.Length; i++)
{
    for (var j = 0; j < i; j++) 
        Console.Write(" ");
    
    Console.WriteLine(Convert.ToChar(alphabet[i]));
}