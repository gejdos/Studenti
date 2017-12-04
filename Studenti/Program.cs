using System;

namespace Studenti
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsDB databaza = new StudentsDB();
            databaza.VytvorDatabazu();

            Console.ReadKey();
        }
    }
}
