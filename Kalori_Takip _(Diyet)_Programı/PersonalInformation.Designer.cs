namespace Kalori_Takip___Diyet__Programı
{
	partial class PersonalInformation
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInformation));
			grpKisiselBilgiler = new GroupBox();
			label7 = new Label();
			txtAd = new TextBox();
			txtSoyad = new TextBox();
			label6 = new Label();
			rdbKadin = new RadioButton();
			rdbErkek = new RadioButton();
			label5 = new Label();
			nmrBoyunCevresi = new NumericUpDown();
			nmrBelCevresi = new NumericUpDown();
			nmrBasenCevresi = new NumericUpDown();
			nmrYas = new NumericUpDown();
			nmrKilo = new NumericUpDown();
			label4 = new Label();
			label2 = new Label();
			label1 = new Label();
			nmrBoy = new NumericUpDown();
			label9 = new Label();
			label8 = new Label();
			label3 = new Label();
			btnHesapla = new Button();
			grpSonuclar = new GroupBox();
			label10 = new Label();
			lblBazalMetabolizmaHizi = new Label();
			lblYagOrani = new Label();
			label11 = new Label();
			lblVki = new Label();
			label12 = new Label();
			btnPdfOlarakKaydet = new Button();
			btnGeriDon = new Button();
			grpKisiselBilgiler.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nmrBoyunCevresi).BeginInit();
			((System.ComponentModel.ISupportInitialize)nmrBelCevresi).BeginInit();
			((System.ComponentModel.ISupportInitialize)nmrBasenCevresi).BeginInit();
			((System.ComponentModel.ISupportInitialize)nmrYas).BeginInit();
			((System.ComponentModel.ISupportInitialize)nmrKilo).BeginInit();
			((System.ComponentModel.ISupportInitialize)nmrBoy).BeginInit();
			grpSonuclar.SuspendLayout();
			SuspendLayout();
			// 
			// grpKisiselBilgiler
			// 
			grpKisiselBilgiler.BackColor = Color.Transparent;
			grpKisiselBilgiler.Controls.Add(label7);
			grpKisiselBilgiler.Controls.Add(txtAd);
			grpKisiselBilgiler.Controls.Add(txtSoyad);
			grpKisiselBilgiler.Controls.Add(label6);
			grpKisiselBilgiler.Controls.Add(rdbKadin);
			grpKisiselBilgiler.Controls.Add(rdbErkek);
			grpKisiselBilgiler.Controls.Add(label5);
			grpKisiselBilgiler.Controls.Add(nmrBoyunCevresi);
			grpKisiselBilgiler.Controls.Add(nmrBelCevresi);
			grpKisiselBilgiler.Controls.Add(nmrBasenCevresi);
			grpKisiselBilgiler.Controls.Add(nmrYas);
			grpKisiselBilgiler.Controls.Add(nmrKilo);
			grpKisiselBilgiler.Controls.Add(label4);
			grpKisiselBilgiler.Controls.Add(label2);
			grpKisiselBilgiler.Controls.Add(label1);
			grpKisiselBilgiler.Controls.Add(nmrBoy);
			grpKisiselBilgiler.Controls.Add(label9);
			grpKisiselBilgiler.Controls.Add(label8);
			grpKisiselBilgiler.Controls.Add(label3);
			grpKisiselBilgiler.FlatStyle = FlatStyle.Flat;
			grpKisiselBilgiler.Location = new Point(12, 36);
			grpKisiselBilgiler.Name = "grpKisiselBilgiler";
			grpKisiselBilgiler.Size = new Size(350, 395);
			grpKisiselBilgiler.TabIndex = 10;
			grpKisiselBilgiler.TabStop = false;
			grpKisiselBilgiler.Text = "Kişisel Bilgiler";

			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.Transparent;
			label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label7.ForeColor = Color.Transparent;
			label7.Location = new Point(15, 42);
			label7.Name = "label7";
			label7.Size = new Size(25, 25);
			label7.TabIndex = 28;
			label7.Text = "Ad";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			label7.UseCompatibleTextRendering = true;
			// 
			// txtAd
			// 
			txtAd.BackColor = Color.White;
			txtAd.BorderStyle = BorderStyle.FixedSingle;
			txtAd.Location = new Point(125, 42);
			txtAd.Name = "txtAd";
			txtAd.Size = new Size(219, 23);
			txtAd.TabIndex = 30;
			// 
			// txtSoyad
			// 
			txtSoyad.BackColor = Color.White;
			txtSoyad.BorderStyle = BorderStyle.FixedSingle;
			txtSoyad.Location = new Point(125, 82);
			txtSoyad.Name = "txtSoyad";
			txtSoyad.Size = new Size(219, 23);
			txtSoyad.TabIndex = 31;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = Color.Transparent;
			label6.Location = new Point(15, 82);
			label6.Name = "label6";
			label6.Size = new Size(47, 25);
			label6.TabIndex = 29;
			label6.Text = "Soyad";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			label6.UseCompatibleTextRendering = true;
			// 
			// rdbKadin
			// 
			rdbKadin.AutoSize = true;
			rdbKadin.Location = new Point(211, 122);
			rdbKadin.Name = "rdbKadin";
			rdbKadin.Size = new Size(55, 19);
			rdbKadin.TabIndex = 27;
			rdbKadin.TabStop = true;
			rdbKadin.Text = "Kadın";
			rdbKadin.UseVisualStyleBackColor = true;
			// 
			// rdbErkek
			// 
			rdbErkek.AutoSize = true;
			rdbErkek.Location = new Point(133, 122);
			rdbErkek.Name = "rdbErkek";
			rdbErkek.Size = new Size(53, 19);
			rdbErkek.TabIndex = 26;
			rdbErkek.TabStop = true;
			rdbErkek.Text = "Erkek";
			rdbErkek.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = Color.Transparent;
			label5.Location = new Point(16, 117);
			label5.Name = "label5";
			label5.Size = new Size(60, 25);
			label5.TabIndex = 25;
			label5.Text = "Cinsiyet";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			label5.UseCompatibleTextRendering = true;
			// 
			// nmrBoyunCevresi
			// 
			nmrBoyunCevresi.Location = new Point(126, 361);
			nmrBoyunCevresi.Name = "nmrBoyunCevresi";
			nmrBoyunCevresi.Size = new Size(219, 23);
			nmrBoyunCevresi.TabIndex = 6;
			// 
			// nmrBelCevresi
			// 
			nmrBelCevresi.Location = new Point(126, 321);
			nmrBelCevresi.Name = "nmrBelCevresi";
			nmrBelCevresi.Size = new Size(219, 23);
			nmrBelCevresi.TabIndex = 6;
			// 
			// nmrBasenCevresi
			// 
			nmrBasenCevresi.Location = new Point(126, 284);
			nmrBasenCevresi.Name = "nmrBasenCevresi";
			nmrBasenCevresi.Size = new Size(219, 23);
			nmrBasenCevresi.TabIndex = 6;
			// 
			// nmrYas
			// 
			nmrYas.Location = new Point(126, 239);
			nmrYas.Name = "nmrYas";
			nmrYas.Size = new Size(219, 23);
			nmrYas.TabIndex = 6;
			// 
			// nmrKilo
			// 
			nmrKilo.Location = new Point(126, 196);
			nmrKilo.Name = "nmrKilo";
			nmrKilo.Size = new Size(219, 23);
			nmrKilo.TabIndex = 6;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = Color.Transparent;
			label4.Location = new Point(7, 361);
			label4.Name = "label4";
			label4.Size = new Size(103, 25);
			label4.TabIndex = 4;
			label4.Text = "Boyun Çevresi";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			label4.UseCompatibleTextRendering = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Transparent;
			label2.Location = new Point(7, 321);
			label2.Name = "label2";
			label2.Size = new Size(81, 25);
			label2.TabIndex = 4;
			label2.Text = "Bel Çevresi";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			label2.UseCompatibleTextRendering = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Transparent;
			label1.Location = new Point(7, 282);
			label1.Name = "label1";
			label1.Size = new Size(100, 25);
			label1.TabIndex = 4;
			label1.Text = "Basen Çevresi";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.UseCompatibleTextRendering = true;
			// 
			// nmrBoy
			// 
			nmrBoy.DecimalPlaces = 2;
			nmrBoy.Increment = new decimal(new int[] { 10, 0, 0, 0 });
			nmrBoy.Location = new Point(126, 154);
			nmrBoy.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
			nmrBoy.Minimum = new decimal(new int[] { 100, 0, 0, 131072 });
			nmrBoy.Name = "nmrBoy";
			nmrBoy.Size = new Size(219, 23);
			nmrBoy.TabIndex = 6;
			nmrBoy.Value = new decimal(new int[] { 100, 0, 0, 131072 });
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = Color.Transparent;
			label9.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label9.ForeColor = Color.Transparent;
			label9.Location = new Point(16, 237);
			label9.Name = "label9";
			label9.Size = new Size(29, 25);
			label9.TabIndex = 4;
			label9.Text = "Yaş";
			label9.TextAlign = ContentAlignment.MiddleCenter;
			label9.UseCompatibleTextRendering = true;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = Color.Transparent;
			label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label8.ForeColor = Color.Transparent;
			label8.Location = new Point(16, 196);
			label8.Name = "label8";
			label8.Size = new Size(32, 25);
			label8.TabIndex = 4;
			label8.Text = "Kilo";
			label8.TextAlign = ContentAlignment.MiddleCenter;
			label8.UseCompatibleTextRendering = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.Transparent;
			label3.Location = new Point(16, 152);
			label3.Name = "label3";
			label3.Size = new Size(32, 25);
			label3.TabIndex = 4;
			label3.Text = "Boy";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			label3.UseCompatibleTextRendering = true;
			// 
			// btnHesapla
			// 
			btnHesapla.BackColor = Color.Transparent;
			btnHesapla.FlatStyle = FlatStyle.Popup;
			btnHesapla.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnHesapla.ForeColor = SystemColors.ActiveCaptionText;
			btnHesapla.Location = new Point(70, 437);
			btnHesapla.Name = "btnHesapla";
			btnHesapla.Size = new Size(224, 32);
			btnHesapla.TabIndex = 22;
			btnHesapla.Text = "H E S A P L A";
			btnHesapla.UseVisualStyleBackColor = false;
			btnHesapla.Click += btnHesapla_Click;
			// 
			// grpSonuclar
			// 
			grpSonuclar.BackColor = Color.Transparent;
			grpSonuclar.Controls.Add(label10);
			grpSonuclar.Controls.Add(lblBazalMetabolizmaHizi);
			grpSonuclar.Controls.Add(lblYagOrani);
			grpSonuclar.Controls.Add(label11);
			grpSonuclar.Controls.Add(lblVki);
			grpSonuclar.Controls.Add(label12);
			grpSonuclar.FlatStyle = FlatStyle.Flat;
			grpSonuclar.Location = new Point(12, 466);
			grpSonuclar.Name = "grpSonuclar";
			grpSonuclar.Size = new Size(350, 177);
			grpSonuclar.TabIndex = 10;
			grpSonuclar.TabStop = false;
			grpSonuclar.Text = "Sonuçlar";

			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = Color.Transparent;
			label10.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label10.ForeColor = Color.Transparent;
			label10.Location = new Point(6, 134);
			label10.Name = "label10";
			label10.Size = new Size(165, 25);
			label10.TabIndex = 4;
			label10.Text = "Bazal Metabolizma Hızı";
			label10.TextAlign = ContentAlignment.MiddleCenter;
			label10.UseCompatibleTextRendering = true;
			// 
			// lblBazalMetabolizmaHizi
			// 
			lblBazalMetabolizmaHizi.AutoSize = true;
			lblBazalMetabolizmaHizi.BackColor = Color.Transparent;
			lblBazalMetabolizmaHizi.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblBazalMetabolizmaHizi.ForeColor = Color.Transparent;
			lblBazalMetabolizmaHizi.Location = new Point(203, 134);
			lblBazalMetabolizmaHizi.Name = "lblBazalMetabolizmaHizi";
			lblBazalMetabolizmaHizi.Size = new Size(14, 25);
			lblBazalMetabolizmaHizi.TabIndex = 4;
			lblBazalMetabolizmaHizi.Text = "0";
			lblBazalMetabolizmaHizi.TextAlign = ContentAlignment.MiddleCenter;
			lblBazalMetabolizmaHizi.UseCompatibleTextRendering = true;
			// 
			// lblYagOrani
			// 
			lblYagOrani.AutoSize = true;
			lblYagOrani.BackColor = Color.Transparent;
			lblYagOrani.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblYagOrani.ForeColor = Color.Transparent;
			lblYagOrani.Location = new Point(203, 93);
			lblYagOrani.Name = "lblYagOrani";
			lblYagOrani.Size = new Size(14, 25);
			lblYagOrani.TabIndex = 4;
			lblYagOrani.Text = "0";
			lblYagOrani.TextAlign = ContentAlignment.MiddleCenter;
			lblYagOrani.UseCompatibleTextRendering = true;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.BackColor = Color.Transparent;
			label11.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label11.ForeColor = Color.Transparent;
			label11.Location = new Point(6, 93);
			label11.Name = "label11";
			label11.Size = new Size(116, 25);
			label11.TabIndex = 4;
			label11.Text = "Vucüt Yağ Oranı";
			label11.TextAlign = ContentAlignment.MiddleCenter;
			label11.UseCompatibleTextRendering = true;
			// 
			// lblVki
			// 
			lblVki.AutoSize = true;
			lblVki.BackColor = Color.Transparent;
			lblVki.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblVki.ForeColor = Color.Transparent;
			lblVki.Location = new Point(203, 48);
			lblVki.Name = "lblVki";
			lblVki.Size = new Size(14, 25);
			lblVki.TabIndex = 4;
			lblVki.Text = "0";
			lblVki.TextAlign = ContentAlignment.MiddleCenter;
			lblVki.UseCompatibleTextRendering = true;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.BackColor = Color.Transparent;
			label12.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label12.ForeColor = Color.Transparent;
			label12.Location = new Point(6, 48);
			label12.Name = "label12";
			label12.Size = new Size(133, 25);
			label12.TabIndex = 4;
			label12.Text = "Vücut Kitle İndeksi";
			label12.TextAlign = ContentAlignment.MiddleCenter;
			label12.UseCompatibleTextRendering = true;
			// 
			// btnPdfOlarakKaydet
			// 
			btnPdfOlarakKaydet.BackColor = Color.Transparent;
			btnPdfOlarakKaydet.FlatStyle = FlatStyle.Popup;
			btnPdfOlarakKaydet.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnPdfOlarakKaydet.ForeColor = SystemColors.ActiveCaptionText;
			btnPdfOlarakKaydet.Location = new Point(40, 649);
			btnPdfOlarakKaydet.Name = "btnPdfOlarakKaydet";
			btnPdfOlarakKaydet.Size = new Size(273, 32);
			btnPdfOlarakKaydet.TabIndex = 22;
			btnPdfOlarakKaydet.Text = "RAPORU PDF OLARAK KAYDET";
			btnPdfOlarakKaydet.UseVisualStyleBackColor = false;
			btnPdfOlarakKaydet.Click += btnPdfOlarakKaydet_Click;
			// 
			// btnGeriDon
			// 
			btnGeriDon.BackColor = Color.Transparent;
			btnGeriDon.BackgroundImage = (Image)resources.GetObject("btnGeriDon.BackgroundImage");
			btnGeriDon.BackgroundImageLayout = ImageLayout.Stretch;
			btnGeriDon.FlatAppearance.BorderSize = 0;
			btnGeriDon.FlatStyle = FlatStyle.Popup;
			btnGeriDon.Location = new Point(12, 3);
			btnGeriDon.Name = "btnGeriDon";
			btnGeriDon.Size = new Size(30, 27);
			btnGeriDon.TabIndex = 23;
			btnGeriDon.UseVisualStyleBackColor = false;
			btnGeriDon.Click += btnGeriDon_Click;
			// 
			// PersonalInformation
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(374, 685);
			Controls.Add(btnGeriDon);
			Controls.Add(btnPdfOlarakKaydet);
			Controls.Add(btnHesapla);
			Controls.Add(grpSonuclar);
			Controls.Add(grpKisiselBilgiler);
			ForeColor = Color.Transparent;
			Name = "PersonalInformation";
			Text = "PersonalInformation";
			grpKisiselBilgiler.ResumeLayout(false);
			grpKisiselBilgiler.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nmrBoyunCevresi).EndInit();
			((System.ComponentModel.ISupportInitialize)nmrBelCevresi).EndInit();
			((System.ComponentModel.ISupportInitialize)nmrBasenCevresi).EndInit();
			((System.ComponentModel.ISupportInitialize)nmrYas).EndInit();
			((System.ComponentModel.ISupportInitialize)nmrKilo).EndInit();
			((System.ComponentModel.ISupportInitialize)nmrBoy).EndInit();
			grpSonuclar.ResumeLayout(false);
			grpSonuclar.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox grpKisiselBilgiler;
		private NumericUpDown nmrYas;
		private NumericUpDown nmrKilo;
		private NumericUpDown nmrBoy;
		private Label label9;
		private Label label8;
		private Label label3;
		private NumericUpDown nmrBasenCevresi;
		private Label label1;
		private NumericUpDown nmrBoyunCevresi;
		private NumericUpDown nmrBelCevresi;
		private Label label4;
		private Label label2;
		private Button btnHesapla;
		private GroupBox grpSonuclar;
		private Label label10;
		private Label lblYagOrani;
		private Label label11;
		private Label lblVki;
		private Label label12;
		private Label lblBazalMetabolizmaHizi;
		private Button btnPdfOlarakKaydet;
		private Button btnGeriDon;
		private RadioButton rdbKadin;
		private RadioButton rdbErkek;
		private Label label5;
		private Label label7;
		private TextBox txtAd;
		private TextBox txtSoyad;
		private Label label6;
	}
}