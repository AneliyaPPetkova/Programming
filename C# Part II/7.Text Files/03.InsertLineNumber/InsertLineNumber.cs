//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

using System;
using System.IO;

namespace _03.InsertLineNumber
{
    class InsertLineNumber
    {
        static void InsertLine(string fileName, string newTextFile)
        {
            using (StreamWriter streamWriter = new StreamWriter(newTextFile))
            {
                using (StreamReader readFile = new StreamReader(fileName))
                {
                    string line = readFile.ReadLine();
                    int lineNumber = 1;
                    while (line != null)
                    {
                        streamWriter.WriteLine(lineNumber + " " + line);
                        line = readFile.ReadLine();
                        lineNumber++;
                    }
                }
            }
            Console.WriteLine("New file with insert line numbers is created!");
            Console.WriteLine(newTextFile);
        }
        static void Main()
        {
            try
            {
                string filename = "text.txt";
                string newTextFile = "TextWithLineNumbers.txt";
                InsertLine(filename, newTextFile);
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
}
