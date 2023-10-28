using iTextSharp.text;
using iTextSharp.text.pdf;
using KaloriTakipProgramı.Business.Formules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Document = iTextSharp.text.Document;

namespace Kalori_Takip___Diyet__Programı
{
	public partial class PersonalInformation : Form
	{
		private Guid Guid;
		public PersonalInformation()
		{
			Guid = Guid.NewGuid();
			InitializeComponent();
		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			OpeningPage openingPage = new OpeningPage();
			this.Hide();
			openingPage.ShowDialog();
		}
		string ad;
		string soyad;
		string cinsiyet;
		double kilo;
		double boy;
		double yas;
		double belcevresi;
		double boyunCevresi;
		double basenCevresi;
		private void btnHesapla_Click(object sender, EventArgs e)
		{
			ad = txtAd.Text;
			soyad = txtSoyad.Text;
			cinsiyet = rdbErkek.Checked ? "Erkek" : (rdbKadin.Checked ? "Kadın" : string.Empty);
			kilo = (double)nmrKilo.Value;
			boy = (double)nmrBoy.Value;
			yas = (double)nmrYas.Value;
			belcevresi = (double)nmrBelCevresi.Value;
			boyunCevresi = (double)nmrBoyunCevresi.Value;
			basenCevresi = (double)nmrBasenCevresi.Value;

			if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(cinsiyet) || kilo == 0 || boy == 0 || yas == 0 || belcevresi == 0 || boyunCevresi == 0 || basenCevresi == 0)
			{
				MessageBox.Show("Lütfen tüm bilgileri eksiksiz girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			lblVki.Text = Formul.HesaplaBMI(kilo, boy).ToString("0.00");
			lblYagOrani.Text = Formul.HesaplaVucutYagOrani(cinsiyet, kilo, boy, yas, belcevresi, boyunCevresi, basenCevresi).ToString("0.00");
			lblBazalMetabolizmaHizi.Text = Formul.HesaplaBMR(cinsiyet, kilo, boy, yas).ToString("0.00");

		}

		public void KaydetPdf(string ad, string soyad, string cinsiyet, double kilo, double boy, double yas)
		{
			string masaustuDizin = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			string pdfDosyaYolu = Path.Combine(masaustuDizin, $"{ad}{soyad}_{Guid}.pdf");


			iTextSharp.text.Document doc = new Document();
			PdfWriter.GetInstance(doc, new FileStream(pdfDosyaYolu, FileMode.Create));

			doc.Open();


			doc.Add(new Paragraph("Kullanici Bilgileri"));
			doc.Add(new Paragraph("Ad: " + ad));
			doc.Add(new Paragraph("Soyad: " + soyad));
			doc.Add(new Paragraph("Cinsiyet: " + cinsiyet));
			doc.Add(new Paragraph("Kilo: " + kilo.ToString()));
			doc.Add(new Paragraph("Boy: " + boy.ToString()));
			doc.Add(new Paragraph("Yas: " + yas.ToString()));
			doc.Add(new Paragraph("Vücut Kitle İndeksi: " + Formul.HesaplaBMI(kilo, boy).ToString("0.00")));
			doc.Add(new Paragraph("Bazal Metabolizma Hizi: " + Formul.HesaplaBMR(cinsiyet, kilo, boy, yas).ToString("0.00")));
			doc.Add(new Paragraph("Vücut Yag Orani: " + Formul.HesaplaVucutYagOrani(cinsiyet, kilo, boy, yas, belcevresi, boyunCevresi, basenCevresi).ToString("0.00")));

			doc.Close();
		}

		private void btnPdfOlarakKaydet_Click(object sender, EventArgs e)
		{
			KaydetPdf(ad, soyad, cinsiyet, kilo, boy, yas);

			MessageBox.Show("Kullanıcı bilgileri PDF olarak kaydedildi.");
		}


	}
}
