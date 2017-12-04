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
        private Student student = new Student();
        private Student[] studenti = new Student[10];

        public void NaplnStudenta()
        {
            Student[] newArr = new Student[10];
            Random r = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                student.meno = mena[r.Next(5)];
                student.priezvisko = priezviska[r.Next(5)];
                student.vek = r.Next(15, 81);
                //student.vek = i;

                //Console.WriteLine(student.meno + " " + student.priezvisko + ", " + student.vek);

                studenti[i] = student;

            }

            Console.WriteLine("---------------------\nnetriedene pole\n---------------------");
            foreach (Student st in studenti)
            {
                Console.WriteLine(st.meno + " " + st.priezvisko + ", " + st.vek + " rokov");
            }

            
            ZoradStudentov(studenti, out newArr);
            Console.WriteLine("\nPole bolo zoradene: " + ZoradStudentov(studenti, out newArr) + "\n");

            Console.WriteLine("---------------------\ntriedene pole\n---------------------");
            foreach (Student st in newArr)
            {
                Console.WriteLine(st.meno + " " + st.priezvisko + ", " + st.vek + " rokov");
            }

        }

        private bool ZoradStudentov(Student[] array, out Student[] newArray)
        {
            Student temp;
            newArray = (Student[]) array.Clone();

            for (int write = 0; write < newArray.Length; write++)
            {
                for (int sort = 0; sort < newArray.Length - 1; sort++)
                {
                    if (newArray[sort].vek > newArray[sort + 1].vek)
                    {
                        temp = newArray[sort + 1];
                        newArray[sort + 1] = newArray[sort];
                        newArray[sort] = temp;
                    }
                }
            }


            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i].vek != array[i].vek)
                {
                    return true;
                }               
            }

            return false;

        }





    }
}
