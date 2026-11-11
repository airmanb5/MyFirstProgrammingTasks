// 22.1. Das erste Verzeichnis soll ins zweite Verzeichnis dazu kopiert werden und das zweite Verzeichnis ins erste, so dass beide das gleiche beinhalten.
class Aufgabe22_1
{
    static void Main(string[] args)
    {
        if (args.Length == 1)
        {
            foreach (string file in Directory.GetFiles(args[0]))
            {
                Console.WriteLine(file);
            }
            foreach (string folder in Directory.GetDirectories(args[0]))
            {
                Console.WriteLine(folder);
            }
        }
        else if (args.Length == 2)
        {
            CopyFiles(args[0], args[1]);
            CopyFolders(args[0], args[1]);
            CopyFiles(args[1], args[0]);
            CopyFolders(args[1], args[0]);
        }
        else
        {
            Console.WriteLine("Bitte mind. 1 und max. 2 Parameter angeben.");
        }
    }

    static void CopyFiles(string source, string destination)
    {
        foreach (string file in Directory.GetFiles(source))
        {
            string destinationFile = Path.Combine(destination, Path.GetFileName(file));

            System.IO.File.Copy(file, destinationFile, true);

            Console.WriteLine("Kopiert: " + Path.GetFileName(file));
        }
    }

    static void CopyFolders(string source, string destination)
    {
        foreach (string folder in Directory.GetDirectories(source))
        {
            string destinationFolder = Path.Combine(destination, Path.GetFileName(folder));

            Directory.CreateDirectory(destinationFolder);

            Console.WriteLine("Kopiert: " + Path.GetFileName(folder));
        }
    }
}
 