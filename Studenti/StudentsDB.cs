using System;

namespace Studenti
{
    public struct Student
    {
        public string meno, priezvisko;
        public int vek;
    }

    class StudentsDB
    {
        public void VytvorDatabazu()
        {
            string[] mena = new string[] { "Jakub", "Jan", "Tomas", "Peter", "Karol" };
            string[] priezviska = new string[] { "Gejdos", "Rajcan", "Novak", "Jancovic", "Hudec" };
            Student[] studentiArr = new Student[10];
            Student[] newArr = new Student[10];
            Random r = new Random();
            bool sortBool;
            

            for (int i = 0; i < 10; i++)
            {
                studentiArr[i].meno = mena[r.Next(5)];
                studentiArr[i].priezvisko = priezviska[r.Next(5)];
                studentiArr[i].vek = r.Next(15, 81);
            }

            sortBool = ZoradStudentov(studentiArr, out newArr);

            if (sortBool)
            {
                Console.WriteLine("\nPole bolo potrebne zoradit ({0})\n", sortBool);
            }
            else
            {
                Console.WriteLine("\nPole nebolo potrebne zoradit ({0})\n", sortBool);
            }

            Console.WriteLine("---------------------\nnezoradene pole\n---------------------");
            for (int i = 0; i < studentiArr.Length; i++)
            {
                Console.WriteLine("{0}. {1} {2}, {3} rokov", (i + 1), studentiArr[i].meno, studentiArr[i].priezvisko, studentiArr[i].vek);
            }

            Console.WriteLine("---------------------\nzoradene pole\n---------------------");
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine("{0}. {1} {2}, {3} rokov", (i + 1), newArr[i].meno, newArr[i].priezvisko, newArr[i].vek);
            }
        }

        private bool ZoradStudentov(Student[] array, out Student[] newArray)
        {
            Student temp;
            newArray = (Student[]) array.Clone();

            //bubble sort
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
