namespace Dualverse
{
	partial class SettingsForm
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
			this.serviceLabel = new System.Windows.Forms.Label();
			this.serviceLeftLabel = new System.Windows.Forms.Label();
			this.serviceLeftCombo = new System.Windows.Forms.ComboBox();
			this.serviceRightLabel = new System.Windows.Forms.Label();
			this.serviceRightCombo = new System.Windows.Forms.ComboBox();
			this.serviceLeftText = new System.Windows.Forms.TextBox();
			this.serviceRightText = new System.Windows.Forms.TextBox();
			this.serviceLeftButton = new System.Windows.Forms.Button();
			this.serviceRightButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// serviceLabel
			// 
			this.serviceLabel.AutoSize = true;
			this.serviceLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.serviceLabel.Location = new System.Drawing.Point(20, 20);
			this.serviceLabel.Name = "serviceLabel";
			this.serviceLabel.Size = new System.Drawing.Size(124, 25);
			this.serviceLabel.TabIndex = 0;
			this.serviceLabel.Text = "既定のサービス";
			// 
			// serviceLeftLabel
			// 
			this.serviceLeftLabel.AutoSize = true;
			this.serviceLeftLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.serviceLeftLabel.Location = new System.Drawing.Point(21, 64);
			this.serviceLeftLabel.Name = "serviceLeftLabel";
			this.serviceLeftLabel.Size = new System.Drawing.Size(62, 21);
			this.serviceLeftLabel.TabIndex = 1;
			this.serviceLeftLabel.Text = "左ペイン";
			// 
			// serviceLeftCombo
			// 
			this.serviceLeftCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.serviceLeftCombo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.serviceLeftCombo.FormattingEnabled = true;
			this.serviceLeftCombo.Location = new System.Drawing.Point(90, 62);
			this.serviceLeftCombo.Name = "serviceLeftCombo";
			this.serviceLeftCombo.Size = new System.Drawing.Size(250, 29);
			this.serviceLeftCombo.TabIndex = 2;
			this.serviceLeftCombo.SelectedIndexChanged += new System.EventHandler(this.serviceLeftCombo_SelectedIndexChanged);
			// 
			// serviceRightLabel
			// 
			this.serviceRightLabel.AutoSize = true;
			this.serviceRightLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.serviceRightLabel.Location = new System.Drawing.Point(371, 64);
			this.serviceRightLabel.Name = "serviceRightLabel";
			this.serviceRightLabel.Size = new System.Drawing.Size(62, 21);
			this.serviceRightLabel.TabIndex = 3;
			this.serviceRightLabel.Text = "右ペイン";
			// 
			// serviceRightCombo
			// 
			this.serviceRightCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.serviceRightCombo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.serviceRightCombo.FormattingEnabled = true;
			this.serviceRightCombo.Location = new System.Drawing.Point(440, 62);
			this.serviceRightCombo.Name = "serviceRightCombo";
			this.serviceRightCombo.Size = new System.Drawing.Size(250, 29);
			this.serviceRightCombo.TabIndex = 4;
			this.serviceRightCombo.SelectedIndexChanged += new System.EventHandler(this.serviceRightCombo_SelectedIndexChanged);
			// 
			// serviceLeftText
			// 
			this.serviceLeftText.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.serviceLeftText.Location = new System.Drawing.Point(90, 98);
			this.serviceLeftText.Name = "serviceLeftText";
			this.serviceLeftText.Size = new System.Drawing.Size(250, 29);
			this.serviceLeftText.TabIndex = 5;
			this.serviceLeftText.TextChanged += new System.EventHandler(this.serviceLeftText_TextChanged);
			// 
			// serviceRightText
			// 
			this.serviceRightText.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.serviceRightText.Location = new System.Drawing.Point(440, 98);
			this.serviceRightText.Name = "serviceRightText";
			this.serviceRightText.Size = new System.Drawing.Size(250, 29);
			this.serviceRightText.TabIndex = 6;
			this.serviceRightText.TextChanged += new System.EventHandler(this.serviceRightText_TextChanged);
			// 
			// serviceLeftButton
			// 
			this.serviceLeftButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.serviceLeftButton.Location = new System.Drawing.Point(90, 134);
			this.serviceLeftButton.Name = "serviceLeftButton";
			this.serviceLeftButton.Size = new System.Drawing.Size(120, 32);
			this.serviceLeftButton.TabIndex = 7;
			this.serviceLeftButton.Text = "更新";
			this.serviceLeftButton.UseVisualStyleBackColor = true;
			this.serviceLeftButton.Click += new System.EventHandler(this.serviceLeftButton_Click);
			// 
			// serviceRightButton
			// 
			this.serviceRightButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.serviceRightButton.Location = new System.Drawing.Point(440, 134);
			this.serviceRightButton.Name = "serviceRightButton";
			this.serviceRightButton.Size = new System.Drawing.Size(120, 32);
			this.serviceRightButton.TabIndex = 8;
			this.serviceRightButton.Text = "更新";
			this.serviceRightButton.UseVisualStyleBackColor = true;
			this.serviceRightButton.Click += new System.EventHandler(this.serviceRightButton_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.serviceRightButton);
			this.Controls.Add(this.serviceLeftButton);
			this.Controls.Add(this.serviceRightText);
			this.Controls.Add(this.serviceLeftText);
			this.Controls.Add(this.serviceRightCombo);
			this.Controls.Add(this.serviceRightLabel);
			this.Controls.Add(this.serviceLeftCombo);
			this.Controls.Add(this.serviceLeftLabel);
			this.Controls.Add(this.serviceLabel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "設定";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label serviceLabel;
		private System.Windows.Forms.Label serviceLeftLabel;
		private System.Windows.Forms.ComboBox serviceLeftCombo;
		private System.Windows.Forms.Label serviceRightLabel;
		private System.Windows.Forms.ComboBox serviceRightCombo;
		private System.Windows.Forms.TextBox serviceLeftText;
		private System.Windows.Forms.TextBox serviceRightText;
		private System.Windows.Forms.Button serviceLeftButton;
		private System.Windows.Forms.Button serviceRightButton;
	}
}