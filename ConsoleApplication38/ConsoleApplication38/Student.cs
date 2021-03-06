﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Student:Osoba
    {
        private int rok;
        private int numerGrupy;
        private int numerAlbumu;

        public Student()
        {

        }

        public Student(string imie, string nazwisko, int rok, int numerGrupy, int numerAlbumu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }


        public override void WypiszInfo()
        {
            Console.WriteLine("Imię i nazwisko: {0} {1}", imie, nazwisko);
            Console.WriteLine("Rok: {0}", rok);
            Console.WriteLine("Numer grupy: {0}", numerGrupy);
            Console.WriteLine("Numer albumu: {0}", numerAlbumu);
        }

        public override string ToString()
        {
            return base.ToString()+Environment.NewLine+String.Format("Rok: {0}", rok)+Environment.NewLine+String.Format("Numer grupy: {0}", numerGrupy)+Environment.NewLine+String.Format("Numer albumu: {0}", numerAlbumu);
        }
    }
}
