namespace Kalori_Takip___Diyet__Programı
{
	partial class IntroductıonTable
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroductıonTable));
			pbxResim = new PictureBox();
			btnGeri = new Button();
			btnİleri = new Button();
			btnGec = new Button();
			((System.ComponentModel.ISupportInitialize)pbxResim).BeginInit();
			SuspendLayout();
			// 
			// pbxResim
			// 
			pbxResim.Image = Properties.Resources._1;
			pbxResim.Location = new Point(48, 12);
			pbxResim.Name = "pbxResim";
			pbxResim.Size = new Size(324, 484);
			pbxResim.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxResim.TabIndex = 0;
			pbxResim.TabStop = false;
			// 
			// btnGeri
			// 
			btnGeri.BackColor = Color.Transparent;
			btnGeri.BackgroundImage = (Image)resources.GetObject("btnGeri.BackgroundImage");
			btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
			btnGeri.FlatAppearance.BorderSize = 0;
			btnGeri.FlatStyle = FlatStyle.Popup;
			btnGeri.Location = new Point(12, 469);
			btnGeri.Name = "btnGeri";
			btnGeri.Size = new Size(30, 27);
			btnGeri.TabIndex = 24;
			btnGeri.UseVisualStyleBackColor = false;
			btnGeri.Click += btnGeri_Click;
			// 
			// btnİleri
			// 
			btnİleri.BackColor = Color.Transparent;
			btnİleri.BackgroundImage = (Image)resources.GetObject("btnİleri.BackgroundImage");
			btnİleri.BackgroundImageLayout = ImageLayout.Stretch;
			btnİleri.FlatAppearance.BorderSize = 0;
			btnİleri.FlatStyle = FlatStyle.Popup;
			btnİleri.Location = new Point(378, 469);
			btnİleri.Name = "btnİleri";
			btnİleri.Size = new Size(30, 27);
			btnİleri.TabIndex = 24;
			btnİleri.UseVisualStyleBackColor = false;
			btnİleri.Click += btnİleri_Click;
			// 
			// btnGec
			// 
			btnGec.BackColor = Color.Transparent;
			btnGec.BackgroundImage = (Image)resources.GetObject("btnGec.BackgroundImage");
			btnGec.BackgroundImageLayout = ImageLayout.Stretch;
			btnGec.FlatAppearance.BorderSize = 0;
			btnGec.FlatStyle = FlatStyle.Popup;
			btnGec.Location = new Point(378, 436);
			btnGec.Name = "btnGec";
			btnGec.Size = new Size(30, 27);
			btnGec.TabIndex = 24;
			btnGec.UseVisualStyleBackColor = false;
			btnGec.Click += btnGec_Click;
			// 
			// IntroductıonTable
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(422, 508);
			Controls.Add(btnGec);
			Controls.Add(btnİleri);
			Controls.Add(btnGeri);
			Controls.Add(pbxResim);
			Name = "IntroductıonTable";
			Text = "IntroductıonTable";
			Load += IntroductıonTable_Load;
			((System.ComponentModel.ISupportInitialize)pbxResim).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pbxResim;
		private Button btnGeri;
		private Button btnİleri;
		private Button btnGec;
	}
}