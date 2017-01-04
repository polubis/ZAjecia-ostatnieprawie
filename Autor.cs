using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Autor
    {
        protected string Imie;
        protected string Nazwisko;
        public Autor() { }
        public Autor(string Imie,string Nazwisko)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
        }
        public string wypiszPersonalia2()
        {
            return "Imie :"+Imie+"\n Nazwisko :"+Nazwisko;
        }
    }
}
