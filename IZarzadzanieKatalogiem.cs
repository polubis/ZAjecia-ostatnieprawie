using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    interface IZarzadzanieKatalogiem
    {
        void DodajPozycje(string Imie, string Nazwisko, string Tytul, int Id, string Wydawnictwo, int rokWydania, int liczbaStron);
        void DodajPozycje(string Tytul, int Id, string Wydawnictwo, int rokWydania, int Numer);
        void WyszukajPoTytule(string Tytul);
        void WyszukajPoId(int Id);
    }
}
