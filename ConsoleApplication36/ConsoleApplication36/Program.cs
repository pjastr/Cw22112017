using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class WlasnaKlasa:IBbb
    {

        public string Wyraz()
        {
            return "sdss";
        }

        public int Liczba()
        {
            return 5;
        }
    }

    interface IAaa
    {
        int Liczba();
    }

    interface IBbb:IAaa
    {
        string Wyraz();
    }
}
