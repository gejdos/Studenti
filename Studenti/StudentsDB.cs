using System;
using System.Collections;

namespace Studenti
{
    class StudentsDB
    {
        struct Student
        {
            public string Meno, Priezvisko;
            public int Vek;

            public static bool operator >(Student student1, Student student2)
            {
                return (student1.Vek > student2.Vek);
            }

            public static bool operator <(Student student1, Student student2)
            {
                return (student1.Vek < student2.Vek);
            }
        }

        public void VytvorDatabazu()
        {
            const int dlzkaPola = 10;
            string[] menaArr = new string[] { "Jakub", "Jan", "Tomas", "Peter", "Karol" };
            string[] priezviskaArr = new string[] { "Gejdos", "Rajcan", "Novak", "Jancovic", "Hudec" };
            Student[] studentiArr = new Student[dlzkaPola];
            Student[] studentiNewArr = new Student[dlzkaPola];
            ArrayList zoznamStudentov = new ArrayList();
            Random r = new Random();
            bool sortBool;

            for (int i = 0; i < dlzkaPola; i++)
            {
                studentiArr[i].Meno = menaArr[r.Next(5)];
                studentiArr[i].Priezvisko = priezviskaArr[r.Next(5)];
                studentiArr[i].Vek = r.Next(15, 81);
                //studentiArr[i].Vek = i + 20; //testovanie zoradeneho pola

                zoznamStudentov.Add(studentiArr[i]);
                //zoznamStudentov.Remove();
                //zoznamStudentov.Count;
            }

            sortBool = ZoradStudentov(studentiArr, out studentiNewArr);
                
            Console.WriteLine("---------------------\nnezoradene pole\n---------------------");
            foreach (Student s in zoznamStudentov)
            {
                Console.WriteLine("{0} {1}, {2} rokov", s.Meno, s.Priezvisko, s.Vek);
            }

            Console.WriteLine("---------------------\nzoradene pole\n---------------------");
            for (int i = 0; i < studentiNewArr.Length; i++)
            {
                Console.WriteLine("{0}. {1} {2}, {3} rokov", (i + 1), studentiNewArr[i].Meno, studentiNewArr[i].Priezvisko, studentiNewArr[i].Vek);
            }

            if (sortBool)
            {
                Console.WriteLine("\nPole bolo potrebne zoradit ({0})\n", sortBool);
            }
            else
            {
                Console.WriteLine("\nPole nebolo potrebne zoradit ({0})\n", sortBool);
            }
        }

        private bool ZoradStudentov(Student[] array, out Student[] newArray)
        {
            Student temp;
            bool triedene = false;
            newArray = (Student[])array.Clone();

            //bubble sort
            for (int write = 0; write < newArray.Length; write++)
            {
                for (int sort = 0; sort < newArray.Length - 1 - write; sort++)
                {
                    //implementovany operator ">"
                    if (newArray[sort] > newArray[sort + 1])
                    {
                        triedene = true;

                        temp = newArray[sort + 1];
                        newArray[sort + 1] = newArray[sort];
                        newArray[sort] = temp;
                    }
                }

                if (!triedene) break;
            }

            return triedene;
        }
    }
}
