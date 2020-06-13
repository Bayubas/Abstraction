using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Nissan : IMobil
    {
        public void Komponen()
        {
            Console.WriteLine("Nissan merupakan salah satu perusahaan manufaktur otomotif terbaik di dunia.");
            Console.WriteLine("Sejarah besar Nissan dimulai saat pendiriannya oleh Kwaishinsa pada 1911. Di awal pendiriannya perusahaan ini dikenal dengan nama Kwaishinsa Motor Car Works.");
        }
    }
}