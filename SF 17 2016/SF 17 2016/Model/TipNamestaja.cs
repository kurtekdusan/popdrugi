using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_17_2016.Model
{
    public class TipNamestaja
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public double Obrisan { get; set; }
        public static TipNamestaja GetById(int id)
        {
            foreach (var tip in Projekat.Instance.TipoviNamestaja)
            {
                if(tip.Id == id)
                {
                    return tip;
                }
            }
            return null;
        }
    }
}
