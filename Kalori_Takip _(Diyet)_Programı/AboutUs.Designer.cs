namespace Kalori_Takip___Diyet__Programı
{
	partial class AboutUs
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
			label1 = new Label();
			btnCredits = new Button();
			label2 = new Label();
			tmrAboutUs = new System.Windows.Forms.Timer(components);
			labelCredits = new Label();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(12, 63);
			label1.Name = "label1";
			label1.Size = new Size(289, 191);
			label1.TabIndex = 0;
			label1.Text = resources.GetString("label1.Text");
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnCredits
			// 
			btnCredits.BackColor = Color.Transparent;
			btnCredits.BackgroundImageLayout = ImageLayout.None;
			btnCredits.FlatStyle = FlatStyle.Popup;
			btnCredits.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnCredits.ForeColor = Color.DarkOliveGreen;
			btnCredits.Location = new Point(12, 442);
			btnCredits.Name = "btnCredits";
			btnCredits.Size = new Size(289, 35);
			btnCredits.TabIndex = 2;
			btnCredits.Text = "CREDİTS";
			btnCredits.UseVisualStyleBackColor = false;
			btnCredits.Click += btnCredits_Click;
			// 
			// label2
			// 
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.DarkOliveGreen;
			label2.Location = new Point(27, 254);
			label2.Name = "label2";
			label2.Size = new Size(244, 42);
			label2.TabIndex = 3;
			label2.Text = "İ-FEAT ";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			label2.UseCompatibleTextRendering = true;
			// 
			// tmrAboutUs
			// 
			tmrAboutUs.Interval = 5000;
			tmrAboutUs.Tick += tmrAboutUs_Tick;
			// 
			// labelCredits
			// 
			labelCredits.BackColor = Color.Transparent;
			labelCredits.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			labelCredits.Location = new Point(40, 305);
			labelCredits.Name = "labelCredits";
			labelCredits.Size = new Size(231, 107);
			labelCredits.TabIndex = 4;
			labelCredits.Text = "ENES FEVZİ ÇİÇEKLİ\r\nEBRU ÇEVİK\r\nTEKİN ÖZTÜRK\r\nASLIHAN BALHAN";
			labelCredits.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources._80787692;
			pictureBox1.Location = new Point(118, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(76, 75);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 7;
			pictureBox1.TabStop = false;
			// 
			// AboutUs
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(313, 492);
			Controls.Add(pictureBox1);
			Controls.Add(labelCredits);
			Controls.Add(label2);
			Controls.Add(btnCredits);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "AboutUs";
			Text = "AboutUs";
			Load += AboutUs_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private Button btnCredits;
		private Label label2;
		private System.Windows.Forms.Timer tmrAboutUs;
		private Label labelCredits;
		private PictureBox pictureBox1;
	}
}