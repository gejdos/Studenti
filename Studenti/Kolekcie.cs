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

            zasobnik.Push("");

            

        }
    }
}
