// 22.2.1. Das gleiche soll auch mit allen Unterverzeichnissen funktionieren.

class Aufgabe22_2_1
{
    static void Main(string[] args)
    {
        if (args.Length == 1)
        {
            SearchAndPrintSubfolders(args[0], 0);
        }
        else if (args.Length == 2)
        {
            string[] files = Directory.GetFiles(args[0]);

            SearchAndCopySubfolders(args[0], args[1]);
        }
        else
        {
            Console.WriteLine("Bitte mind. 1 und max. 2 Parameter angeben.");
        }
    }  

    static void SearchAndPrintSubfolders(string folder, int level)
    {
        string treeSymbol = "└── ";
        string spaceString = string.Empty;

        spaceString = IncreaseSpace(spaceString, level);

        PrintFiles(folder, treeSymbol, spaceString);

        PrintFolders(spaceString, treeSymbol, level, folder);  
    }

    static void PrintFiles(string folder, string treeSymbol, string spaceString)
    {
        foreach (string file in Directory.GetFiles(folder))
        {
            Console.WriteLine(spaceString + treeSymbol + file);
        }
    }

    static string IncreaseSpace(string spaceString, int level)
    {
        for (int i = 0; i <= level; i++)
        {
            spaceString += " ";
        }

        return spaceString;
    }

    static void PrintFolders(string spaceString, string treeSymbol, int level, string folder)
    {
        foreach (string subFolder in Directory.GetDirectories(folder))
        {
            Console.WriteLine(spaceString + treeSymbol + subFolder);
            SearchAndPrintSubfolders(subFolder, level + 1);
        }
    }


    static void SearchAndCopySubfolders(string sourcePath, string targetPath)
    {
        string[] files = Directory.GetFiles(sourcePath);

        foreach (string file in files)
        {
            string destinationFile = Path.Combine(targetPath, Path.GetFileName(file));

            DateTime lastEdited1 = File.GetLastWriteTime(file);
            DateTime lastEdited2 = File.GetLastWriteTime(destinationFile);

            if (!File.Exists(destinationFile) || lastEdited1 > lastEdited2)
            {
                File.Copy(file, destinationFile, true);

                Console.WriteLine("Kopiert: " + destinationFile);
            }
            else
            {
                Console.WriteLine("Nicht kopiert: " + destinationFile);
            }
        }

        foreach (string targetSubFolder in Directory.GetDirectories(sourcePath))
        {
            string sourceSubFolder = Path.Combine(targetPath, Path.GetFileName(targetSubFolder));

            if (!Directory.Exists(sourceSubFolder))
            {
                Directory.CreateDirectory(sourceSubFolder);

                Console.WriteLine("Kopiert: " + sourceSubFolder);
                SearchAndCopySubfolders(targetSubFolder, sourceSubFolder);
            }
            else
            {
                Console.WriteLine("Nicht Kopiert: " + sourceSubFolder);
                SearchAndCopySubfolders(targetSubFolder, sourceSubFolder);
            }
        }
    }
}