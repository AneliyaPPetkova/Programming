//Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class Concat
{
    static void ConcatTwoFiles(string firstFileName, string secondFileName, string newConcatTextFile)
    {
        using (StreamWriter streamWriter = new StreamWriter(newConcatTextFile))
        {
            using (StreamReader readFirstFile = new StreamReader(firstFileName))
            {
                string line = readFirstFile.ReadLine();
                while (line != null)
                {
                    streamWriter.WriteLine(line);
                    line = readFirstFile.ReadLine();
                }
            }

            using (StreamReader readSecondFile = new StreamReader(secondFileName))
            {
                string line = readSecondFile.ReadLine();
                while (line != null)
                {
                    streamWriter.WriteLine(line);
                    line = readSecondFile.ReadLine();
                }
            }
        }

        Console.WriteLine("The files are copied!");
    }
    static void Main()
    {
        try
        {
            string filename1 = "text1.txt";
            string filename2 = "text2.txt";
            string newConcatTextFile = "concat.txt";
            ConcatTwoFiles(filename1, filename2, newConcatTextFile);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file does not exist!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid!");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("The caller does not have the required permission!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format!");
        }
    }
}

