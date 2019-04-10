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

                int number = 0;

                string line;

                while ((line = file.ReadLine()) != null)

                {

                    if (line.Contains("Fare") == true && line.Contains("War") == false || line.Contains("fare") == true && line.Contains("War") == false)

                    {

                        int x = counter - 1;

                        number++;

                    }

                    counter++;

                }

                Console.WriteLine($"The number of lines that contains *Fare* without the word *War* are {number}");



                file.Close();


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
