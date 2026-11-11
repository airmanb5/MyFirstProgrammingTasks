// 21.1. Das programm soll auch alle Ordner und Files aus den darunter liegenden Ordnern ausgeben.

class Aufgabe21_1
{
    static void Main()
    {
        string folderOfOrigin = "C:\\FilesForTesting";

        SearchSubfolders(folderOfOrigin, 0);
    }

    static void SearchSubfolders(string folder, int level)
    {
        string spaceString = "└── ";
        string spaceString1 = string.Empty;
        
        for(int i = 0; i <= level; i++)
        {
            spaceString1 += " ";
        }
        
        foreach (string file in Directory.GetFiles(folder))
        {
            Console.WriteLine(spaceString + file);
        }

        foreach (string subFolder in Directory.GetDirectories(folder))
        {
            Console.WriteLine(spaceString1 + spaceString + subFolder);
            SearchSubfolders(subFolder, level + 1);
        }
    }
}