using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MolopolyGame
{
    class  savaData
    {
        public static void savedata(){
            bool fileExists = false;
            string thePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string theFile = thePath + @"\testfile.txt";

            fileExists = File.Exists(theFile);

            if (fileExists)
            {
                Console.WriteLine("The file exists");
            }
            else
            {
                Console.WriteLine("The file does not exist, creating it");
                File.Create(theFile);
            }

            if (fileExists)
            {
                Console.WriteLine("It was created on {0}", File.GetCreationTime(theFile));
                Console.WriteLine("It was last accessed on {0}", File.GetLastAccessTime(theFile));

                Console.WriteLine("Moving the file...");
                File.Move(theFile, thePath + @"\newfile.txt");
            }
            /*
             * Existing Directories

            string thePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Check to see if a directory exists
            bool dirExists = Directory.Exists(thePath);
            if (dirExists)
                Console.WriteLine("The directory exists.");
            else
                Console.WriteLine("The directory does not exist.");
            Console.WriteLine();

            // Write out the names of the files in the directory
            string[] files = Directory.GetFiles(thePath);
            foreach (string s in files)
            {
                Console.WriteLine("Found file: " + s);
            }
            Console.WriteLine();

            // Get information about each fixed disk drive
            Console.WriteLine("Drive Information:");
            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                if (d.DriveType == DriveType.Fixed)
                {
                    Console.WriteLine("Drive Name: {0}", d.Name);
                    Console.WriteLine("Free Space: {0}", d.TotalFreeSpace);
                    Console.WriteLine("Drive Type: {0}", d.DriveType);
                    Console.WriteLine();
                }
            }
             * */

            /*
             * Reading and Writing Files

            // create a path to the My Documents folder and the file name
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                                Path.DirectorySeparatorChar + "examplefile.txt";

            // if the file doesn't exist, create it by using WriteAllText
            if (!File.Exists(filePath))
            {
                string content = "This is a text file." + Environment.NewLine;
                Console.WriteLine("Creating the file...");
                File.WriteAllText(filePath, content);
            }

            // Use the AppendAllText method to add text to the content
            string addedText = "Text added to the file" + Environment.NewLine;
            Console.WriteLine("Adding content to the file...");
            File.AppendAllText(filePath, addedText);
            Console.WriteLine();

            // Read the contents of the file
            Console.WriteLine("The current contents of the file are:");
            Console.WriteLine("-------------------------------------");

            // Read the contents of the file using ReadAllText
            string currentContent = File.ReadAllText(filePath);
            Console.Write(currentContent);
            Console.WriteLine();

            // Read the contents of the file using ReadAllLines
            /*
            string[] contents = File.ReadAllLines(filePath);
            foreach (string s in contents)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            */
            
        }
        
    }
}
