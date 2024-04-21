namespace Dualverse
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelLeft = new System.Windows.Forms.Panel();
			this.webView2Left = new Microsoft.Web.WebView2.WinForms.WebView2();
			this.toolStripLeft = new System.Windows.Forms.ToolStrip();
			this.reloadButtonLeft = new System.Windows.Forms.ToolStripButton();
			this.panelRight = new System.Windows.Forms.Panel();
			this.webView2Right = new Microsoft.Web.WebView2.WinForms.WebView2();
			this.toolStripRight = new System.Windows.Forms.ToolStrip();
			this.reloadButtonRight = new System.Windows.Forms.ToolStripButton();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelLeft.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.webView2Left)).BeginInit();
			this.toolStripLeft.SuspendLayout();
			this.panelRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.webView2Right)).BeginInit();
			this.toolStripRight.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelLeft
			// 
			this.panelLeft.Controls.Add(this.webView2Left);
			this.panelLeft.Controls.Add(this.toolStripLeft);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLeft.Location = new System.Drawing.Point(0, 24);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(512, 537);
			this.panelLeft.TabIndex = 2;
			// 
			// webView2Left
			// 
			this.webView2Left.AllowExternalDrop = true;
			this.webView2Left.CreationProperties = null;
			this.webView2Left.DefaultBackgroundColor = System.Drawing.Color.White;
			this.webView2Left.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webView2Left.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.webView2Left.Location = new System.Drawing.Point(0, 25);
			this.webView2Left.Name = "webView2Left";
			this.webView2Left.Size = new System.Drawing.Size(512, 512);
			this.webView2Left.TabIndex = 1;
			this.webView2Left.ZoomFactor = 1D;
			this.webView2Left.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView2Left_NavigationCompleted);
			// 
			// toolStripLeft
			// 
			this.toolStripLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadButtonLeft});
			this.toolStripLeft.Location = new System.Drawing.Point(0, 0);
			this.toolStripLeft.Name = "toolStripLeft";
			this.toolStripLeft.Size = new System.Drawing.Size(512, 25);
			this.toolStripLeft.TabIndex = 2;
			this.toolStripLeft.Text = "toolStrip1";
			// 
			// reloadButtonLeft
			// 
			this.reloadButtonLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.reloadButtonLeft.Image = ((System.Drawing.Image)(resources.GetObject("reloadButtonLeft.Image")));
			this.reloadButtonLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.reloadButtonLeft.Name = "reloadButtonLeft";
			this.reloadButtonLeft.Size = new System.Drawing.Size(23, 22);
			this.reloadButtonLeft.Text = "再読み込み";
			this.reloadButtonLeft.Click += new System.EventHandler(this.reloadButtonLeft_Click);
			// 
			// panelRight
			// 
			this.panelRight.Controls.Add(this.webView2Right);
			this.panelRight.Controls.Add(this.toolStripRight);
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelRight.Location = new System.Drawing.Point(512, 24);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(496, 537);
			this.panelRight.TabIndex = 3;
			// 
			// webView2Right
			// 
			this.webView2Right.AllowExternalDrop = true;
			this.webView2Right.CreationProperties = null;
			this.webView2Right.DefaultBackgroundColor = System.Drawing.Color.White;
			this.webView2Right.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webView2Right.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.webView2Right.Location = new System.Drawing.Point(0, 25);
			this.webView2Right.Name = "webView2Right";
			this.webView2Right.Size = new System.Drawing.Size(496, 512);
			this.webView2Right.TabIndex = 2;
			this.webView2Right.ZoomFactor = 1D;
			this.webView2Right.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView2Right_NavigationCompleted);
			// 
			// toolStripRight
			// 
			this.toolStripRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadButtonRight});
			this.toolStripRight.Location = new System.Drawing.Point(0, 0);
			this.toolStripRight.Name = "toolStripRight";
			this.toolStripRight.Size = new System.Drawing.Size(496, 25);
			this.toolStripRight.TabIndex = 3;
			this.toolStripRight.Text = "toolStrip1";
			// 
			// reloadButtonRight
			// 
			this.reloadButtonRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.reloadButtonRight.Image = ((System.Drawing.Image)(resources.GetObject("reloadButtonRight.Image")));
			this.reloadButtonRight.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.reloadButtonRight.Name = "reloadButtonRight";
			this.reloadButtonRight.Size = new System.Drawing.Size(23, 22);
			this.reloadButtonRight.Text = "再読み込み";
			this.reloadButtonRight.Click += new System.EventHandler(this.reloadButtonRight_Click);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1008, 24);
			this.menuStrip.TabIndex = 4;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.fileToolStripMenuItem.Text = "ファイル(&F)";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.aboutToolStripMenuItem.Text = "Dualverse について(&A)";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.exitToolStripMenuItem.Text = "終了(&X)";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 561);
			this.Controls.Add(this.panelRight);
			this.Controls.Add(this.panelLeft);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "Dualverse";
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.panelLeft.ResumeLayout(false);
			this.panelLeft.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.webView2Left)).EndInit();
			this.toolStripLeft.ResumeLayout(false);
			this.toolStripLeft.PerformLayout();
			this.panelRight.ResumeLayout(false);
			this.panelRight.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.webView2Right)).EndInit();
			this.toolStripRight.ResumeLayout(false);
			this.toolStripRight.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelLeft;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView2Left;
		private System.Windows.Forms.Panel panelRight;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView2Right;
		private System.Windows.Forms.ToolStrip toolStripLeft;
		private System.Windows.Forms.ToolStripButton reloadButtonLeft;
		private System.Windows.Forms.ToolStrip toolStripRight;
		private System.Windows.Forms.ToolStripButton reloadButtonRight;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}

