using System;

namespace Studenti
{
    class Program
    {
        static void Main(string[] args)
        {
            //StudentsDB databaza = new StudentsDB();
            //databaza.VytvorDatabazu();

            Kolekcie k = new Kolekcie();
            k.NaplnFrontu();

            //inline podmienka
            //bool bolo = true;
            //triedene = (bolo) ? true : false;
            //int dlzka = (newArray.Length == 10) ? 1 : 0;

            Console.ReadKey();
        }
    }
}
