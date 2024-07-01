namespace Dualverse
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.versionLabel = new System.Windows.Forms.Label();
			this.copyrightLabel1 = new System.Windows.Forms.Label();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.copyrightLabel2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.BackColor = System.Drawing.Color.Transparent;
			this.versionLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.versionLabel.Location = new System.Drawing.Point(267, 110);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(0, 21);
			this.versionLabel.TabIndex = 0;
			// 
			// copyrightLabel1
			// 
			this.copyrightLabel1.AutoSize = true;
			this.copyrightLabel1.BackColor = System.Drawing.Color.Transparent;
			this.copyrightLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.copyrightLabel1.Location = new System.Drawing.Point(268, 140);
			this.copyrightLabel1.Name = "copyrightLabel1";
			this.copyrightLabel1.Size = new System.Drawing.Size(0, 17);
			this.copyrightLabel1.TabIndex = 1;
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(271, 255);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(163, 44);
			this.logoPictureBox.TabIndex = 2;
			this.logoPictureBox.TabStop = false;
			this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.linkLabel1.Location = new System.Drawing.Point(268, 185);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(149, 17);
			this.linkLabel1.TabIndex = 4;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "ソースコードを取得 (GitHub)";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// copyrightLabel2
			// 
			this.copyrightLabel2.AutoSize = true;
			this.copyrightLabel2.BackColor = System.Drawing.Color.Transparent;
			this.copyrightLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.copyrightLabel2.Location = new System.Drawing.Point(268, 156);
			this.copyrightLabel2.Name = "copyrightLabel2";
			this.copyrightLabel2.Size = new System.Drawing.Size(193, 17);
			this.copyrightLabel2.TabIndex = 5;
			this.copyrightLabel2.Text = "Licensed under the MIT License.";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(624, 321);
			this.Controls.Add(this.copyrightLabel1);
			this.Controls.Add(this.copyrightLabel2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.logoPictureBox);
			this.Controls.Add(this.versionLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dualverse について";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Label copyrightLabel1;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label copyrightLabel2;
	}
}