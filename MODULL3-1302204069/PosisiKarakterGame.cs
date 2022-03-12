using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULL3_1302204069
{
    internal class PosisiKarakterGame
    {

		public enum StatePosisi
		{
			Berdiri,
			Tengkurap,
			Jongkok,
			Terbang
		}

		public enum Tombol
		{
			W,
			S,
			X
		}

		private StatePosisi statePosisi;

		public PosisiKarakterGame()
		{
			// Membuat state posisi awal adalah Berdiri
			this.statePosisi = StatePosisi.Berdiri;
		}

		// Quick action tekan tombol W
		public void TekanW()
		{
			Tekan(Tombol.W);
		}

		// Quick action tekan tombol S
		public void TekanS()
		{
			Tekan(Tombol.S);
		}

		// Quick action tekan tombol X
		public void TekanX()
		{
			Tekan(Tombol.X);
		}

		// Merubah state objek saat method Tekan dipanggil
		public void Tekan(Tombol tombol)
		{
			// State posisi sebelum diubah
			StatePosisi temp = this.statePosisi;

			// Cek jenis Tombol yang ditekan
			switch (tombol)
			{
				case Tombol.W:

					Console.WriteLine("Tombol arah atas ditekan");

					// Ubah state posisi Berdiri -> Terbang
					if (statePosisi == StatePosisi.Berdiri)
					{
						statePosisi = StatePosisi.Terbang;
					}
					// Ubah state posisi Jongkok -> Berdiri
					else if (statePosisi == StatePosisi.Jongkok)
					{
						statePosisi = StatePosisi.Berdiri;
					}
					// Ubah state posisi Tengkurap -> Jongkok
					else if (statePosisi == StatePosisi.Tengkurap)
					{
						statePosisi = StatePosisi.Jongkok;
					}
					break;

				case Tombol.S:

					Console.WriteLine("Tombol arah bawah ditekan");

					// Ubah state posisi Berdiri -> Jongkok
					if (statePosisi == StatePosisi.Berdiri)
					{
						statePosisi = StatePosisi.Jongkok;
					}
					// Ubah state posisi Terbang -> Berdiri
					else if (statePosisi == StatePosisi.Terbang)
					{
						statePosisi = StatePosisi.Berdiri;
					}
					// Ubah state posisi Jongkok -> Tengkurap
					else if (statePosisi == StatePosisi.Jongkok)
					{
						statePosisi = StatePosisi.Tengkurap;
					}
					break;

				case Tombol.X:
					// Ubah state posisi Terbang -> Jongkok
					if (statePosisi == StatePosisi.Terbang)
					{
						statePosisi = StatePosisi.Jongkok;
					}
					break;
			}

			// Tampilkan perubahan state posisi lama ke state posisi baru
			Console.WriteLine("Posisi: " + temp + " -> " + this.statePosisi);
		}

	}
}
