//16. Erstellen Sie ein Programm, das einen Text aus einer Datei einliest und in einer anderen Datei ausgibt, wobei alles in Kleinbuchstaben verwandelt werden soll.
using System.Threading.Channels;

class Aufgabe16
{
    static void Main()
    {
        string originalFile = "text.txt";
        string changedFile = "newText.txt";
        string text;

        StreamReader sr = new(originalFile);
        text = sr.ReadToEnd();
        sr.Close();
        string lowercaseText = text.ToLower();
        
        using StreamWriter sw = new(changedFile);
        sw.Write(lowercaseText);
        sw.Close();
    }
}
