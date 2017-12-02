using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                StudentsDB databaza = new StudentsDB();

                databaza.NaplnStudenta();
                Console.ReadKey();

            }

        }
    }
}
