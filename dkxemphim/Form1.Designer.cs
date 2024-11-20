namespace dkxemphim
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.grbTTDK = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtTuoi = new System.Windows.Forms.TextBox();
			this.dtpDk = new System.Windows.Forms.DateTimePicker();
			this.btnDk = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.grbTTDK.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// grbTTDK
			// 
			this.grbTTDK.Controls.Add(this.btnDk);
			this.grbTTDK.Controls.Add(this.dtpDk);
			this.grbTTDK.Controls.Add(this.txtTuoi);
			this.grbTTDK.Controls.Add(this.txtPhone);
			this.grbTTDK.Controls.Add(this.label3);
			this.grbTTDK.Controls.Add(this.label2);
			this.grbTTDK.Controls.Add(this.label1);
			this.grbTTDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbTTDK.Location = new System.Drawing.Point(43, 29);
			this.grbTTDK.Name = "grbTTDK";
			this.grbTTDK.Size = new System.Drawing.Size(433, 207);
			this.grbTTDK.TabIndex = 0;
			this.grbTTDK.TabStop = false;
			this.grbTTDK.Text = "thong tin dang ky";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(65, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Phone";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(65, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tuoi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(65, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ngay dang ky";
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(199, 33);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(200, 21);
			this.txtPhone.TabIndex = 3;
			// 
			// txtTuoi
			// 
			this.txtTuoi.Location = new System.Drawing.Point(199, 79);
			this.txtTuoi.Name = "txtTuoi";
			this.txtTuoi.Size = new System.Drawing.Size(200, 21);
			this.txtTuoi.TabIndex = 4;
			// 
			// dtpDk
			// 
			this.dtpDk.CustomFormat = "dd/MM/yyyy";
			this.dtpDk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDk.Location = new System.Drawing.Point(199, 126);
			this.dtpDk.Name = "dtpDk";
			this.dtpDk.Size = new System.Drawing.Size(200, 21);
			this.dtpDk.TabIndex = 5;
			// 
			// btnDk
			// 
			this.btnDk.Location = new System.Drawing.Point(169, 178);
			this.btnDk.Name = "btnDk";
			this.btnDk.Size = new System.Drawing.Size(75, 23);
			this.btnDk.TabIndex = 6;
			this.btnDk.Text = "Dang ky";
			this.btnDk.UseVisualStyleBackColor = true;
			this.btnDk.Click += new System.EventHandler(this.btnDk_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(524, 270);
			this.Controls.Add(this.grbTTDK);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dang ky xem phim";
			this.grbTTDK.ResumeLayout(false);
			this.grbTTDK.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbTTDK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtTuoi;
		private System.Windows.Forms.DateTimePicker dtpDk;
		private System.Windows.Forms.Button btnDk;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}

