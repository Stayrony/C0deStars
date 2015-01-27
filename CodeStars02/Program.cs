using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeStars02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool creatingLetter = false;
            bool createdLetter = false;

            int count = 0;
            StringBuilder wordBuilder = new StringBuilder();

            List<String> textOfSong = new List<String>();

            StreamReader reader = new StreamReader("65.result");
            String text = reader.ReadLine();
            reader.Close();


            String[] words = text.Split(' ');
            foreach (string s in words)
            {
                if (Regex.IsMatch(s, "Yo"))
                {
                    count++;
                    creatingLetter = true;
                }
                else if (Regex.IsMatch(s, "Nice"))
                {
                    if (creatingLetter)
                    {
                        createdLetter = true;
                        creatingLetter = false;
                        char ch = (char)('a' + count - 1);
                        //add current symbol to word
                        wordBuilder.Append(ch);
                        count = 0;

                    }
                    else if (createdLetter)
                    {
                        // the word was created
                        //add current word to list of song
                        textOfSong.Add(wordBuilder.ToString());
                        //clear wordBuilder for the next word
                        wordBuilder.Clear();

                    }
                }
            }

            foreach (string s in textOfSong)
            {
                Console.Write(s + " ");
            }

            Console.ReadKey();

        }
    }
}
