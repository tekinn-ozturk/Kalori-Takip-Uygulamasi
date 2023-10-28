namespace Kalori_Takip___Diyet__Programı
{
	partial class ReportConsumeFood
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			rdbHaftalik = new RadioButton();
			rdbAylik = new RadioButton();
			dtTarih = new DateTimePicker();
			label1 = new Label();
			grpZamanAraligi = new GroupBox();
			groupBox2 = new GroupBox();
			rdbOgun = new RadioButton();
			rdbKateogri = new RadioButton();
			btnRaporla = new Button();
			((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
			grpZamanAraligi.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// chart1
			// 
			chart1.BackColor = Color.DarkSeaGreen;
			chartArea1.Name = "ChartArea1";
			chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			chart1.Legends.Add(legend1);
			chart1.Location = new Point(12, 12);
			chart1.Name = "chart1";
			chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Siz";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Diğer Kullanıcılar";
			chart1.Series.Add(series1);
			chart1.Series.Add(series2);
			chart1.Size = new Size(520, 380);
			chart1.TabIndex = 0;
			chart1.Text = "chart1";
			// 
			// rdbHaftalik
			// 
			rdbHaftalik.AutoSize = true;
			rdbHaftalik.Location = new Point(6, 22);
			rdbHaftalik.Name = "rdbHaftalik";
			rdbHaftalik.Size = new Size(66, 19);
			rdbHaftalik.TabIndex = 1;
			rdbHaftalik.TabStop = true;
			rdbHaftalik.Text = "Haftalık";
			rdbHaftalik.UseVisualStyleBackColor = true;
			// 
			// rdbAylik
			// 
			rdbAylik.AutoSize = true;
			rdbAylik.Location = new Point(230, 22);
			rdbAylik.Name = "rdbAylik";
			rdbAylik.Size = new Size(51, 19);
			rdbAylik.TabIndex = 1;
			rdbAylik.TabStop = true;
			rdbAylik.Text = "Aylık";
			rdbAylik.UseVisualStyleBackColor = true;
			// 
			// dtTarih
			// 
			dtTarih.Location = new Point(551, 38);
			dtTarih.Name = "dtTarih";
			dtTarih.Size = new Size(287, 23);
			dtTarih.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(551, 12);
			label1.Name = "label1";
			label1.Size = new Size(80, 23);
			label1.TabIndex = 3;
			label1.Text = "Tarih Seç";
			// 
			// grpZamanAraligi
			// 
			grpZamanAraligi.Controls.Add(rdbHaftalik);
			grpZamanAraligi.Controls.Add(rdbAylik);
			grpZamanAraligi.Location = new Point(551, 67);
			grpZamanAraligi.Name = "grpZamanAraligi";
			grpZamanAraligi.Size = new Size(287, 58);
			grpZamanAraligi.TabIndex = 4;
			grpZamanAraligi.TabStop = false;
			grpZamanAraligi.Text = "Zaman Aralığı";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(rdbOgun);
			groupBox2.Controls.Add(rdbKateogri);
			groupBox2.Location = new Point(551, 131);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(287, 58);
			groupBox2.TabIndex = 4;
			groupBox2.TabStop = false;
			groupBox2.Text = "Zaman Aralığı";
			// 
			// rdbOgun
			// 
			rdbOgun.AutoSize = true;
			rdbOgun.Location = new Point(6, 22);
			rdbOgun.Name = "rdbOgun";
			rdbOgun.Size = new Size(55, 19);
			rdbOgun.TabIndex = 1;
			rdbOgun.TabStop = true;
			rdbOgun.Text = "Öğün";
			rdbOgun.UseVisualStyleBackColor = true;
			// 
			// rdbKateogri
			// 
			rdbKateogri.AutoSize = true;
			rdbKateogri.Location = new Point(212, 22);
			rdbKateogri.Name = "rdbKateogri";
			rdbKateogri.Size = new Size(69, 19);
			rdbKateogri.TabIndex = 1;
			rdbKateogri.TabStop = true;
			rdbKateogri.Text = "Kategori";
			rdbKateogri.UseVisualStyleBackColor = true;
			// 
			// btnRaporla
			// 
			btnRaporla.Location = new Point(557, 195);
			btnRaporla.Name = "btnRaporla";
			btnRaporla.Size = new Size(281, 23);
			btnRaporla.TabIndex = 5;
			btnRaporla.Text = "Raporla";
			btnRaporla.UseVisualStyleBackColor = true;
			btnRaporla.Click += btnRaporla_Click;
			// 
			// ReportConsumeFood
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(850, 567);
			Controls.Add(btnRaporla);
			Controls.Add(groupBox2);
			Controls.Add(grpZamanAraligi);
			Controls.Add(label1);
			Controls.Add(dtTarih);
			Controls.Add(chart1);
			Name = "ReportConsumeFood";
			Text = "ReportConsumeFood";
			Load += ReportConsumeFood_Load;
			((System.ComponentModel.ISupportInitialize)chart1).EndInit();
			grpZamanAraligi.ResumeLayout(false);
			grpZamanAraligi.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private RadioButton rdbHaftalik;
		private RadioButton rdbAylik;
		private DateTimePicker dtTarih;
		private Label label1;
		private GroupBox grpZamanAraligi;
		private GroupBox groupBox2;
		private RadioButton rdbOgun;
		private RadioButton rdbKateogri;
		private Button btnRaporla;
	}
}