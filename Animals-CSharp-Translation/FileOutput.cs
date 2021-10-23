using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Animals_CSharp_Translation
{
    class FileOutput
    {
        private String FileName { get; set; }
        private FileStream Stream { get; set; } = null;
        private StreamWriter Writer { get; set; } = null;

        public FileOutput(String fileName)
        {
            this.FileName = fileName;
            try
            {
                Stream = File.Open(fileName, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
                Writer = new StreamWriter(Stream) ;
                
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error" + fileName + " " + e);
            }
        }

        public void FileWrite(String line)
        {
            try
            {
                
                Writer.WriteLine(line);
               
            }
            catch (Exception e)
            {
                Console.WriteLine("File Read Error" + FileName + " " + e);
            }
        }

        public void FileClose()
        {
            if (Writer != null)
            {
                try
                {
                    Writer.Close();
                    Writer.Dispose();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
            if (Stream != null)
            {
                try
                {
                    Stream.Close();
                    Stream.Dispose();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }

            

        }
    }

}
