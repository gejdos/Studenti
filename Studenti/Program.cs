using System;

namespace Studenti
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                StudentsDB databaza = new StudentsDB();
                databaza.VytvorDatabazu();

                Console.ReadKey();
            }
        }
    }
}
