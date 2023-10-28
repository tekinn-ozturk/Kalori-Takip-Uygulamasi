namespace Kalori_Takip___Diyet__Programı
{
	partial class UserHomePage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHomePage));
			label1 = new Label();
			lblKisiAdi = new Label();
			btnYemekMiKacKolari = new Button();
			btnSuTakibi = new Button();
			btnKaloriTakibi = new Button();
			btnRaporlar = new Button();
			pbxUserImage = new PictureBox();
			btnProfil = new Button();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pbxUserImage).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(117, 23);
			label1.TabIndex = 0;
			label1.Text = "HOŞGELDİNİZ";
			// 
			// lblKisiAdi
			// 
			lblKisiAdi.AutoSize = true;
			lblKisiAdi.BackColor = Color.Transparent;
			lblKisiAdi.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblKisiAdi.Location = new Point(145, 9);
			lblKisiAdi.Name = "lblKisiAdi";
			lblKisiAdi.Size = new Size(0, 23);
			lblKisiAdi.TabIndex = 0;
			// 
			// btnYemekMiKacKolari
			// 
			btnYemekMiKacKolari.BackColor = Color.PaleGoldenrod;
			btnYemekMiKacKolari.Font = new Font("Calibri", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
			btnYemekMiKacKolari.Location = new Point(101, 239);
			btnYemekMiKacKolari.Name = "btnYemekMiKacKolari";
			btnYemekMiKacKolari.Size = new Size(174, 58);
			btnYemekMiKacKolari.TabIndex = 2;
			btnYemekMiKacKolari.Text = "Yemek mi ? Kaç Kalori ?";
			btnYemekMiKacKolari.UseVisualStyleBackColor = false;
			btnYemekMiKacKolari.Click += btnYemekMiKacKolari_Click;
			// 
			// btnSuTakibi
			// 
			btnSuTakibi.BackColor = Color.PaleGoldenrod;
			btnSuTakibi.Font = new Font("Calibri", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
			btnSuTakibi.Location = new Point(101, 303);
			btnSuTakibi.Name = "btnSuTakibi";
			btnSuTakibi.Size = new Size(174, 58);
			btnSuTakibi.TabIndex = 2;
			btnSuTakibi.Text = "Bugün Suyunu İçtin mi ?";
			btnSuTakibi.UseVisualStyleBackColor = false;
			btnSuTakibi.Click += btnSuTakibi_Click;
			// 
			// btnKaloriTakibi
			// 
			btnKaloriTakibi.BackColor = Color.PaleGoldenrod;
			btnKaloriTakibi.Font = new Font("Calibri", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
			btnKaloriTakibi.Location = new Point(101, 367);
			btnKaloriTakibi.Name = "btnKaloriTakibi";
			btnKaloriTakibi.Size = new Size(174, 58);
			btnKaloriTakibi.TabIndex = 3;
			btnKaloriTakibi.Text = "Kalori Takibi";
			btnKaloriTakibi.UseVisualStyleBackColor = false;
			btnKaloriTakibi.Click += btnKaloriTakibi_Click;
			// 
			// btnRaporlar
			// 
			btnRaporlar.BackColor = Color.PaleGoldenrod;
			btnRaporlar.Font = new Font("Calibri", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
			btnRaporlar.Location = new Point(101, 431);
			btnRaporlar.Name = "btnRaporlar";
			btnRaporlar.Size = new Size(174, 58);
			btnRaporlar.TabIndex = 2;
			btnRaporlar.Text = "Raporlar";
			btnRaporlar.UseVisualStyleBackColor = false;
			btnRaporlar.Click += btnRaporlar_Click;
			// 
			// pbxUserImage
			// 
			pbxUserImage.BackColor = Color.Transparent;
			pbxUserImage.Location = new Point(116, 50);
			pbxUserImage.Name = "pbxUserImage";
			pbxUserImage.Size = new Size(138, 155);
			pbxUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxUserImage.TabIndex = 4;
			pbxUserImage.TabStop = false;
			// 
			// btnProfil
			// 
			btnProfil.BackColor = Color.DarkSeaGreen;
			btnProfil.BackgroundImage = (Image)resources.GetObject("btnProfil.BackgroundImage");
			btnProfil.BackgroundImageLayout = ImageLayout.Stretch;
			btnProfil.FlatAppearance.BorderSize = 0;
			btnProfil.FlatStyle = FlatStyle.Popup;
			btnProfil.Location = new Point(310, 9);
			btnProfil.Name = "btnProfil";
			btnProfil.Size = new Size(50, 53);
			btnProfil.TabIndex = 5;
			btnProfil.UseVisualStyleBackColor = false;
			btnProfil.Click += btnProfil_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources._80787692;
			pictureBox1.Location = new Point(310, 513);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(61, 61);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			// 
			// UserHomePage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(372, 577);
			Controls.Add(pictureBox1);
			Controls.Add(btnProfil);
			Controls.Add(pbxUserImage);
			Controls.Add(btnRaporlar);
			Controls.Add(btnKaloriTakibi);
			Controls.Add(btnSuTakibi);
			Controls.Add(btnYemekMiKacKolari);
			Controls.Add(label1);
			Controls.Add(lblKisiAdi);
			Name = "UserHomePage";
			Text = "UserHomePage";
			Load += UserHomePage_Load;
			((System.ComponentModel.ISupportInitialize)pbxUserImage).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label lblKisiAdi;
		private Button btnYemekMiKacKolari;
		private Button btnSuTakibi;
		private Button btnKaloriTakibi;
		private Button btnRaporlar;
		private PictureBox pbxUserImage;
		private Button btnProfil;
		private PictureBox pictureBox1;
	}
}