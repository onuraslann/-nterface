using System;

namespace Kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri { Id = 1, MusteriNo = "as21", Name = "Onur", Tc = "23456" };

            TuzelMusteri tuzelMusteri = new TuzelMusteri { Id = 2, MusteriNo = "332", Sirketismi = "Atolla", VergiNo = "1135" };

            Basvuru basvuru = new Basvuru();
            basvuru.BasvuruYap(tuzelMusteri);
        }
    }
}
