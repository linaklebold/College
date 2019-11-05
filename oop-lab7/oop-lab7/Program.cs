using System;
using ClassLibrary;

namespace oop_lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            People p1 = new People("Lina", "Sayko", "30/07/2001");
            p1.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();
            Abiturient a1 = new Abiturient(100, 50, "School #5", p1);
            p1 = a1;
            p1.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();
            Student s1 = new Student(4, "P-41", "Programming", "KPK NU LP", a1);
            p1 = s1;
            p1.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();

            People p2 = new People("Victoria", "Krasnichuk", "01/01/1970");
            p2.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();
            Vykladach v1 = new Vykladach("Vchutel", "Programming", "KPK NU LP", p2);
            p2 = v1;
            p2.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();

            KorystuvachBiblioteku k1 = new KorystuvachBiblioteku(5, "03/11/2019", 15, s1);
            p1 = k1;
            p1.ShowInfo();
        }
    }
}
