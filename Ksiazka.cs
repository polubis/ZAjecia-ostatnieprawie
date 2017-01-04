using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Ksiazka:Pozycja
    {
        private int liczbaStron;
        private Autor autor;
        public Ksiazka() { }
        public Ksiazka(string Imie,string Nazwisko,string Tytul,int Id,string Wydawnictwo,int rokWydania,int LiczbaStron)
        {
            ustawPersonalia(Imie,Nazwisko);
            this.Tytul = Tytul;
            this.Id = Id;
            this.Wydawnictwo = Wydawnictwo;
            this.RokWydania = rokWydania;
            this.liczbaStron = LiczbaStron;
        }
        public string ustawPersonalia(string Imie,string Nazwisko)
        {
            autor = new Autor(Imie, Nazwisko);
            return autor.wypiszPersonalia2(); ;
        }

        public override string ToString()
        {
            return autor.wypiszPersonalia2()+"\n Tytul :"+Tytul+"\n Id :"+Id.ToString()+"\n Wydawnictwo : "+Wydawnictwo+
                   "\n Rok wydania :"+RokWydania.ToString()+"\n Liczba stron :"+liczbaStron.ToString();
        }
    }
}
