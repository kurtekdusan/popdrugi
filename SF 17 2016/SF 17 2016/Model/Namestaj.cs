﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_17_2016.Model
{
    public class Namestaj
    {
        public int Id { get; set; }
        public bool Obrisan {get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public double Cena { get; set; }
        public int Kolicina { get; set; }
        public int? TipNamestajaId { get; set; }
        //public Akcija Akcija { get; set; }
        public int? AkcijaId { get; set; }
        //int? - nullable podatak
        public static int Count { get; internal set; }

        internal static void Add(Namestaj noviNamestaj)
        {
            throw new NotImplementedException();
        }
    }
}
