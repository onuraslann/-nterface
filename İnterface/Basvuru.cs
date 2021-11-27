using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface
{
    public class Basvuru
    {
        public void BasvuruYap(List<IKredi> kredi)
        {
            foreach (var x in kredi)
            {
                x.hesapla();

            }
        }
    }
}
