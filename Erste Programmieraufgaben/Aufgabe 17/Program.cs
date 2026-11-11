// 17. Erstelle ein Programm, das einen Text aus einer Datei einliest, alle, durch . ersetzt und in einer anderen Datei wieder ausgibt.
class Aufgabe17
{
    static void Main()
    {
        string originalFile = "text.txt";
        string changedFile = "newText.txt";
        string text;

        StreamReader sr = new(originalFile);
        text = sr.ReadToEnd();
        sr.Close();

        using StreamWriter sw = new(changedFile);

        foreach (char letter in text)
        {
            if (letter == ',')
            {
                sw.Write('.');
            }
            else
            {
                sw.Write(letter);
            }
        }
        sw.Close();
    }
}