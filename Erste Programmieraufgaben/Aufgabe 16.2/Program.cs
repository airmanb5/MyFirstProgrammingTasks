// 16.2. Jetzt sollen alle Kleinbuchstaben in Grossbuchstaben und umgekehrt verwandelt werden.
class Aufgabe16_2
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
            char invertedLetter;
            if (char.IsUpper(letter))
            {
                invertedLetter = char.ToLower(letter);
            }
            else
            {
                invertedLetter = char.ToUpper(letter);
            }
            sw.Write(invertedLetter);
        }

        sw.Close();
    }
}