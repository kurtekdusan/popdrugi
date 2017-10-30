using SF_17_2016.Model;
using SF_17_2016.Tests;
using SF_17_2016.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_17_2016
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Serij");
            var namestaj = GenericSerializer.Deserialize<Namestaj>("namestaj.xml");
            Console.WriteLine("unesi naziv");
            string naziv = Console.ReadLine();

            Console.WriteLine("unesite id tipa namestaja");
            int idTipaNamestaja = int.Parse(Console.ReadLine());

            namestaj.Add(new Namestaj() { id = 343, Naziv = naziv, TipNamestajaId = idTipaNamestaja });

            var tipoviNamestaja = Projekat.Instance.TipoviNamestaja;
            TipNamestaja trazeniTip = null;
            foreach (var tip in tipoviNamestaja)
            {
                if(tip.Id == idTipaNamestaja)
                {
                    trazeniTip = tip;

                }
            }
            Projekat.Instance.Namestaj = namestaj;
            Console.WriteLine($"dodat namestaj: naziv {naziv}, tip namestaja {trazeniTip.Naziv}");
            Console.WriteLine("finished");
            Console.ReadLine();
                
            



            var novitip = new TipNamestaja()
            {
                Id = 1,
                Naziv = "tip"
            };

            var tipNamestaja = new List<TipNamestaja>();
            tipNamestaja.Add(novitip);

            var lista = Projekat.Instance.Namestaj;

            lista.Add(new Namestaj() { Id = 28, Naziv = "remix knjaz" });

            Projekat.Instance.Namestaj = lista;
            foreach (var stavka in lista)
            {
                Console.WriteLine($"{stavka.Naziv}");
            }
            /*var name = "";
            var pass = "";
            Console.WriteLine("welcome");
            Console.WriteLine("user: ");
            name = Console.ReadLine();
            Console.WriteLine("pass: ");
            pass = Console.ReadLine();
            if name = Korisnik.KorisnickoIme || pass = Korisnik.Lozinka
                {

            }*/
        }

            public TipNamestaja TipoviNamestaja
        {
            get
            {
                this.tipoviNamestaja = GenericSerializer.Deserialize<TipNamestaja>("tipovi_namestaja.xml");
                return tipoviNamestaja;
            }
            set
            {

            }
        }
            //removeat(count-1)


            /*var tipn1 = new TipNamestaja()
            {
                Id = 1,
                Naziv = "podna lampa"
            };
            var nam1 = new Namestaj()
            {
                Id = 1,
                Naziv = "soc osttlj",
                TipNamestaja = tipn1
            };

            var ln1 = new List<Namestaj>();
            ln1.Add(nam1);

            Console.WriteLine("Serialization...");
            GenericSerializer.Serialize<Namestaj>("namestaj.xml", ln1);
            List<Namestaj> ucitanaLista = GenericSerializer.Deserialize<Namestaj>("namestaj.xml");
            Console.WriteLine("Finished");
            Console.ReadLine();
            */
           
        }



    }
}
