using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalori_Takip___Diyet__Programı.Extensions
{
	public static class LoadImages
	{
		public static Image LoadUserImage(string imagePath)
		{
			if (!string.IsNullOrEmpty(imagePath))
			{
				string fullImagePath = Path.Combine(Application.StartupPath, "UserImage", imagePath);

				if (File.Exists(fullImagePath))
				{
					using (FileStream stream = new FileStream(fullImagePath, FileMode.Open, FileAccess.Read))
					{
						return Image.FromStream(stream);
					}
				}
			}

			return Properties.Resources.defaultkullanici;
		}
		public static Image LoadFoodImage(string imagePath)
		{
			if (!string.IsNullOrEmpty(imagePath))
			{
				string fullImagePath = Path.Combine(Application.StartupPath, "FoodImage", imagePath);

				if (File.Exists(fullImagePath))
				{
					using (FileStream stream = new FileStream(fullImagePath, FileMode.Open, FileAccess.Read))
					{
						return Image.FromStream(stream);
					}
				}
			}

			return Properties.Resources.defaultyemek;
		}
	}
}
