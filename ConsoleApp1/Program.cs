using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
        }
        public void Run()
        { this.ReadTextFiles(); }
        public void ReadTextFiles()
    {
            using (StreamReader file = new StreamReader(@"U:\Users\732153\Beowulf.txt"))
            {
                int counter = 0;

                string delim = " ,.";

                string[] fields = null;

                string line = null;

                while (!file.EndOfStream)

                {

                    line = file.ReadLine();

                    line.Trim();

                    fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    counter += fields.Length;

                }




                file.Close();

                Console.WriteLine($"The text file has {counter} words.");

               
            }
    }
        public int FindNumberOfBlankSpaces(String line)
        {
            int countletters = 0;
            int countspaces = 0;

            foreach (char c in line)
            {
                if(char.IsLetter(c))
                { countletters++; }
                if (char.IsWhiteSpace(c))

                {
                    countspaces++;
                }
            }
            return countspaces;
        }
    }
}
