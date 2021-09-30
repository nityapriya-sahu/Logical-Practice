using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rough_work
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var names = new List<string>();
            names.Add("Sonoo Jaiswal");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");

            // Iterate list element using foreach loop   
            foreach (var name in names) 
            {
                Console.WriteLine(name);
            }*//*



            var names = new List<string>();
            names.Add("chintu \n");
            names.Add("nitya \n");
            names.Add("chikun\n");
            names.Add("prema\n");
            names.Add("mantu\n");
            names.Add("mantesh\n");

            foreach (var x in names)
            {
                Console.WriteLine(x);
            }
            *//*for (int i = 0; i <= names.Count; i++)
            {
                Console.WriteLine(names.ElementAt(i));
            }*//*



            names.ForEach(Console.WriteLine);*/

            //-------------------------------------//

            /* var naam = new HashSet<string>();

             naam.Add("Chintu \n");
             naam.Add("chikun \n");
             naam.Add("mantu \n");
             naam.Add("chikun \n");
             naam.Add("mantu \n");

             //duplicate elements will not be added//

             foreach(var y in naam)
             {
                 Console.WriteLine(y);
             }*/

            //--------------------------------------//
            /* var slno = new SortedSet<string>();

             slno.Add("narendra");
             slno.Add("chintu");
             slno.Add("mantu");
             slno.Add("sukanti");
             slno.Add("dola");

             //slno.foreach (Console.WriteLine);

             //it will show the element in sort list//
             foreach(var Z in slno)
             {
                 Console.WriteLine(Z);
             }*/

            //----------------------------------//

           /* var nam = new Stack<string>();
            //also we can write  :- stack<string> nam = new stack<string>();
            nam.Push("chintu");
            nam.Push("chikun");
            nam.Push("sukanti");
            nam.Push("narendra");

            foreach (var family in nam)
            {
                Console.WriteLine(family);
            }
            Console.WriteLine("peek element : " + nam.Peek());
            Console.WriteLine("pop element : " + nam.Pop());
            Console.WriteLine("now the new element : " + nam.Peek());*/

            //------------------------------------------------//

            /* Queue<string> line = new Queue<string>();

             line.Enqueue("narendra");
             line.Enqueue("sukanti");
             line.Enqueue("chikun");
             line.Enqueue("chintu");

             foreach(string f in line)
             {
                 Console.WriteLine(f);
             }

             Console.WriteLine("peek element : " + line.Peek());
             Console.WriteLine("dequeue : " + line.Dequeue());
             Console.WriteLine("after dequeue new element is : " + line.Peek());*/

            //---------------------------------------//

            /* LinkedList<string> list = new LinkedList<string>();

             list.AddLast("abc");
             list.AddLast("def");
             list.AddLast("ghi");
             list.AddLast("jkl");
             list.AddFirst("mno");
             list.AddFirst("pqr");
             foreach(string no in list)
             {
                 Console.WriteLine(no);
             }*/

            //------------------------------------------//

            //example - 2 (using find() method before nd after specific node)


            /*var N = new LinkedList<string>();

            N.AddLast("narendra");
            N.AddLast("sukanti");
            N.AddLast("chikun");
            N.AddLast("chintu");

            //Now insert new element before narendra

            LinkedListNode<string>node = N.Find("narendra");
            N.AddBefore(node, "ramachandra");
            N.AddAfter(node, "aparna");
            foreach (var Q in N)
            {
                Console.WriteLine(Q);
            }*/

            //--------------------------------------------------//

            /* Dictionary<string, string> names = new Dictionary<string, string>();

             names.Add("1.", "CHINTU");
             names.Add("2.", "CHIKUN");
             names.Add("3.", "MANTU");
             names.Add("4.", "SUSMI");
             names.Add("5.", "RANJI");
             names.Add("6.", "DOLA");

             foreach(KeyValuePair<string,string> F in names)
             {
                 Console.WriteLine(F.Key +" " + F.Value);
             } */

            //----------------------------------------------------------//

            /* SortedDictionary<string, string> names = new SortedDictionary<string, string>();

             names.Add("3.", "realme");
             names.Add("1.", "oneplus");
             names.Add("5.", "asus");
             names.Add("2.", "xiomi");
             names.Add("4.", "poco");

             foreach(KeyValuePair<string,string> name in names)
             {
                 Console.WriteLine(name.Key + " " + name.Value);

             }*/

            //note :- sortedlist and sorteddictionary are almost same procedure thats why i dont mention it.
            //s.list is used less memory than s.dictionary.

            // ---------*---------\\


        }
    }
}
