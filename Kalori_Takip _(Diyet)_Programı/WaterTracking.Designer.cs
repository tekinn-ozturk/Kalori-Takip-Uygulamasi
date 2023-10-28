namespace Kalori_Takip___Diyet__Programı
{
	partial class WaterTracking
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterTracking));
			label1 = new Label();
			groupBox1 = new GroupBox();
			lblKilo = new Label();
			label2 = new Label();
			lblİcmenizGerekenSuMiktari = new Label();
			label3 = new Label();
			pictureBox1 = new PictureBox();
			pbxSuBardagi = new PictureBox();
			btnGeriDon = new Button();
			label4 = new Label();
			btnSuEkle = new Button();
			label5 = new Label();
			nmrSuMiktari = new NumericUpDown();
			dtSuTarih = new DateTimePicker();
			grpSuMiktariGir = new GroupBox();
			lblİcilmesiGerekenSuMiktari = new Label();
			label6 = new Label();
			lblGecmisİcilmisSu = new Label();
			groupBox3 = new GroupBox();
			label9 = new Label();
			flowLayoutPanel1 = new FlowLayoutPanel();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbxSuBardagi).BeginInit();
			((System.ComponentModel.ISupportInitialize)nmrSuMiktari).BeginInit();
			grpSuMiktariGir.SuspendLayout();
			groupBox3.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(2, 32);
			label1.Name = "label1";
			label1.Size = new Size(86, 23);
			label1.TabIndex = 1;
			label1.Text = "SU TAKİBİ";
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(lblKilo);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(lblİcmenizGerekenSuMiktari);
			groupBox1.Location = new Point(2, 86);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(331, 96);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "KişiselBilgiler";
			// 
			// lblKilo
			// 
			lblKilo.AutoSize = true;
			lblKilo.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblKilo.Location = new Point(48, 19);
			lblKilo.Name = "lblKilo";
			lblKilo.Size = new Size(17, 19);
			lblKilo.TabIndex = 0;
			lblKilo.Text = "0";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(6, 19);
			label2.Name = "label2";
			label2.Size = new Size(33, 19);
			label2.TabIndex = 0;
			label2.Text = "Kilo";
			// 
			// lblİcmenizGerekenSuMiktari
			// 
			lblİcmenizGerekenSuMiktari.AutoSize = true;
			lblİcmenizGerekenSuMiktari.BackColor = Color.Transparent;
			lblİcmenizGerekenSuMiktari.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblİcmenizGerekenSuMiktari.Location = new Point(6, 51);
			lblİcmenizGerekenSuMiktari.Name = "lblİcmenizGerekenSuMiktari";
			lblİcmenizGerekenSuMiktari.Size = new Size(0, 18);
			lblİcmenizGerekenSuMiktari.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(2, 55);
			label3.Name = "label3";
			label3.Size = new Size(515, 15);
			label3.TabIndex = 1;
			label3.Text = "Güncel kilonuz ile günlük tüketmeniz gereken su miktarını otomatik olarak hesaplanmaktadır.";
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(555, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(100, 161);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			// 
			// pbxSuBardagi
			// 
			pbxSuBardagi.Image = (Image)resources.GetObject("pbxSuBardagi.Image");
			pbxSuBardagi.Location = new Point(3, 3);
			pbxSuBardagi.Name = "pbxSuBardagi";
			pbxSuBardagi.Size = new Size(45, 86);
			pbxSuBardagi.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxSuBardagi.TabIndex = 5;
			pbxSuBardagi.TabStop = false;
			// 
			// btnGeriDon
			// 
			btnGeriDon.BackColor = Color.Transparent;
			btnGeriDon.BackgroundImage = (Image)resources.GetObject("btnGeriDon.BackgroundImage");
			btnGeriDon.BackgroundImageLayout = ImageLayout.Stretch;
			btnGeriDon.FlatAppearance.BorderSize = 0;
			btnGeriDon.FlatStyle = FlatStyle.Flat;
			btnGeriDon.Location = new Point(2, 2);
			btnGeriDon.Name = "btnGeriDon";
			btnGeriDon.Size = new Size(30, 27);
			btnGeriDon.TabIndex = 7;
			btnGeriDon.UseVisualStyleBackColor = false;
			btnGeriDon.Click += btnGeriDon_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(8, 423);
			label4.Name = "label4";
			label4.Size = new Size(196, 15);
			label4.TabIndex = 1;
			label4.Text = "Bir bardak 250 ml su içermektedir.";
			// 
			// btnSuEkle
			// 
			btnSuEkle.Location = new Point(6, 50);
			btnSuEkle.Name = "btnSuEkle";
			btnSuEkle.Size = new Size(120, 23);
			btnSuEkle.TabIndex = 8;
			btnSuEkle.Text = "Ekle";
			btnSuEkle.UseVisualStyleBackColor = true;
			btnSuEkle.Click += btnSuEkle_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(443, 185);
			label5.Name = "label5";
			label5.Size = new Size(212, 18);
			label5.TabIndex = 1;
			label5.Text = "Haydi Bugün Kaç Bardak İçtin Yaz!";
			// 
			// nmrSuMiktari
			// 
			nmrSuMiktari.Location = new Point(6, 21);
			nmrSuMiktari.Name = "nmrSuMiktari";
			nmrSuMiktari.Size = new Size(120, 23);
			nmrSuMiktari.TabIndex = 9;
			// 
			// dtSuTarih
			// 
			dtSuTarih.Location = new Point(6, 41);
			dtSuTarih.Name = "dtSuTarih";
			dtSuTarih.Size = new Size(200, 23);
			dtSuTarih.TabIndex = 10;
			dtSuTarih.ValueChanged += dtSuTarih_ValueChanged;
			// 
			// grpSuMiktariGir
			// 
			grpSuMiktariGir.BackColor = Color.Transparent;
			grpSuMiktariGir.Controls.Add(nmrSuMiktari);
			grpSuMiktariGir.Controls.Add(btnSuEkle);
			grpSuMiktariGir.Location = new Point(512, 212);
			grpSuMiktariGir.Name = "grpSuMiktariGir";
			grpSuMiktariGir.Size = new Size(143, 83);
			grpSuMiktariGir.TabIndex = 6;
			grpSuMiktariGir.TabStop = false;
			grpSuMiktariGir.Text = "Su Miktarı";
			// 
			// lblİcilmesiGerekenSuMiktari
			// 
			lblİcilmesiGerekenSuMiktari.AutoSize = true;
			lblİcilmesiGerekenSuMiktari.BackColor = Color.Transparent;
			lblİcilmesiGerekenSuMiktari.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblİcilmesiGerekenSuMiktari.Location = new Point(2, 185);
			lblİcilmesiGerekenSuMiktari.Name = "lblİcilmesiGerekenSuMiktari";
			lblİcilmesiGerekenSuMiktari.Size = new Size(0, 18);
			lblİcilmesiGerekenSuMiktari.TabIndex = 1;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(6, 20);
			label6.Name = "label6";
			label6.Size = new Size(255, 18);
			label6.TabIndex = 1;
			label6.Text = "İstediğin Tarihi Seç Ne kadar Su İçtin Gör";
			// 
			// lblGecmisİcilmisSu
			// 
			lblGecmisİcilmisSu.AutoSize = true;
			lblGecmisİcilmisSu.BackColor = Color.Transparent;
			lblGecmisİcilmisSu.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblGecmisİcilmisSu.Location = new Point(12, 67);
			lblGecmisİcilmisSu.Name = "lblGecmisİcilmisSu";
			lblGecmisİcilmisSu.Size = new Size(20, 18);
			lblGecmisİcilmisSu.TabIndex = 1;
			lblGecmisİcilmisSu.Text = "...";
			// 
			// groupBox3
			// 
			groupBox3.BackColor = Color.Transparent;
			groupBox3.Controls.Add(dtSuTarih);
			groupBox3.Controls.Add(label9);
			groupBox3.Controls.Add(label6);
			groupBox3.Controls.Add(lblGecmisİcilmisSu);
			groupBox3.Location = new Point(2, 188);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(380, 107);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = Color.Transparent;
			label9.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(6, 51);
			label9.Name = "label9";
			label9.Size = new Size(0, 18);
			label9.TabIndex = 1;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(pbxSuBardagi);
			flowLayoutPanel1.Location = new Point(8, 327);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(647, 93);
			flowLayoutPanel1.TabIndex = 8;
			// 
			// WaterTracking
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(667, 446);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(btnGeriDon);
			Controls.Add(grpSuMiktariGir);
			Controls.Add(pictureBox1);
			Controls.Add(groupBox3);
			Controls.Add(groupBox1);
			Controls.Add(label5);
			Controls.Add(lblİcilmesiGerekenSuMiktari);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label1);
			Name = "WaterTracking";
			Text = "WaterTracking";
			Load += WaterTracking_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pbxSuBardagi).EndInit();
			((System.ComponentModel.ISupportInitialize)nmrSuMiktari).EndInit();
			grpSuMiktariGir.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			flowLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
		private GroupBox groupBox1;
		private Label lblKilo;
		private Label label2;
		private Label label3;
		private PictureBox pictureBox1;
		private PictureBox pbxSuBardagi;
		private Button btnGeriDon;
		private Label label4;
		private Button btnSuEkle;
		private Label label5;
		private NumericUpDown nmrSuMiktari;
		private DateTimePicker dtSuTarih;
		private Label lblİcmenizGerekenSuMiktari;
		private GroupBox grpSuMiktariGir;
		private Label lblİcilmesiGerekenSuMiktari;
		private Label label6;
		private Label lblGecmisİcilmisSu;
		private GroupBox groupBox3;
		private Label label9;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}