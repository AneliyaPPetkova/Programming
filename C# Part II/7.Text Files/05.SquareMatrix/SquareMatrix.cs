//Write a program that reads a text file containing a square matrix of numbers and finds 
//in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
//The first line in the input file contains the size of matrix N. 
//Each of the next N lines contain N numbers separated by space. 
//The output should be a single number in a separate text file. Example:
//4
//2 3 3 4
//0 2 3 4			17
//3 7 1 2
//4 3 3 2

using System;
using System.IO;

class SquareMatrix
{
    static void readMatrix(string fileName, string newTextFile)
    {
        using (StreamWriter streamWriter = new StreamWriter(newTextFile))
        {
            using (StreamReader readFile = new StreamReader(fileName))
            {
                int size = int.Parse(readFile.ReadLine());
                string[] rowNumbers;
                int[,] matrix = new int[size,size];
 
                for (int i = 0; i < size; i++)
                { 
                    rowNumbers = readFile.ReadLine().Split(' ');
                    for (int j = 0; j < size; j++)
                    {
                        matrix[i , j] = int.Parse(rowNumbers[j]);
                    }
                }
                int max = SumSubMatrix(matrix);
                streamWriter.WriteLine(max);

            }
        }

    }
    static int SumSubMatrix(int[,] matrix)
    {
        int sum = 0;
        int maxSum = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                if (maxSum < sum)
                {
                    maxSum = sum;
                }
            }
        }
        return maxSum;
    }
    static void Main()
    {
        try
        {
            string filename = "matrix.txt";
            string newTextFile = "maxSum.txt";
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
