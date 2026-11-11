// 16.1. Jetzt sollen alles in Grossbuchstaben verwandelt werden
class Aufgabe16_1
{
    static void Main()
    {
        string originalFile = "text.txt";
        string changedFile = "newText.txt";
        string text;

        StreamReader sr = new(originalFile);
        text = sr.ReadToEnd();
        sr.Close();
        string uppercaseText = text.ToUpper();

        using StreamWriter sw = new(changedFile);
        sw.Write(uppercaseText);
        sw.Close();
    }
}