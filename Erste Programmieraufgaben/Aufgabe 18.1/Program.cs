// 
class Aufgabe18_1
{
    static void Main()
    {
        string originalFile = "text.txt";
        string textFromFile;
        
        Console.Write("Welchen Text möchtest du ersetzen?");
        string textToBeReplaced = Console.ReadLine();

        Console.Write("Durch was soll der Text ersetzt werden?");
        string textReplacement = Console.ReadLine();

        StreamReader sr = new(originalFile);
        textFromFile = sr.ReadToEnd();
        sr.Close();

        textFromFile = textFromFile.ToLower();

        string replacedText = textFromFile.Replace(textToBeReplaced, textReplacement);
    }
}
