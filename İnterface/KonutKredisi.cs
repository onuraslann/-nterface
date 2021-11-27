using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface
{
    public class KonutKredisi : IKredi
    {
        public int FaizOranı { get; set; }
        public void hesapla()
        {
            Console.WriteLine("Konut Kredisinin faiz oranı : "+FaizOranı);
        }
    }
}
