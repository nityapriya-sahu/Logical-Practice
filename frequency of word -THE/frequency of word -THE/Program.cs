using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequency_of_word__THE
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Please enter the sentence");
              string sentence = Console.ReadLine();
              string[] words = sentence.Split();

              int flag = 0;

              for ( int i = 0; i < words.Length; i++)
              {
                   string word = words[i];
                  Boolean isSame = word == "the";
                  if (isSame)
                  {
                      flag = flag + 1;
                  }
              }

              Console.WriteLine("Count : {0}", flag);
              Console.ReadLine();

            //------------------------------------------------//
            //-----------------PRACTICE----------------//

          
        }
    }
    
}
