using System;

namespace Composite
{
    class Program   //kompozit i spada u strukturne obrazce i koristi se zbog stablaste strukture kakva nam je potrebna za file system
    {
        static void Main(string[] args)
        {
            // Creating files
            File file1 = new File("file1.txt");
            File file2 = new File("file2.txt");
            File file3 = new File("file3.txt");

            // Creating directories
            Directory rootDir = new Directory("Root");
            Directory subDir1 = new Directory("Subdirectory1");
            Directory subDir2 = new Directory("Subdirectory2");

            // Adding files to directories
            rootDir.AddComponent(file1);
            rootDir.AddComponent(subDir1);

            subDir1.AddComponent(file2);
            subDir1.AddComponent(file3);
            subDir1.AddComponent(subDir2);

            // Displaying the file system structure
            rootDir.Display();

            Console.ReadLine();
        }
    }
}
