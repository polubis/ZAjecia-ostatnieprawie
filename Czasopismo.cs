using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Czasopismo:Pozycja
    {
        private int Numer;
        public Czasopismo() { }
        public Czasopismo(string Tytul,int Id,string Wydawnictwo,int rokWydania,int Numer)
        {
            this.Tytul = Tytul;
            this.Id = Id;
            this.Wydawnictwo = Wydawnictwo;
            this.RokWydania = rokWydania;
            this.Numer = Numer;
        }
        public override string ToString()
        {
            return "\n Tytul :"+Tytul+"\n Id :"+Id.ToString()+"\n Wydawnictwo : "+Wydawnictwo+
                   "\n Rok wydania :"+RokWydania.ToString()+"\n Numer :"+Numer;
        }
    }
}
