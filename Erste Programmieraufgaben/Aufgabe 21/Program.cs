// 21. Schreibe ein Programm, das alle Files und Ordner aus einem vorgegebenen Ordner auf der Console ausgibt

class Aufgabe21
{
    static void Main()
    {
        string folderOfOrigin = "C:\\FilesForTesting";
        
        List<string> files = new List<string>();

        foreach (string folder in Directory.GetDirectories(folderOfOrigin))
        { 
            files.Add(Path.GetFileName(folder));
        }

        foreach (string file in Directory.GetFiles(folderOfOrigin))
        {
            files.Add(Path.GetFileName(file));
        }

        files.Sort();

        foreach (string file in files)
        {
            Console.WriteLine(file);
        }
    }
}
