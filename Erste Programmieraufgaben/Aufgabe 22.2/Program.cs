// 22.2. Alle  Dateien aus dem ersten Verzeichnis sollen in das zweite kopiert werden. Aber es sollen nur Dateien kopiert werden, die im zweiten Verzeichnis nicht vorhanden sind, oder die dort ein älteres Datum haben.

class Aufgabe22_2
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

            foreach (string file in files)
            {
                string destinationFile = Path.Combine(args[1], Path.GetFileName(file));

                DateTime lastEdited1 = File.GetLastWriteTime(file);
                DateTime lastEdited2 = File.GetLastWriteTime(destinationFile);

                if (!File.Exists(destinationFile) || lastEdited1 > lastEdited2)
                {
                     System.IO.File.Copy(file, destinationFile, true);

                    Console.WriteLine($"Kopiert: {file}");
                }
                else
                {
                    Console.WriteLine($"Nicht kopiert: {file}");
                }  
            }
            foreach (string folder in folders)
            {
                string destinationFolder = Path.Combine(args[1], Path.GetFileName(folder));

                DateTime lastEdited1 = Directory.GetLastWriteTime(folder);
                DateTime lastEdited2 = Directory.GetLastWriteTime(destinationFolder);

                if (!Directory.Exists(destinationFolder) || lastEdited1 > lastEdited2)
                {
                    Directory.CreateDirectory(destinationFolder);

                    Console.WriteLine($"Kopiert: {folder}" );
                }
                else
                {
                    Console.WriteLine($"Nicht kopiert: {folder}");
                }
            }
        }
        else
        {
            Console.WriteLine("Bitte mind. 1 und max. 2 Parameter angeben.");
        }
    }
}