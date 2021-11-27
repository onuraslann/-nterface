using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface
{
    public class TasitKredi : IKredi
    {
        public void hesapla()
        {
            Console.WriteLine("Taşıt kredisi hesaplandı ");
        }
    }
}
