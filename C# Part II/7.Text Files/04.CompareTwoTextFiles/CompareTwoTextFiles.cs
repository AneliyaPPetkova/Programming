//Write a program that compares two text files line by line and prints the number of 
//lines that are the same and the number of lines that are different. 
//Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTwoTextFiles
{
    static void ConcatTwoFiles(string firstFileName, string secondFileName)
    {
        int sameLines = 0;
        int differentLines = 0;
            using (StreamReader readFirstFile = new StreamReader(firstFileName))
            {
                using (StreamReader readSecondFile = new StreamReader(secondFileName))
                {
                    string lineFirstFile = readFirstFile.ReadLine();
                    string lineSecondFile = readSecondFile.ReadLine();
                    while (lineFirstFile != null && lineSecondFile != null)
                    {
                        if (lineFirstFile == lineSecondFile)
	                    {
		                    sameLines++;
	                    }
                        else
	                    {
                            differentLines++;
	                    }
                        lineFirstFile = readFirstFile.ReadLine();
                        lineSecondFile = readSecondFile.ReadLine();
                    }
                }
            }
            Console.WriteLine("The number of lines that are the same: {0}", sameLines);
            Console.WriteLine("The number of lines that are different: {0}", differentLines);  
    }
    static void Main()
    {
        try
        {
            string filename1 = "text1.txt";
            string filename2 = "text2.txt";
            ConcatTwoFiles(filename1, filename2);
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

