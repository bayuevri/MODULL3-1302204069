using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULL3_1302204069
{
    internal class Program
    {
        static void Main(string[] args)
        {
			// Demo kode buah
			KodeBuah buah = KodeBuah.GetKodeBuah("C000");
			Console.WriteLine(buah.GetBuah() + " dengan kode " + buah.GetKode());

			Console.WriteLine(" ");

			// Demo posisi karakter
			PosisiKarakterGame posisiKarakter = new PosisiKarakterGame();
			posisiKarakter.TekanW();
			posisiKarakter.TekanX();
			posisiKarakter.TekanS();
			posisiKarakter.TekanW();
			posisiKarakter.TekanW();
		}
    }
}
