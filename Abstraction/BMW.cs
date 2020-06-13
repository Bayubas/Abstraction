using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class BMW : Mobil
    {
        public override void Komponen()
        {
            Console.WriteLine("BMW adalah sebuah perusahaan otomotif Jerman yang memproduksi mobil dan sepeda motor.");
            Console.WriteLine("BMW didirikan pada tahun 1916 oleh Franz Josef Popp.");

        }
    }
}