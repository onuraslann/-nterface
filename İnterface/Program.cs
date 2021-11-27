using System;
using System.Collections.Generic;

namespace İnterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product p1 = new Product { Id = 1, Name = "Kalem " };
            //Product p2 = new Product { Id = 2, Name = "silgi " };

            ////List<Product> product = new List<Product> { p1, p2 };
            ////2 yol
            //Product[] product = new Product[] { p1, p2 };

            //foreach (var x in product)
            //{
            //    Console.WriteLine(x.Name);
            //}

            /* IKredi kredi = new IKredi()*/ //interfaceler newlenmez 

            KonutKredisi konutkredi = new KonutKredisi();
            TasitKredi tasitkredi = new TasitKredi();
            List<IKredi> kredis = new List<IKredi> { tasitkredi, konutkredi };

            Basvuru basvuru = new Basvuru();
            basvuru.BasvuruYap(kredis);
        }
    }
}
