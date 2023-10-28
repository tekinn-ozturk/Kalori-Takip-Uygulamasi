namespace Kalori_Takip___Diyet__Programı
{
	partial class intro
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(intro));
			tmrIntro = new System.Windows.Forms.Timer(components);
			pgrBar = new ProgressBar();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// tmrIntro
			// 
			tmrIntro.Tick += tmrIntro_Tick;
			// 
			// pgrBar
			// 
			pgrBar.BackColor = Color.IndianRed;
			pgrBar.ForeColor = Color.DarkOrange;
			pgrBar.Location = new Point(12, 386);
			pgrBar.Name = "pgrBar";
			pgrBar.Size = new Size(293, 23);
			pgrBar.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(109, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(101, 105);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 3;
			pictureBox1.TabStop = false;
			// 
			// intro
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.HighlightText;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Zoom;
			ClientSize = new Size(317, 456);
			Controls.Add(pictureBox1);
			Controls.Add(pgrBar);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.None;
			Name = "intro";
			Text = "Form1";
			Load += intro_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.Timer tmrIntro;
		private ProgressBar pgrBar;
		private PictureBox pictureBox1;
	}
}