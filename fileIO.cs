using System;
using System.IO;

namespace FileProcess
{
   class Process
   {
      static void Main(string[] args)
      {
         try
         {
            using (StreamReader sr = new StreamReader("pathOffile/fileName"))
            {
               string line;
               
               while ((line = sr.ReadLine()) != null)
               {
                  Console.WriteLine(line);
               }
            }
         }
         catch (Exception e)
         {
         
            Console.WriteLine("File can not be read");
            Console.WriteLine(e.Message);
         }
         
         Console.ReadKey();
      }
   }
}