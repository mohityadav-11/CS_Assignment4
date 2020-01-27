using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng_dict_op_Assignment4
{

    class Plural{
        public void Pluralize(string word){

            int length = word.Length;
            char[] w = word.ToCharArray();
            
            if (w[length-1] == 'y'){

                w[length - 1] = 'i';
                w[length] = 'e';
                w[length + 1] = 's';
                w[length + 2] = '\0';
            }

            else if (w[length - 1] == 's' ||
                   (w[length - 2] == 'c' && w[length - 1] == 'h') ||
                   (w[length - 2] == 's' && w[length - 1] == 'h')){

                    word+="es";
                  }

            else{
                word+= "s";
            }

            Console.WriteLine(word);

            return;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var words = new List<string>();
            words.Add("Boat");
            words.Add("house");
            words.Add("cat");
            words.Add("river");
            words.Add("cupboard");

            Plural p = new Plural();

            //Plurals of list items
            foreach (var str in words)
                p.Pluralize(str);

            words[words.FindIndex(ind => ind.Equals("house"))] = "Home";

            Console.WriteLine();
            p.Pluralize(words[1]);

            words.Add("cabaret");
            words.Add("habitat");
            words.Add("laptop");
            words.Add("season");

            Console.WriteLine();
            Console.WriteLine(words.Count);
            Console.WriteLine();
            foreach (var vr in words)
            {
                if (vr.Length == 7)
                    Console.WriteLine(vr);
            }

            Console.WriteLine();
            Console.WriteLine(words[2]);
            Console.WriteLine();

            words.Sort();
            foreach (var r in words)
                Console.WriteLine(r);

            Console.WriteLine();
            words.Reverse();
            foreach (var r in words)
                Console.WriteLine(r);
        }

       
    }
}
