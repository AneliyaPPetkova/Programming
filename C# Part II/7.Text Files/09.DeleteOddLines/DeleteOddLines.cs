//Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;

class DeleteOddLines
{
    static void Delete(string oldFile, string newFile)
    {
        using (StreamReader reader = new StreamReader(oldFile))
        {
            using (StreamWriter streamWriter = new StreamWriter(newFile))
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if ((lineNumber % 2) == 0)
                    {
                        streamWriter.WriteLine(line);
                    }
                    line = reader.ReadLine();
                }
            }
        }
        File.Delete(oldFile);
        File.Move(newFile, oldFile);
    }
    static void Main()
    {
        try
        {
            string filename = "DeleteOddLines.txt";
            string newFile = "Temp.txt";

            Delete(filename, newFile);
            Console.WriteLine("All odd lines are deleted!");
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

