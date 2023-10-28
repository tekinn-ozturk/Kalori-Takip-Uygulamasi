namespace Kalori_Takip___Diyet__Programı
{
	partial class HowManyCalories
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowManyCalories));
			label1 = new Label();
			label2 = new Label();
			lstFoods = new ListView();
			columnHeader2 = new ColumnHeader();
			columnHeader1 = new ColumnHeader();
			txtAra = new TextBox();
			grpBesinDegerleri = new GroupBox();
			label13 = new Label();
			lblYag = new Label();
			label9 = new Label();
			label11 = new Label();
			label7 = new Label();
			label12 = new Label();
			label8 = new Label();
			label10 = new Label();
			lblProtein = new Label();
			lblKalori = new Label();
			label6 = new Label();
			label5 = new Label();
			label3 = new Label();
			txtMiktar = new TextBox();
			label4 = new Label();
			btnGeriDon = new Button();
			btnİncele = new Button();
			label14 = new Label();
			grpBesinDegerleri.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(12, 33);
			label1.Name = "label1";
			label1.Size = new Size(235, 23);
			label1.TabIndex = 1;
			label1.Text = "HANGİ YEMEK KAÇ KALORİ ?";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(12, 56);
			label2.Name = "label2";
			label2.Size = new Size(361, 19);
			label2.TabIndex = 1;
			label2.Text = "Kalorisini öğrenmek istediğiniz besinleri arayabilirsiniz";
			// 
			// lstFoods
			// 
			lstFoods.BackColor = Color.PaleGoldenrod;
			lstFoods.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1 });
			lstFoods.FullRowSelect = true;
			lstFoods.GridLines = true;
			lstFoods.Location = new Point(12, 291);
			lstFoods.Name = "lstFoods";
			lstFoods.Size = new Size(759, 258);
			lstFoods.TabIndex = 2;
			lstFoods.UseCompatibleStateImageBehavior = false;
			lstFoods.View = View.Details;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Besin ID";
			columnHeader2.Width = 250;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Besin Adı";
			columnHeader1.Width = 250;
			// 
			// txtAra
			// 
			txtAra.BackColor = Color.PaleGoldenrod;
			txtAra.Location = new Point(12, 262);
			txtAra.Name = "txtAra";
			txtAra.Size = new Size(267, 23);
			txtAra.TabIndex = 3;
			txtAra.TextChanged += txtAra_TextChanged;
			// 
			// grpBesinDegerleri
			// 
			grpBesinDegerleri.Controls.Add(label13);
			grpBesinDegerleri.Controls.Add(lblYag);
			grpBesinDegerleri.Controls.Add(label9);
			grpBesinDegerleri.Controls.Add(label11);
			grpBesinDegerleri.Controls.Add(label7);
			grpBesinDegerleri.Controls.Add(label12);
			grpBesinDegerleri.Controls.Add(label8);
			grpBesinDegerleri.Controls.Add(label10);
			grpBesinDegerleri.Controls.Add(lblProtein);
			grpBesinDegerleri.Controls.Add(lblKalori);
			grpBesinDegerleri.Controls.Add(label6);
			grpBesinDegerleri.Controls.Add(label5);
			grpBesinDegerleri.Location = new Point(466, 33);
			grpBesinDegerleri.Name = "grpBesinDegerleri";
			grpBesinDegerleri.Size = new Size(305, 175);
			grpBesinDegerleri.TabIndex = 8;
			grpBesinDegerleri.TabStop = false;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label13.Location = new Point(160, 117);
			label13.Name = "label13";
			label13.Size = new Size(15, 18);
			label13.TabIndex = 11;
			label13.Text = "0";
			// 
			// lblYag
			// 
			lblYag.AutoSize = true;
			lblYag.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblYag.Location = new Point(160, 87);
			lblYag.Name = "lblYag";
			lblYag.Size = new Size(15, 18);
			lblYag.TabIndex = 11;
			lblYag.Text = "0";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(6, 117);
			label9.Name = "label9";
			label9.Size = new Size(89, 18);
			label9.TabIndex = 18;
			label9.Text = "Karbonhidrat";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label11.Location = new Point(242, 27);
			label11.Name = "label11";
			label11.Size = new Size(32, 18);
			label11.TabIndex = 16;
			label11.Text = "kcal";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(6, 27);
			label7.Name = "label7";
			label7.Size = new Size(44, 18);
			label7.TabIndex = 16;
			label7.Text = "Kalori";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label12.Location = new Point(242, 117);
			label12.Name = "label12";
			label12.Size = new Size(20, 18);
			label12.TabIndex = 15;
			label12.Text = "gr";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(242, 87);
			label8.Name = "label8";
			label8.Size = new Size(20, 18);
			label8.TabIndex = 15;
			label8.Text = "gr";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label10.Location = new Point(242, 57);
			label10.Name = "label10";
			label10.Size = new Size(20, 18);
			label10.TabIndex = 15;
			label10.Text = "gr";
			// 
			// lblProtein
			// 
			lblProtein.AutoSize = true;
			lblProtein.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblProtein.Location = new Point(160, 57);
			lblProtein.Name = "lblProtein";
			lblProtein.Size = new Size(15, 18);
			lblProtein.TabIndex = 13;
			lblProtein.Text = "0";
			// 
			// lblKalori
			// 
			lblKalori.AutoSize = true;
			lblKalori.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblKalori.Location = new Point(160, 27);
			lblKalori.Name = "lblKalori";
			lblKalori.Size = new Size(15, 18);
			lblKalori.TabIndex = 13;
			lblKalori.Text = "0";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(6, 57);
			label6.Name = "label6";
			label6.Size = new Size(54, 18);
			label6.TabIndex = 15;
			label6.Text = "Protein";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(6, 87);
			label5.Name = "label5";
			label5.Size = new Size(28, 18);
			label5.TabIndex = 14;
			label5.Text = "Yağ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(12, 240);
			label3.Name = "label3";
			label3.Size = new Size(158, 19);
			label3.TabIndex = 1;
			label3.Text = "Buradan Arayabilirsiniz";
			// 
			// txtMiktar
			// 
			txtMiktar.BackColor = Color.PaleGoldenrod;
			txtMiktar.Location = new Point(285, 262);
			txtMiktar.Name = "txtMiktar";
			txtMiktar.Size = new Size(121, 23);
			txtMiktar.TabIndex = 3;
			txtMiktar.TextChanged += txtMiktar_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(285, 240);
			label4.Name = "label4";
			label4.Size = new Size(51, 19);
			label4.TabIndex = 1;
			label4.Text = "Miktar";
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
			btnGeriDon.TabIndex = 24;
			btnGeriDon.UseVisualStyleBackColor = false;
			btnGeriDon.Click += btnGeriDon_Click;
			// 
			// btnİncele
			// 
			btnİncele.Location = new Point(696, 261);
			btnİncele.Name = "btnİncele";
			btnİncele.Size = new Size(75, 23);
			btnİncele.TabIndex = 25;
			btnİncele.Text = "İncele";
			btnİncele.UseVisualStyleBackColor = true;
			btnİncele.Click += btnİncele_Click;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label14.Location = new Point(412, 266);
			label14.Name = "label14";
			label14.Size = new Size(39, 18);
			label14.TabIndex = 15;
			label14.Text = "gram";
			// 
			// HowManyCalories
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(783, 559);
			Controls.Add(btnİncele);
			Controls.Add(btnGeriDon);
			Controls.Add(grpBesinDegerleri);
			Controls.Add(txtMiktar);
			Controls.Add(txtAra);
			Controls.Add(label14);
			Controls.Add(lstFoods);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "HowManyCalories";
			Text = "HowManyCalories";
			Load += HowManyCalories_Load;
			grpBesinDegerleri.ResumeLayout(false);
			grpBesinDegerleri.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private ListView lstFoods;
		private TextBox txtAra;
		private GroupBox grpBesinDegerleri;
		private Label label3;
		private TextBox txtMiktar;
		private Label label4;
		private Label lblYagOrani;
		private Label lblVki;
		private Label lblYag;
		private Label lblBoy;
		private Label lblKalori;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label11;
		private Label label12;
		private Label label10;
		private Label lblProtein;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader1;
		private Button btnGeriDon;
		private Button btnİncele;
		private Label label13;
		private Label label14;
	}
}