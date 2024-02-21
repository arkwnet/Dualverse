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
			this.panelLeft = new System.Windows.Forms.Panel();
			this.webView2Left = new Microsoft.Web.WebView2.WinForms.WebView2();
			this.panelRight = new System.Windows.Forms.Panel();
			this.webView2Right = new Microsoft.Web.WebView2.WinForms.WebView2();
			this.panelLeft.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.webView2Left)).BeginInit();
			this.panelRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.webView2Right)).BeginInit();
			this.SuspendLayout();
			// 
			// panelLeft
			// 
			this.panelLeft.Controls.Add(this.webView2Left);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLeft.Location = new System.Drawing.Point(0, 0);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(512, 561);
			this.panelLeft.TabIndex = 2;
			// 
			// webView2Left
			// 
			this.webView2Left.AllowExternalDrop = true;
			this.webView2Left.CreationProperties = null;
			this.webView2Left.DefaultBackgroundColor = System.Drawing.Color.White;
			this.webView2Left.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webView2Left.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.webView2Left.Location = new System.Drawing.Point(0, 0);
			this.webView2Left.Name = "webView2Left";
			this.webView2Left.Size = new System.Drawing.Size(512, 561);
			this.webView2Left.TabIndex = 1;
			this.webView2Left.ZoomFactor = 1D;
			// 
			// panelRight
			// 
			this.panelRight.Controls.Add(this.webView2Right);
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelRight.Location = new System.Drawing.Point(512, 0);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(496, 561);
			this.panelRight.TabIndex = 3;
			// 
			// webView2Right
			// 
			this.webView2Right.AllowExternalDrop = true;
			this.webView2Right.CreationProperties = null;
			this.webView2Right.DefaultBackgroundColor = System.Drawing.Color.White;
			this.webView2Right.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webView2Right.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.webView2Right.Location = new System.Drawing.Point(0, 0);
			this.webView2Right.Name = "webView2Right";
			this.webView2Right.Size = new System.Drawing.Size(496, 561);
			this.webView2Right.TabIndex = 2;
			this.webView2Right.ZoomFactor = 1D;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 561);
			this.Controls.Add(this.panelRight);
			this.Controls.Add(this.panelLeft);
			this.Name = "MainForm";
			this.Text = "Dualverse";
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.panelLeft.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.webView2Left)).EndInit();
			this.panelRight.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.webView2Right)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelLeft;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView2Left;
		private System.Windows.Forms.Panel panelRight;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView2Right;
	}
}

