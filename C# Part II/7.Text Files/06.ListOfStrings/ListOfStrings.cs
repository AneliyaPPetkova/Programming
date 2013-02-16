//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
//	Ivan			George
//	Peter			Ivan
//	Maria			Maria
//	George			Peter

using System;
using System.Collections.Generic;
using System.IO;

class ListOfStrings
{
    static void readMatrix(string fileName, string newTextFile)
    {
        using (StreamWriter streamWriter = new StreamWriter(newTextFile))
        {
            using (StreamReader readFile = new StreamReader(fileName))
            {
                List<string> listOfStrings = new List<string>();
                string line = readFile.ReadLine();
                while (line != null)
                {
                    listOfStrings.Add(line);
                    line = readFile.ReadLine();
                }
                List<string> sorted = sortedAlphabetically(listOfStrings);
                for (int i = 0; i < sorted.Count; i++)
                {
                    streamWriter.WriteLine(sorted[i]);
                }
            }
        }
    }
    static List<string> sortedAlphabetically(List<string> names)
    {
        names.Sort();
        return names;
    }
    static void Main()
    {
        try
        {
            string filename = "list.txt";
            string newTextFile = "sortedList.txt";
            readMatrix(filename, newTextFile);
            Console.WriteLine("The new file is ready!");
            Console.WriteLine("Good bye!");

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

