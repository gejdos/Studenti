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
        private Student[] studenti = new Student[10];

        public void NaplnStudenta()
        {
            Random r = new Random();
            Student student = new Student();

            for (int i = 0; i < 10; i++)
            {              
                student.meno = mena[r.Next(5)];
                student.priezvisko = priezviska[r.Next(5)];
                student.vek = r.Next(15, 81);

                //Console.WriteLine(student.meno + " " + student.priezvisko + ", " + student.vek);

                studenti[i] = student;

                //ZoradStudentov(studenti);


            }

            foreach (Student st in studenti)
            {
                Console.WriteLine(st.meno + " " + st.priezvisko + ", " + st.vek + " rokov");
            }

        }


        private bool ZoradStudentov(Student[] array)
        {
            int temp = 0;

            for (int write = 0; write < array.Length; write++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort].vek > array[sort + 1].vek)
                    {
                        temp = array[sort + 1].vek;
                        array[sort + 1].vek = array[sort].vek;
                        array[sort].vek = temp;
                    }
                }
            }

            return false;
        }



    }
}
