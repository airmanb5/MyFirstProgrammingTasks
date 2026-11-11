class TestFilesAndDirectories
{
    static void Main()
    {
        Paths();
    }

    static void FileAndFileInfo()
    {
        string path = @"c:\somefile.jpg";

        File.Copy(@"C:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
        File.Delete(path);
        if (File.Exists(path))
        {

        }
        string content = File.ReadAllText(path);

        var fileInfo = new FileInfo(path);
        fileInfo.CopyTo("...");
        fileInfo.Delete();
        if (fileInfo.Exists)
        {
            //
        }
    }

    static void DirectoryAndDirectoryInfo()
    {
        Directory.CreateDirectory(@"C:\temp\folder1");

        var files = Directory.GetFiles(@"C:\projects\CSharpFundamentals", "*.sln", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"C:\projects\CSharpFundamentals", "*,*", SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }

    static void Paths()
    {
        var path = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

        var dotIndex = path.IndexOf('.');
        var extension = path.Substring(dotIndex);

        Console.WriteLine("Extension: " + Path.GetExtension(path));
        Console.WriteLine("File Name:" + Path.GetFileName(path));
        Console.WriteLine("File Name without extension:" + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
    }
}