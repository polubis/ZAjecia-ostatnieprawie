using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
     abstract class Pozycja
     {
         protected string Tytul,Wydawnictwo;
         protected int Id,RokWydania;
         public Pozycja() { }
         public Pozycja(string Tytul,string Wydawnictwo,int Id,int RokWydania)
         {
             this.Tytul = Tytul;
             this.Wydawnictwo = Wydawnictwo;
             this.Id = Id;
             this.RokWydania = RokWydania;
         }


     }
}
