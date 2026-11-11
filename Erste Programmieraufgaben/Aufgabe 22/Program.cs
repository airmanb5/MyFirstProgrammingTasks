/* 22. Das Programm wird via Commandline Parameter gesteuert.
Wenn nur ein Parameter eingegeben wird, dann soll der Inhalt des Verzeichnisses, ausgegeben werden.
Wenn zwei Parameter eingegeben werden, so soll der Inhalt vom ersten Verzeichnis in das zweite Verzeichnis hineinkopiert werden.*/

using static System.Net.WebRequestMethods;

class Aufgabe22
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
            string[] files = Directory.GetFiles(args[0]);
            string[] folders = Directory.GetDirectories(args[0]);

            foreach(string folder in folders)
            {
                string destinationFolder = Path.Combine(args[1], Path.GetFileName(folder));
                System.IO.Directory.CreateDirectory(destinationFolder);

                Console.WriteLine("Kopiert: " + Path.GetFileName(folder));
            }
            
            foreach (string file in files)
            {
                string destinationFile = Path.Combine(args[1], Path.GetFileName(file));

                System.IO.File.Copy(file, destinationFile, true);

                Console.WriteLine("Kopiert: " + Path.GetFileName(file));
            }
        }
        else
        {
            Console.WriteLine("Bitte mind. 1 und max. 2 Parameter angeben.");
        }
    }
}

