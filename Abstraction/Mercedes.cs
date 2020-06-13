using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Mercedes : Mobil
    {
        public override void Komponen()
        {
            Console.WriteLine("Mercedes Benz adalah sebuah perusahaan otomotif asal Jerman yang memproduksi berbagai macam kendaraan seperti mobil, truk, dan bus.");
            Console.WriteLine(" Mercedes-Benz adalah salah satu perusahaan mobil paling dikenal di dunia dan juga perusahaan mobil tertua di dunia ");
        }
    }
}