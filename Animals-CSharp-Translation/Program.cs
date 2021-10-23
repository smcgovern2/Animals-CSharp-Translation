using System;
using System.Collections;
using System.IO;

namespace Animals_CSharp_Translation
{
    class Program
    {

        private readonly static FileOutput OutFile = new FileOutput("animals.txt");
        private readonly static FileInput InFile = new FileInput("animals.txt");
        public static void Main(string[] args)

        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            

        ArrayList zoo = new ArrayList
            {

                // Lines to Replace Begin Here
                new Dog(true, "Bean"),
                new Cat(9, "Charlie"),
                new Teacher(44, "Stacy Read")
            };
            // End Lines to Replace

            foreach (ITalkable thing in zoo)
            {
                PrintOut(thing);
            }

            
            InFile.FileRead();
            InFile.FileClose();
            OutFile.FileClose();

            FileInput indata = new FileInput("animals.txt");
            String line;
            while ((line = indata.FileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public static void PrintOut(ITalkable p)
        {
            Console.WriteLine(p.Name + " says=" + p.Talk());
            OutFile.FileWrite(p.Name + " | " + p.Talk());
        }
    }
    
}
