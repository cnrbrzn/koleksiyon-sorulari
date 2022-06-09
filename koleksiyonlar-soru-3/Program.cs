string sentence = Console.ReadLine();
List<string> vowels = new List<string>();
foreach(var item in sentence)
{
    switch (item)
    {
        case 'a':
        vowels.Add("a");
        break;
        case 'e':
        vowels.Add("e");
        break;
        case 'ı':
        vowels.Add("ı");
        break;
        case 'i':
        vowels.Add("i");
        break;
        case 'o':
        vowels.Add("o");
        break;
        case 'ö':
        vowels.Add("ö");
        break;
        case 'u':
        vowels.Add("u");
        break;
        case 'ü':
        vowels.Add("ü");
        break;
        case 'A':
        vowels.Add("A");
        break;
        case 'E':
        vowels.Add("E");
        break;
        case 'I':
        vowels.Add("I");
        break;
        case 'İ':
        vowels.Add("İ");
        break;
        case 'O':
        vowels.Add("O");
        break;
        case 'Ö':
        vowels.Add("Ö");
        break;
        case 'U':
        vowels.Add("U");
        break;
        case 'Ü':
        vowels.Add("Ü");
        break;
        default:
        break;
    }
}
vowels.Sort();