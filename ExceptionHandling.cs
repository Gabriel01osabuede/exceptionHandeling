using System;
using System.IO;

namespace week6
{
    //Exception is an unforssen error when u are running a program
    //Your Users get to see the erro messages which is not intuitive
    //the error messages contain valuable information that may be useful to hackers
    //some lines of code will be skipped.

    public class ExceptionClass
    {
        public string ExceptionMethod()
        {
            try
            {
             
            StreamReader streamReader = new StreamReader(@"C:\Users\Dell Latitude 6430u\Desktop\Sample.txt");
           string detailsInFile = streamReader.ReadLine();
           streamReader.Close();
           return detailsInFile;   
            }
            catch (FileNotFoundException e)
            {
                
                return ("File Not Found\n" + e.FileName + " Please confirm Filename");
            }
            // catch (Exception e)
            // {
                
            //     return ("File Not Found\n" + e.Message + "Please confirm Filename");
            // }
            // finally
            // {
            //     Console.WriteLine("Thank you\nFinally Block.");
            // }

        }
        

    }
    

}