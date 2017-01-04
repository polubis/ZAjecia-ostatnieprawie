using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Katalog:IZarzadzanieKatalogiem
    {
        public List<Pozycja> listaPozycji;
        public Katalog() { }
        public void DodajPozycje(string Imie,string Nazwisko,string Tytul,int Id,string Wydawnictwo,int rokWydania,int liczbaStron)
        {
            listaPozycji.Add(new Ksiazka(Imie, Nazwisko, Tytul, Id, Wydawnictwo, rokWydania, liczbaStron));
        }
        public void DodajPozycje(string Tytul, int Id, string Wydawnictwo, int rokWydania, int Numer)
        {
            listaPozycji.Add(new Czasopismo(Tytul, Id, Wydawnictwo, rokWydania, Numer));
        } 
        public void WyszukajPoTytule(string Tytul)
        {

        }
        public void WyszukajPoId(int Id)
        {

        }
    }
}
