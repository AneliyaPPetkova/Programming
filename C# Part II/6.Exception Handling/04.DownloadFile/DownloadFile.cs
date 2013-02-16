//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
//and stores it the current directory. Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFile
{
    static void Download(string url, string fileName)
    {
        WebClient myWebClient = new WebClient();
        myWebClient.DownloadFile(url, fileName); 
    }
    static void Main()
    {
        try
        {
            string url = "http://www.devbg.org/img/Logo-BASD.jpg";
            string fileName = "Logo-BASD.jpg";
            Download(url, fileName);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address parameter is null!");
        }
        catch (WebException)
        {
            Console.WriteLine("An error occurred while downloading data!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads!");
        }
    }
}

