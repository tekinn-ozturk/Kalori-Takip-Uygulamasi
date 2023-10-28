namespace Kalori_Takip___Diyet__Programı
{
	partial class AddLunch
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLunch));
			grpOgleYemegiEkle = new GroupBox();
			pbxYemekResmi = new PictureBox();
			label3 = new Label();
			btnResimEkle = new Button();
			label2 = new Label();
			label5 = new Label();
			label6 = new Label();
			txtMiktar = new TextBox();
			btnKaydet = new Button();
			txtUrunAra = new TextBox();
			btnSil = new Button();
			btnEkle = new Button();
			label1 = new Label();
			lstUrunler = new ListView();
			columnHeader9 = new ColumnHeader();
			columnHeader1 = new ColumnHeader();
			lstEklenenUrunler = new ListView();
			columnHeader8 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			grpOgleYemegiEkle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxYemekResmi).BeginInit();
			SuspendLayout();
			// 
			// grpOgleYemegiEkle
			// 
			grpOgleYemegiEkle.Controls.Add(lstUrunler);
			grpOgleYemegiEkle.Controls.Add(lstEklenenUrunler);
			grpOgleYemegiEkle.Controls.Add(pbxYemekResmi);
			grpOgleYemegiEkle.Controls.Add(label3);
			grpOgleYemegiEkle.Controls.Add(btnResimEkle);
			grpOgleYemegiEkle.Controls.Add(label2);
			grpOgleYemegiEkle.Controls.Add(label5);
			grpOgleYemegiEkle.Controls.Add(label6);
			grpOgleYemegiEkle.Controls.Add(txtMiktar);
			grpOgleYemegiEkle.Controls.Add(btnKaydet);
			grpOgleYemegiEkle.Controls.Add(txtUrunAra);
			grpOgleYemegiEkle.Controls.Add(btnSil);
			grpOgleYemegiEkle.Controls.Add(btnEkle);
			grpOgleYemegiEkle.Controls.Add(label1);
			grpOgleYemegiEkle.Location = new Point(0, 33);
			grpOgleYemegiEkle.Name = "grpOgleYemegiEkle";
			grpOgleYemegiEkle.Size = new Size(774, 481);
			grpOgleYemegiEkle.TabIndex = 16;
			grpOgleYemegiEkle.TabStop = false;
			grpOgleYemegiEkle.Text = "ÖĞLE YEMEĞİ EKLE";
			// 
			// pbxYemekResmi
			// 
			pbxYemekResmi.BorderStyle = BorderStyle.FixedSingle;
			pbxYemekResmi.Location = new Point(651, 19);
			pbxYemekResmi.Name = "pbxYemekResmi";
			pbxYemekResmi.Size = new Size(117, 134);
			pbxYemekResmi.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxYemekResmi.TabIndex = 46;
			pbxYemekResmi.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(496, 16);
			label3.Name = "label3";
			label3.Size = new Size(149, 19);
			label3.TabIndex = 45;
			label3.Text = "Resim Ekleyebilirsiniz";
			// 
			// btnResimEkle
			// 
			btnResimEkle.BackColor = Color.DarkSeaGreen;
			btnResimEkle.BackgroundImage = (Image)resources.GetObject("btnResimEkle.BackgroundImage");
			btnResimEkle.BackgroundImageLayout = ImageLayout.Stretch;
			btnResimEkle.FlatAppearance.BorderSize = 0;
			btnResimEkle.FlatStyle = FlatStyle.Popup;
			btnResimEkle.Location = new Point(735, 159);
			btnResimEkle.Name = "btnResimEkle";
			btnResimEkle.Size = new Size(33, 30);
			btnResimEkle.TabIndex = 44;
			btnResimEkle.UseVisualStyleBackColor = false;
			btnResimEkle.Click += btnResimEkle_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(401, 75);
			label2.Name = "label2";
			label2.Size = new Size(42, 19);
			label2.TabIndex = 41;
			label2.Text = "gram";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(277, 49);
			label5.Name = "label5";
			label5.Size = new Size(51, 19);
			label5.TabIndex = 42;
			label5.Text = "Miktar";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(0, 49);
			label6.Name = "label6";
			label6.Size = new Size(158, 19);
			label6.TabIndex = 43;
			label6.Text = "Buradan Arayabilirsiniz";
			// 
			// txtMiktar
			// 
			txtMiktar.BackColor = Color.PaleGoldenrod;
			txtMiktar.Location = new Point(277, 71);
			txtMiktar.Name = "txtMiktar";
			txtMiktar.Size = new Size(118, 23);
			txtMiktar.TabIndex = 35;
			// 
			// btnKaydet
			// 
			btnKaydet.BackColor = Color.DarkSeaGreen;
			btnKaydet.BackgroundImage = (Image)resources.GetObject("btnKaydet.BackgroundImage");
			btnKaydet.BackgroundImageLayout = ImageLayout.Stretch;
			btnKaydet.FlatAppearance.BorderSize = 0;
			btnKaydet.FlatStyle = FlatStyle.Popup;
			btnKaydet.Location = new Point(740, 234);
			btnKaydet.Name = "btnKaydet";
			btnKaydet.Size = new Size(33, 30);
			btnKaydet.TabIndex = 38;
			btnKaydet.UseVisualStyleBackColor = false;
			btnKaydet.Click += btnKaydet_Click;
			// 
			// txtUrunAra
			// 
			txtUrunAra.BackColor = Color.PaleGoldenrod;
			txtUrunAra.Location = new Point(0, 71);
			txtUrunAra.Name = "txtUrunAra";
			txtUrunAra.Size = new Size(271, 23);
			txtUrunAra.TabIndex = 34;
			txtUrunAra.TextChanged += txtUrunAra_TextChanged;
			// 
			// btnSil
			// 
			btnSil.BackColor = Color.DarkSeaGreen;
			btnSil.BackgroundImage = (Image)resources.GetObject("btnSil.BackgroundImage");
			btnSil.BackgroundImageLayout = ImageLayout.Stretch;
			btnSil.FlatAppearance.BorderSize = 0;
			btnSil.FlatStyle = FlatStyle.Popup;
			btnSil.Location = new Point(277, 234);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(33, 30);
			btnSil.TabIndex = 39;
			btnSil.UseVisualStyleBackColor = false;
			btnSil.Click += btnSil_Click;
			// 
			// btnEkle
			// 
			btnEkle.BackColor = Color.DarkSeaGreen;
			btnEkle.BackgroundImage = (Image)resources.GetObject("btnEkle.BackgroundImage");
			btnEkle.BackgroundImageLayout = ImageLayout.Stretch;
			btnEkle.FlatAppearance.BorderSize = 0;
			btnEkle.FlatStyle = FlatStyle.Popup;
			btnEkle.Location = new Point(277, 179);
			btnEkle.Name = "btnEkle";
			btnEkle.Size = new Size(33, 30);
			btnEkle.TabIndex = 40;
			btnEkle.UseVisualStyleBackColor = false;
			btnEkle.Click += btnEkle_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(6, 19);
			label1.Name = "label1";
			label1.Size = new Size(162, 23);
			label1.TabIndex = 2;
			label1.Text = "ÖĞLE YEMEĞİ  EKLE";
			// 
			// lstUrunler
			// 
			lstUrunler.BackColor = Color.PaleGoldenrod;
			lstUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader1 });
			lstUrunler.FullRowSelect = true;
			lstUrunler.GridLines = true;
			lstUrunler.Location = new Point(0, 100);
			lstUrunler.Name = "lstUrunler";
			lstUrunler.Size = new Size(271, 164);
			lstUrunler.TabIndex = 48;
			lstUrunler.UseCompatibleStateImageBehavior = false;
			lstUrunler.View = View.Details;
			// 
			// columnHeader9
			// 
			columnHeader9.Text = "ID";
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Ürün Adı";
			columnHeader1.Width = 260;
			// 
			// lstEklenenUrunler
			// 
			lstEklenenUrunler.BackColor = Color.PaleGoldenrod;
			lstEklenenUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
			lstEklenenUrunler.FullRowSelect = true;
			lstEklenenUrunler.GridLines = true;
			lstEklenenUrunler.Location = new Point(-3, 270);
			lstEklenenUrunler.Name = "lstEklenenUrunler";
			lstEklenenUrunler.Size = new Size(775, 198);
			lstEklenenUrunler.TabIndex = 47;
			lstEklenenUrunler.UseCompatibleStateImageBehavior = false;
			lstEklenenUrunler.View = View.Details;
			// 
			// columnHeader8
			// 
			columnHeader8.Text = "ID";
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Ürün Adı";
			columnHeader2.Width = 125;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Miktar";
			columnHeader3.Width = 125;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Kalori";
			columnHeader4.Width = 125;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Protein";
			columnHeader5.Width = 125;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Yağ";
			columnHeader6.Width = 125;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "Karbonhidrat";
			columnHeader7.Width = 125;
			// 
			// AddLunch
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(775, 526);
			Controls.Add(grpOgleYemegiEkle);
			Name = "AddLunch";
			Text = "AddLunch";
			grpOgleYemegiEkle.ResumeLayout(false);
			grpOgleYemegiEkle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbxYemekResmi).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox grpOgleYemegiEkle;
		private Label label1;
		private Label label2;
		private Label label5;
		private Label label6;
		private TextBox txtMiktar;
		private Button btnKaydet;
		private TextBox txtUrunAra;
		private Button btnSil;
		private Button btnEkle;
		private PictureBox pbxYemekResmi;
		private Label label3;
		private Button btnResimEkle;
		private ListView lstUrunler;
		private ColumnHeader columnHeader9;
		private ColumnHeader columnHeader1;
		private ListView lstEklenenUrunler;
		private ColumnHeader columnHeader8;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
	}
}