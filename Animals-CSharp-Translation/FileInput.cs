using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Animals_CSharp_Translation
{
    class FileInput
    {
        private String FileName { get; set; }

        private StreamReader Reader { get; set; } = null;

        private FileStream Stream { get; set; } = null;

        public FileInput(String fileName)
        {
            this.FileName = fileName;
            try
            {
                Stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                Reader = new StreamReader(Stream);


                

                /*Reader = new StreamReader(FileName);*/

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void FileRead()
        {
            String line;
            try
            {
                
                while ((line = Reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + FileName + " " + e);
            }
        }

        public String FileReadLine()
        {
            try
            {
                
                String line = Reader.ReadLine();
                return line;
                
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + FileName + " " + e);
                return null;
            }
        }

        public void FileClose()
        {
            if (Reader != null)
            {

                try
                {
                    Reader.Close();
                    Reader.Dispose();
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
