namespace Kalori_Takip___Diyet__Programı
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			label2 = new Label();
			label1 = new Label();
			txtKullaniciAdi = new TextBox();
			txtSifre = new TextBox();
			btnGirisYap = new Button();
			grpGirisYap = new GroupBox();
			label3 = new Label();
			btnHesapOlustur = new Button();
			label4 = new Label();
			btnGeriDon = new Button();
			btnGoster = new Button();
			grpGirisYap.SuspendLayout();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(131, 19);
			label2.Name = "label2";
			label2.Size = new Size(107, 29);
			label2.TabIndex = 4;
			label2.Text = "Kullanıcı Adı";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			label2.UseCompatibleTextRendering = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(158, 87);
			label1.Name = "label1";
			label1.Size = new Size(44, 29);
			label1.TabIndex = 4;
			label1.Text = "Şifre";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.UseCompatibleTextRendering = true;
			// 
			// txtKullaniciAdi
			// 
			txtKullaniciAdi.Location = new Point(73, 51);
			txtKullaniciAdi.Name = "txtKullaniciAdi";
			txtKullaniciAdi.Size = new Size(224, 23);
			txtKullaniciAdi.TabIndex = 5;
			// 
			// txtSifre
			// 
			txtSifre.Location = new Point(73, 119);
			txtSifre.Name = "txtSifre";
			txtSifre.PasswordChar = '*';
			txtSifre.Size = new Size(224, 23);
			txtSifre.TabIndex = 5;
			// 
			// btnGirisYap
			// 
			btnGirisYap.BackColor = Color.Transparent;
			btnGirisYap.FlatStyle = FlatStyle.Popup;
			btnGirisYap.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnGirisYap.ForeColor = SystemColors.ActiveCaptionText;
			btnGirisYap.Location = new Point(73, 159);
			btnGirisYap.Name = "btnGirisYap";
			btnGirisYap.Size = new Size(224, 32);
			btnGirisYap.TabIndex = 6;
			btnGirisYap.Text = "G İ R İ Ş  Y A P ";
			btnGirisYap.UseVisualStyleBackColor = false;
			btnGirisYap.Click += btnGirisYap_Click;
			// 
			// grpGirisYap
			// 
			grpGirisYap.BackColor = Color.Transparent;
			grpGirisYap.Controls.Add(btnGoster);
			grpGirisYap.Controls.Add(label3);
			grpGirisYap.Controls.Add(label1);
			grpGirisYap.Controls.Add(btnHesapOlustur);
			grpGirisYap.Controls.Add(btnGirisYap);
			grpGirisYap.Controls.Add(label2);
			grpGirisYap.Controls.Add(txtSifre);
			grpGirisYap.Controls.Add(txtKullaniciAdi);
			grpGirisYap.Location = new Point(2, 80);
			grpGirisYap.Name = "grpGirisYap";
			grpGirisYap.Size = new Size(370, 287);
			grpGirisYap.TabIndex = 7;
			grpGirisYap.TabStop = false;
			grpGirisYap.Text = "LoginPage";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(55, 209);
			label3.Name = "label3";
			label3.Size = new Size(264, 25);
			label3.TabIndex = 4;
			label3.Text = "Hesabınız Yok Mu ? Hemen Oluşturun";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			label3.UseCompatibleTextRendering = true;
			// 
			// btnHesapOlustur
			// 
			btnHesapOlustur.AutoSize = true;
			btnHesapOlustur.BackColor = Color.Transparent;
			btnHesapOlustur.FlatAppearance.BorderSize = 0;
			btnHesapOlustur.FlatStyle = FlatStyle.Popup;
			btnHesapOlustur.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnHesapOlustur.Location = new Point(117, 246);
			btnHesapOlustur.Name = "btnHesapOlustur";
			btnHesapOlustur.Size = new Size(138, 35);
			btnHesapOlustur.TabIndex = 6;
			btnHesapOlustur.Text = "Hesap Oluştur";
			btnHesapOlustur.UseVisualStyleBackColor = false;
			btnHesapOlustur.Click += btnHesapOlustur_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Impact", 36F, FontStyle.Italic, GraphicsUnit.Point);
			label4.ForeColor = Color.Gainsboro;
			label4.Location = new Point(99, 9);
			label4.Name = "label4";
			label4.Size = new Size(177, 68);
			label4.TabIndex = 4;
			label4.Text = "İ - F E A T";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			label4.UseCompatibleTextRendering = true;
			// 
			// btnGeriDon
			// 
			btnGeriDon.BackColor = Color.Transparent;
			btnGeriDon.BackgroundImage = (Image)resources.GetObject("btnGeriDon.BackgroundImage");
			btnGeriDon.BackgroundImageLayout = ImageLayout.Stretch;
			btnGeriDon.FlatAppearance.BorderSize = 0;
			btnGeriDon.FlatStyle = FlatStyle.Popup;
			btnGeriDon.Location = new Point(2, 9);
			btnGeriDon.Name = "btnGeriDon";
			btnGeriDon.Size = new Size(30, 27);
			btnGeriDon.TabIndex = 8;
			btnGeriDon.UseVisualStyleBackColor = false;
			btnGeriDon.Click += btnGeriDon_Click;
			// 
			// btnGoster
			// 
			btnGoster.BackColor = Color.Transparent;
			btnGoster.BackgroundImage = (Image)resources.GetObject("btnGoster.BackgroundImage");
			btnGoster.BackgroundImageLayout = ImageLayout.Stretch;
			btnGoster.FlatStyle = FlatStyle.Popup;
			btnGoster.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnGoster.ForeColor = Color.AliceBlue;
			btnGoster.Location = new Point(303, 119);
			btnGoster.Name = "btnGoster";
			btnGoster.Size = new Size(28, 25);
			btnGoster.TabIndex = 22;
			btnGoster.UseVisualStyleBackColor = false;
			btnGoster.MouseDown += btnGoster_MouseDown;
			btnGoster.MouseUp += btnGoster_MouseUp;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(374, 384);
			Controls.Add(btnGeriDon);
			Controls.Add(grpGirisYap);
			Controls.Add(label4);
			Name = "Login";
			Text = "Login";
			Load += Login_Load;
			grpGirisYap.ResumeLayout(false);
			grpGirisYap.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private Label label1;
		private TextBox txtKullaniciAdi;
		private TextBox txtSifre;
		private Button btnGirisYap;
		private GroupBox grpGirisYap;
		private Label label3;
		private Button btnHesapOlustur;
		private Label label4;
		private Button btnGeriDon;
		private Button btnGoster;
	}
}