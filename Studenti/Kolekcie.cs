using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    class Kolekcie
    {
        //fronta FIFO - "first in, first out"
        Queue fronta = new Queue();
        //zasobnik LIFO - "last in, first out"
        Stack zasobnik = new Stack();
        //
        Hashtable table = new Hashtable();

        public void NaplnFrontu()
        {
            fronta.Enqueue("Pavel");
            fronta.Enqueue("Jakub");
            fronta.Enqueue("Jan");

            //string s = (string) fronta.Dequeue();

            foreach (string str in fronta)
            {
                Console.WriteLine(str);
            }
            
        }

        public void NaplnZasobnik()
        {   
            zasobnik.Push(10);
            zasobnik.Push(5);
            zasobnik.Push("Jakub");
            zasobnik.Push("Pavel");

            string s = zasobnik.Pop().ToString();

            foreach (object str in zasobnik)
            {
                Console.WriteLine(str);
            }

        }

        public void NaplnTabulku()
        {
            table["Jakub Gejdos"] = "123456789";
            table["Tomas"] = "15185166560";

            table.Remove("Tomas");
;
        }
           
    }
}
