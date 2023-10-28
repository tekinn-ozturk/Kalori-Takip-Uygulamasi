namespace Kalori_Takip___Diyet__Programı
{
	partial class FoodShow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodShow));
			lstKaydedilenUrunler = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			btnSil = new Button();
			lblGosterBaslik = new Label();
			pbxYemekResmi = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pbxYemekResmi).BeginInit();
			SuspendLayout();
			// 
			// lstKaydedilenUrunler
			// 
			lstKaydedilenUrunler.BackColor = Color.PaleGoldenrod;
			lstKaydedilenUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
			lstKaydedilenUrunler.FullRowSelect = true;
			lstKaydedilenUrunler.GridLines = true;
			lstKaydedilenUrunler.Location = new Point(12, 265);
			lstKaydedilenUrunler.Name = "lstKaydedilenUrunler";
			lstKaydedilenUrunler.Size = new Size(775, 198);
			lstKaydedilenUrunler.TabIndex = 0;
			lstKaydedilenUrunler.UseCompatibleStateImageBehavior = false;
			lstKaydedilenUrunler.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Ürün Adı";
			columnHeader1.Width = 125;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Miktar";
			columnHeader2.Width = 125;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Kalori";
			columnHeader3.Width = 125;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Protein";
			columnHeader4.Width = 125;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Yağ";
			columnHeader5.Width = 125;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Karbonhidrat";
			columnHeader6.Width = 125;
			// 
			// btnSil
			// 
			btnSil.BackColor = Color.DarkSeaGreen;
			btnSil.BackgroundImage = (Image)resources.GetObject("btnSil.BackgroundImage");
			btnSil.BackgroundImageLayout = ImageLayout.Stretch;
			btnSil.FlatAppearance.BorderSize = 0;
			btnSil.FlatStyle = FlatStyle.Popup;
			btnSil.Location = new Point(376, 478);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(47, 45);
			btnSil.TabIndex = 4;
			btnSil.UseVisualStyleBackColor = false;
			btnSil.Click += btnSil_Click;
			// 
			// lblGosterBaslik
			// 
			lblGosterBaslik.BackColor = Color.PaleGoldenrod;
			lblGosterBaslik.Location = new Point(12, 9);
			lblGosterBaslik.Name = "lblGosterBaslik";
			lblGosterBaslik.Size = new Size(775, 49);
			lblGosterBaslik.TabIndex = 5;
			lblGosterBaslik.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pbxYemekResmi
			// 
			pbxYemekResmi.Location = new Point(337, 85);
			pbxYemekResmi.Name = "pbxYemekResmi";
			pbxYemekResmi.Size = new Size(117, 134);
			pbxYemekResmi.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxYemekResmi.TabIndex = 35;
			pbxYemekResmi.TabStop = false;
			// 
			// FoodShow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(800, 551);
			Controls.Add(pbxYemekResmi);
			Controls.Add(lblGosterBaslik);
			Controls.Add(btnSil);
			Controls.Add(lstKaydedilenUrunler);
			Name = "FoodShow";
			Text = "FoodShow";
			Load += FoodShow_Load;
			((System.ComponentModel.ISupportInitialize)pbxYemekResmi).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private ListView lstKaydedilenUrunler;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private Button btnSil;
		private Label lblGosterBaslik;
		private PictureBox pbxYemekResmi;
	}
}