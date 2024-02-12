using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cviko3
{
    internal class Program
    {

        static void addItems(Dictionary<string, string> list, string key, string value) {
            list.Add(key, value);
        }

        static void alocateList(Dictionary<string, string> translator) {
            addItems(translator, "pes", "dog");
            addItems(translator, "macka", "cat");
            addItems(translator, "kon", "horse");
            addItems(translator, "lev", "lion");
            addItems(translator, "liska", "fox");
        }
        static string menu() {
            Console.WriteLine("-----------------\n1 -> Vyhladaj slovo v slovniku\n2-> Pridaj slovo do slovnika\n3-> Vypis pocet slov v slovniku\n4-> Ukoncit\n----------------- ");
 
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> translator = new Dictionary<string, string>();
            alocateList(translator);

            while (true)
            {   
                string option = menu();
                if (option.Equals("1"))
                {
                    Console.WriteLine("Zadaj slovo v slovenstine na preklad: ");
                    string word = Console.ReadLine();
                    Console.WriteLine(translator[word]);
                }
                if (option.Equals("2"))
                {
                    Console.WriteLine("Zadaj slovo slovenske slovo pre pridanie");
                    string SJ = Console.ReadLine();
                    Console.WriteLine("Zadaj jeho preklad v AJ");
                    string AJ = Console.ReadLine();
                    addItems(translator, SJ, AJ);
                }
                if (option.Equals("3"))
                {
                    Console.WriteLine("Velkost listu " + translator.Count);       
                }
                if (option.Equals("4")) {
                    return;
                }
                {
                    
                }
            }
            
        }
    }
}
