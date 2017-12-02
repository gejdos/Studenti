using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    
    public struct Student
    {
        public string meno, priezvisko;
        public int vek;
    }

    class StudentsDB
    {
        private string[] mena = new string[] { "Jakub", "Jan", "Tomas", "Peter", "Karol" };
        private string[] priezviska = new string[] { "Gejdos", "Rajcan", "Novak", "Jancovic", "Hudec" };
        

        public void NaplnStudenta()
        {

            Student student = new Student();

            student.meno = mena[new Random().Next(5)];
            student.priezvisko = priezviska[new Random().Next(5)];
            student.vek = new Random().Next(15, 81);

            Console.WriteLine(student.meno + " " + student.priezvisko + ", " + student.vek);

            //Student[] student = new Student[] {};

        }

    }
}
