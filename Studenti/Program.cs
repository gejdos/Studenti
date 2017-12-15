using System;

namespace Studenti
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsDB databaza = new StudentsDB();
            databaza.VytvorDatabazu();

            //Kolekcie K = new Kolekcie();
            //K.NaplnFrontu();
            //K.NaplnZasobnik();
            //K.NaplnTabulku();

            //inline podmienka
            //bool bolo = true;
            //triedene = (bolo) ? true : false;
            //int dlzka = (newArray.Length == 10) ? 1 : 0;

            Console.ReadKey();
        }
    }
}
