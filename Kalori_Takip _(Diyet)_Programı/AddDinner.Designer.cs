namespace Kalori_Takip___Diyet__Programı
{
	partial class AddDinner
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDinner));
			btnSil = new Button();
			btnEkle = new Button();
			grpAksamYemegiEkle = new GroupBox();
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
			pbxYemekResmi = new PictureBox();
			label3 = new Label();
			btnResimEkle = new Button();
			label2 = new Label();
			label5 = new Label();
			label6 = new Label();
			btnKaydet = new Button();
			label1 = new Label();
			txtUrunAra = new TextBox();
			txtMiktar = new TextBox();
			grpAksamYemegiEkle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxYemekResmi).BeginInit();
			SuspendLayout();
			// 
			// btnSil
			// 
			btnSil.BackColor = Color.DarkSeaGreen;
			btnSil.BackgroundImage = (Image)resources.GetObject("btnSil.BackgroundImage");
			btnSil.BackgroundImageLayout = ImageLayout.Stretch;
			btnSil.FlatAppearance.BorderSize = 0;
			btnSil.FlatStyle = FlatStyle.Popup;
			btnSil.Location = new Point(283, 264);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(33, 30);
			btnSil.TabIndex = 20;
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
			btnEkle.Location = new Point(283, 209);
			btnEkle.Name = "btnEkle";
			btnEkle.Size = new Size(33, 30);
			btnEkle.TabIndex = 21;
			btnEkle.UseVisualStyleBackColor = false;
			btnEkle.Click += btnEkle_Click;
			// 
			// grpAksamYemegiEkle
			// 
			grpAksamYemegiEkle.Controls.Add(lstUrunler);
			grpAksamYemegiEkle.Controls.Add(lstEklenenUrunler);
			grpAksamYemegiEkle.Controls.Add(pbxYemekResmi);
			grpAksamYemegiEkle.Controls.Add(label3);
			grpAksamYemegiEkle.Controls.Add(btnResimEkle);
			grpAksamYemegiEkle.Controls.Add(label2);
			grpAksamYemegiEkle.Controls.Add(label5);
			grpAksamYemegiEkle.Controls.Add(label6);
			grpAksamYemegiEkle.Controls.Add(btnKaydet);
			grpAksamYemegiEkle.Controls.Add(btnSil);
			grpAksamYemegiEkle.Controls.Add(label1);
			grpAksamYemegiEkle.Controls.Add(btnEkle);
			grpAksamYemegiEkle.Controls.Add(txtUrunAra);
			grpAksamYemegiEkle.Controls.Add(txtMiktar);
			grpAksamYemegiEkle.Location = new Point(12, 12);
			grpAksamYemegiEkle.Name = "grpAksamYemegiEkle";
			grpAksamYemegiEkle.Size = new Size(787, 504);
			grpAksamYemegiEkle.TabIndex = 19;
			grpAksamYemegiEkle.TabStop = false;
			grpAksamYemegiEkle.Text = "AKŞAM YEMEĞİ";
			// 
			// lstUrunler
			// 
			lstUrunler.BackColor = Color.PaleGoldenrod;
			lstUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader1 });
			lstUrunler.FullRowSelect = true;
			lstUrunler.GridLines = true;
			lstUrunler.Location = new Point(6, 130);
			lstUrunler.Name = "lstUrunler";
			lstUrunler.Size = new Size(271, 164);
			lstUrunler.TabIndex = 29;
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
			lstEklenenUrunler.Location = new Point(3, 300);
			lstEklenenUrunler.Name = "lstEklenenUrunler";
			lstEklenenUrunler.Size = new Size(775, 198);
			lstEklenenUrunler.TabIndex = 28;
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
			// pbxYemekResmi
			// 
			pbxYemekResmi.BorderStyle = BorderStyle.FixedSingle;
			pbxYemekResmi.Location = new Point(657, 22);
			pbxYemekResmi.Name = "pbxYemekResmi";
			pbxYemekResmi.Size = new Size(117, 134);
			pbxYemekResmi.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxYemekResmi.TabIndex = 37;
			pbxYemekResmi.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(502, 19);
			label3.Name = "label3";
			label3.Size = new Size(149, 19);
			label3.TabIndex = 36;
			label3.Text = "Resim Ekleyebilirsiniz";
			// 
			// btnResimEkle
			// 
			btnResimEkle.BackColor = Color.DarkSeaGreen;
			btnResimEkle.BackgroundImage = (Image)resources.GetObject("btnResimEkle.BackgroundImage");
			btnResimEkle.BackgroundImageLayout = ImageLayout.Stretch;
			btnResimEkle.FlatAppearance.BorderSize = 0;
			btnResimEkle.FlatStyle = FlatStyle.Popup;
			btnResimEkle.Location = new Point(745, 162);
			btnResimEkle.Name = "btnResimEkle";
			btnResimEkle.Size = new Size(33, 30);
			btnResimEkle.TabIndex = 35;
			btnResimEkle.UseVisualStyleBackColor = false;
			btnResimEkle.Click += btnResimEkle_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(407, 105);
			label2.Name = "label2";
			label2.Size = new Size(42, 19);
			label2.TabIndex = 22;
			label2.Text = "gram";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(283, 79);
			label5.Name = "label5";
			label5.Size = new Size(51, 19);
			label5.TabIndex = 22;
			label5.Text = "Miktar";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(6, 79);
			label6.Name = "label6";
			label6.Size = new Size(158, 19);
			label6.TabIndex = 23;
			label6.Text = "Buradan Arayabilirsiniz";
			// 
			// btnKaydet
			// 
			btnKaydet.BackColor = Color.DarkSeaGreen;
			btnKaydet.BackgroundImage = (Image)resources.GetObject("btnKaydet.BackgroundImage");
			btnKaydet.BackgroundImageLayout = ImageLayout.Stretch;
			btnKaydet.FlatAppearance.BorderSize = 0;
			btnKaydet.FlatStyle = FlatStyle.Popup;
			btnKaydet.Location = new Point(746, 264);
			btnKaydet.Name = "btnKaydet";
			btnKaydet.Size = new Size(33, 30);
			btnKaydet.TabIndex = 20;
			btnKaydet.UseVisualStyleBackColor = false;
			btnKaydet.Click += btnKaydet_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(6, 42);
			label1.Name = "label1";
			label1.Size = new Size(176, 23);
			label1.TabIndex = 2;
			label1.Text = "AKŞAM YEMEĞİ EKLE";
			// 
			// txtUrunAra
			// 
			txtUrunAra.BackColor = Color.PaleGoldenrod;
			txtUrunAra.Location = new Point(6, 101);
			txtUrunAra.Name = "txtUrunAra";
			txtUrunAra.Size = new Size(271, 23);
			txtUrunAra.TabIndex = 12;
			txtUrunAra.TextChanged += txtUrunAra_TextChanged;
			// 
			// txtMiktar
			// 
			txtMiktar.BackColor = Color.PaleGoldenrod;
			txtMiktar.Location = new Point(283, 101);
			txtMiktar.Name = "txtMiktar";
			txtMiktar.Size = new Size(118, 23);
			txtMiktar.TabIndex = 12;
			// 
			// AddDinner
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(803, 527);
			Controls.Add(grpAksamYemegiEkle);
			Name = "AddDinner";
			Text = "AddDinner";
			grpAksamYemegiEkle.ResumeLayout(false);
			grpAksamYemegiEkle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbxYemekResmi).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnSil;
		private Button btnEkle;
		private GroupBox grpAksamYemegiEkle;
		private Label label1;
		private ListView lstEklenenUrunler;
		private ListView lstUrunler;
		private TextBox txtUrunAra;
		private TextBox txtMiktar;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader1;
		private Label label5;
		private Label label6;
		private Label label2;
		private Button btnKaydet;
		private PictureBox pbxYemekResmi;
		private Label label3;
		private Button btnResimEkle;
		private ColumnHeader columnHeader9;
		private ColumnHeader columnHeader8;
	}
}