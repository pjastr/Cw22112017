using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kwadrat kw1 = new Kwadrat(5);
            //Console.WriteLine(kw1.ObliczPole());
            //Trojkat tr1 = new Trojkat(3, 4, 5);
            //Console.WriteLine(tr1.ObliczPole());

            //Figura fig1 = new Figura();

            List<Figura> figury = new List<Figura>();
            figury.Add(new Kwadrat(7));
            figury.Add(new Trojkat(5, 12, 13));
            figury.Add(new Kwadrat(7));
            figury.Add(new Trojkat(1, 2.5, 3));
            foreach(var element in figury)
            {
                Console.WriteLine(element.ObliczPole());
            }
            Console.ReadKey();
        }
    }
}
