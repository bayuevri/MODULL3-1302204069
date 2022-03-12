using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULL3_1302204069
{
    internal class KodeBuah
    {


		// Membuat static objek KodeBuah
		public static KodeBuah Apel = new KodeBuah("Apel", "A000");
		public static KodeBuah Aprikot = new KodeBuah("Aprikot", "B000");
		public static KodeBuah Alpukat = new KodeBuah("Alpukat", "C000");
		public static KodeBuah Pisang = new KodeBuah("Pisang", "D000");
		public static KodeBuah Paprika = new KodeBuah("Paprika", "E000");
		public static KodeBuah Blackberry = new KodeBuah("Blackberry", "F000");
		public static KodeBuah Ceri = new KodeBuah("Ceri", "H000");
		public static KodeBuah Kelapa = new KodeBuah("Kelapa", "I000");
		public static KodeBuah Jagung = new KodeBuah("Jagung", "J000");
		public static KodeBuah Kurma = new KodeBuah("Kurma", "K000");
		public static KodeBuah Durian = new KodeBuah("Durian", "L000");
		public static KodeBuah Anggur = new KodeBuah("Anggur", "M000");
		public static KodeBuah Melon = new KodeBuah("Melon", "N000");
		public static KodeBuah Semangka = new KodeBuah("Semangka", "O000");

		// Menambahkan semua static objek kedalam array
		public static KodeBuah[] JenisBuah = new KodeBuah[]
		{
			Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry,
			Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka
		};

		private string buah;
		private string kode;

		public KodeBuah(string buah, string kode)
		{
			this.buah = buah;
			this.kode = kode;
		}

		public static KodeBuah GetKodeBuah(string kode)
		{
			// Loop tiap objek dari static field JenisBuah
			foreach (var b in JenisBuah)
			{
				// Mendapatkan objek KodeBuah sesuai kode yang di input
				if (b.GetKode() == kode) return b;
			}
			return null;
		}

		public string GetBuah()
		{
			return buah;
		}

		public string GetKode()
		{
			return kode;
		}


	}
}
