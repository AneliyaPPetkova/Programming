//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class PrintOddLines
{
    static void ReadOddLines(string fileName)
    {
        StreamReader reader = new StreamReader(fileName);
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if ((lineNumber % 2) != 0)
                {
                Console.WriteLine("Line {0}: {1}", lineNumber, line);                    
                }
                line = reader.ReadLine();
            }
        }
    }

    static void Main()
    {
        try
        {
            string filename = "PrintOddLines.txt";
            ReadOddLines(filename);
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

