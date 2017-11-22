using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            //Osoba student1 = new Student();
            //Console.WriteLine(student1.ToString());

            Osoba osoba1 = new Osoba("jan", "kowalski");
            Console.WriteLine(osoba1);


            Student st1 = new Student("Anna", "Nowak", 3, 2, 34567);
            Console.WriteLine(st1);
            Console.ReadKey();
        }
    }
}
