﻿//Write a program that replaces all occurrences of the substring "start" 
//with the substring "finish" in a text file. 
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceStartWithFinish
{
    static void Replace(string fileName, string newTextFile)
    {
        using (StreamWriter streamWriter = new StreamWriter(newTextFile))
        {
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = readFile.ReadLine();
                string newLine;
                while (line != null)
                {
                    newLine = line.Replace("start", "finish");
                    streamWriter.WriteLine(newLine);
                    line = readFile.ReadLine();
                }
            }
        }
        Console.WriteLine("New file with replaced occurrences of the substring start is created!");
    }
    static void Main()
    {
        try
        {
            string filename = "text.txt";
            string newTextFile = "replaced.txt";
            Replace(filename, newTextFile);
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


