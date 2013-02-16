//Write a program that extracts from given XML file all the text without the tags

using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractTextFromXML
{
    static void Find(string fileName)
    {

            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = readFile.ReadLine();
                string pattern = @">(.*?)\<";

                while (line != null)
                {
                    Regex words = new Regex(pattern, RegexOptions.IgnoreCase);
                    MatchCollection result = words.Matches(line);
                    foreach (var c in result)
                    {
                        string pattern2 = @"\b>\b";
                        string edit = Convert.ToString(c);
                        string newLine = Regex.Replace(edit, pattern2, string.Empty);
                        newLine = edit.Replace("<", string.Empty);
                        Console.WriteLine(newLine);
                    }
                    line = readFile.ReadLine();
                }
            }
        }
    static void Main()
    {
        try
        {
            string filename = "text.txt";
            Find(filename);
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

