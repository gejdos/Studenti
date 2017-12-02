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
            Random r = new Random();
            Student[] studenti = new Student[10];

            for (int i = 0; i < 10; i++)
            {
            
                Student student = new Student();

                student.meno = mena[r.Next(5)];
                student.priezvisko = priezviska[r.Next(5)];
                student.vek = r.Next(15, 81);

                //Console.WriteLine(student.meno + " " + student.priezvisko + ", " + student.vek);

                studenti[i] = student;
                //Console.WriteLine(studenti[i].meno + ", " + studenti[i].priezvisko + ", " + i);

            }

            //Student[] student = new Student[] {};

        }

        public bool ZoradStudentov(Student[] student)
        {
            return false;
        }



    }
}
