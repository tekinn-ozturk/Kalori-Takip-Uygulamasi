using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Business.Formules
{
	public static class Formul
	{
		public static double HesaplaBMI(double kilo, double boy)
		{
			double vki = Math.Round(kilo / (boy * boy), 2);
			return vki;
		}

		public static double HesaplaVucutYagOrani(string cinsiyet, double kilo, double boy, double yas, double belCevresi, double boyunCevresi, double basenCevresi)
		{
			double vucutYagOrani = 0.0;

			if (cinsiyet.Equals("Erkek", StringComparison.OrdinalIgnoreCase))
			{
				// Erkekler için vücut yağ oranı hesaplama formülü
				vucutYagOrani = (86.01 * Math.Log10(belCevresi - boyunCevresi) - 70.041 * Math.Log10(boy) + 30.30) / 2.1;
				//vucutYagOrani = 495 / (1.0324 - 0.19077 * Math.Log10(belCevresi - boyunCevresi) + 0.15456 * Math.Log10(boy)) - 450
				;

			}
			if (cinsiyet.Equals("Kadın", StringComparison.OrdinalIgnoreCase))
			{
				// Kadınlar için vücut yağ oranı hesaplama formülü
				vucutYagOrani = ((163.205 * Math.Log10(belCevresi + basenCevresi - boyunCevresi) - 97.684 * Math.Log10(boy) - 78.387) / 2.1);
				//vucutYagOrani =495 / (1.29579 - 0.35004 * Math.Log10(belCevresi + basenCevresi - boyunCevresi) + 0.22100 * Math.Log10(boy)) - 450;
			}
			vucutYagOrani = Math.Round(vucutYagOrani, 2);
			return vucutYagOrani / 10;
		}






		public static double HesaplaBMR(string cinsiyet, double kilo, double boy, double yas)
		{
			double bmr = 0.0;

			if (cinsiyet.Equals("Erkek", StringComparison.OrdinalIgnoreCase))
			{
				// Erkekler için BMR hesaplama formülü (Harris-Benedict formülü)
				//bmr = 88.362 + (13.397 * kilo) + (4.799 * boy * 100) - (5.677 * yas);
				bmr = 66 + (13.7 * kilo) + (5 * boy * 100) - (6.8 * yas);
				
			}
			else if (cinsiyet.Equals("Kadın", StringComparison.OrdinalIgnoreCase))
			{
				// Kadınlar için BMR hesaplama formülü (Harris-Benedict formülü)
				//bmr = 447.593 + (9.247 * kilo) + (3.098 * boy * 100) - (4.330 * yas);
				bmr = 655 + (9.6 * kilo) + (1.85 * boy * 100) - (4.7 * yas);
			}
			bmr = Math.Round(bmr, 2);
			return bmr;
		}

		public static double HesaplaGunlukKaloriIhtiyaci(string cinsiyet, float kilo, float boy, int yas, float aktiviteFaktoru)
		{
			float gunlukKaloriIhtiyaci = 0.0f;

			if (cinsiyet.Equals("Erkek", StringComparison.OrdinalIgnoreCase))
			{
				// Erkekler için Mifflin-St Jeor Denklemi
				gunlukKaloriIhtiyaci = (float)((10 * kilo) + (6.25 * boy) - (5 * yas) + 5);
			}
			else if (cinsiyet.Equals("Kadın", StringComparison.OrdinalIgnoreCase))
			{
				// Kadınlar için Mifflin-St Jeor Denklemi
				gunlukKaloriIhtiyaci = (float)((10 * kilo) + (6.25 * boy) - (5 * yas) - 161);
			}

			gunlukKaloriIhtiyaci = gunlukKaloriIhtiyaci * aktiviteFaktoru;

			gunlukKaloriIhtiyaci = (float)Math.Round(gunlukKaloriIhtiyaci, 1);
			return gunlukKaloriIhtiyaci;
		}

		public static float HesaplaGunlukSuIhtiyaci(float kilo)
		{
			return kilo * 30;
		}
	}
}
