using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CollectionHW
{
    public class FileLogger : ILogger
    {
        public void Log(Exception e)
        {
            //Console.WriteLine("An error has occured. The log will be in temp folder. Type disk where you want to save log. For instance, C:\\temp\\ ");

            //    var userInput = char.TryParse(Console.ReadLine(), out char result);
            //string path = $"{userInput}:\\temp\\log.txt";
            string path = "C:\\temp\\log.txt";
            DateTime date = DateTime.Now;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(e);
                sw.Write($"/n {date}");     
            }

        }
        

        }

            
            
        }
    

