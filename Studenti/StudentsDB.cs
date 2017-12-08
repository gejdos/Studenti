using System;

namespace Studenti
{
    class StudentsDB
    {
        public struct Student
        {
            public string meno, priezvisko;
            public int vek;

            public static bool operator >(Student student1, Student student2)
            {
                return (student1.vek > student2.vek);
            }

            public static bool operator <(Student student1, Student student2)
            {
                return (student1.vek < student2.vek);
            }
        }

        public void VytvorDatabazu()
        {
            const int dlzkaPola = 10;
            string[] menaArr = new string[] { "Jakub", "Jan", "Tomas", "Peter", "Karol" };
            string[] priezviskaArr = new string[] { "Gejdos", "Rajcan", "Novak", "Jancovic", "Hudec" };
            Student[] studentiArr = new Student[dlzkaPola];
            Student[] studentiNewArr = new Student[dlzkaPola];
            Random r = new Random();
            bool sortBool;            

            for (int i = 0; i < dlzkaPola; i++)
            {
                studentiArr[i].meno = menaArr[r.Next(5)];
                studentiArr[i].priezvisko = priezviskaArr[r.Next(5)];
                studentiArr[i].vek = r.Next(15, 81);
                //studentiArr[i].vek = i + 20; //testovanie zoradeneho pola
            }

            sortBool = ZoradStudentov(studentiArr, out studentiNewArr);
                
            Console.WriteLine("---------------------\nnezoradene pole\n---------------------");
            for (int i = 0; i < studentiArr.Length; i++)
            {
                Console.WriteLine("{0}. {1} {2}, {3} rokov", (i + 1), studentiArr[i].meno, studentiArr[i].priezvisko, studentiArr[i].vek);
            }

            Console.WriteLine("---------------------\nzoradene pole\n---------------------");
            for (int i = 0; i < studentiNewArr.Length; i++)
            {
                Console.WriteLine("{0}. {1} {2}, {3} rokov", (i + 1), studentiNewArr[i].meno, studentiNewArr[i].priezvisko, studentiNewArr[i].vek);
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
            bool zoradene = false;
            newArray = (Student[])array.Clone();

            //bubble sort
            for (int write = 0; write < newArray.Length; write++)
            {
                for (int sort = 0; sort < newArray.Length - 1 - write; sort++)
                {
                    if (newArray[sort] > newArray[sort + 1])
                    {
                        zoradene = true;

                        temp = newArray[sort + 1];
                        newArray[sort + 1] = newArray[sort];
                        newArray[sort] = temp;
                    }
                }

                if (!zoradene) break;
            }

            return zoradene;
        }








  
    }
}
