using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    public class Basvuru
    {
        public void BasvuruYap(Musteri musteri)
        {
            musteri.Id = 3;
            Console.WriteLine("Güncelenen id değeri : "+musteri.Id);
        }

    }
}
