using System.IO;
using System;
using System.ComponentModel.DataAnnotations;

namespace Tyuiu.PiskulinIY.Sprint7.Task0.V13.Lib
{
    public class DataService
    {

        
        public string FileRead(string path)
        {
            string line;
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(@"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint7\Tyuiu.PiskulinIY.Sprint7.Task0.V13\bin\Debug\net8.0-windows\Russia.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
               
                
                //Read the next line
                line = sr.ReadLine();
            }

            return line;
        }
    }
}
