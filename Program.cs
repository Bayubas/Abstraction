using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.AbstractClass;    
namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil;
            mobil = new Mercedes();
            mobil.Komponen();

            Console.WriteLine();
            mobil = new BMW();
            mobil.Komponen();

            Console.WriteLine();
            mobil = new Nissan();
            mobil.Komponen();


            

            Console.ReadKey();
        }
    }
}