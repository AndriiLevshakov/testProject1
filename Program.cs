using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String str = Console.Read();
            //Console.WriteLine(str);
            Console.WriteLine("Paste text and press Enter");
            var sb = new StringBuilder();

            do
            {
                sb.AppendLine(Console.ReadLine());
            } while (Console.KeyAvailable);

            Console.WriteLine("Pasted text:");
            Console.WriteLine(sb.ToString());

            string phrase = sb.ToString();
            char[] stringSeparators = new char[] { ' ', ',', '.', '\n' };
            string[] words = phrase.Split(stringSeparators, 1000, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");


            }
            var letters = new StringBuilder();
            
            foreach (var word in words)
            {
                if (word == null)
                    continue;
                else
                {
                    String wordX = word.ToString();
                    Char x = wordX[0];

                    for (int i = 0; i < wordX.Length; i++)
                    {
                        int y = 1;
                        for (int j = i + 1; j < wordX.Length; j++)
                        {

                            if (wordX[i] == wordX[j])
                            {
                                x = wordX[i + 1];
                                break;
                            }

                        }
                        if (x == wordX.Last() || x == wordX[i + 1])
                            continue;
                        else
                        {
                            letters.Append(x);
                            break;
                        }


                    }

                }

            }
            Console.WriteLine(letters.ToString());
            Char SearchedLetter = letters[0];
            String finalLetters = letters.ToString();
            for (int i = 0; i < finalLetters.Length; i++)
            {
                for (int j = i+1; j < finalLetters.Length; j++)
                {

                    if (finalLetters[i] == finalLetters[j])
                    {
                        SearchedLetter = letters[i + 1];
                        break;
                    }

                }
                if (SearchedLetter == finalLetters[i + 1])
                    continue;
                else
                    break;
            }
            Console.WriteLine(SearchedLetter);
            Console.WriteLine("The end");
            Console.ReadLine();

            char GetLetter()
            {
                return SearchedLetter;
            }
        }
        
    }
}
