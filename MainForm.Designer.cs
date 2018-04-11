namespace SyntaxTester
{
	partial class MainForm
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
			this.m_syntaxRichTextBox = new SyntaxHighlighter.SyntaxRichTextBox();
			this.m_buttonQuit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// m_syntaxRichTextBox
			// 
			this.m_syntaxRichTextBox.AcceptsTab = true;
			this.m_syntaxRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_syntaxRichTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_syntaxRichTextBox.Location = new System.Drawing.Point(13, 13);
			this.m_syntaxRichTextBox.Name = "m_syntaxRichTextBox";
			this.m_syntaxRichTextBox.Size = new System.Drawing.Size(451, 304);
			this.m_syntaxRichTextBox.TabIndex = 0;
			this.m_syntaxRichTextBox.Text = "";
			// 
			// m_buttonQuit
			// 
			this.m_buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.m_buttonQuit.Location = new System.Drawing.Point(388, 324);
			this.m_buttonQuit.Name = "m_buttonQuit";
			this.m_buttonQuit.Size = new System.Drawing.Size(75, 23);
			this.m_buttonQuit.TabIndex = 2;
			this.m_buttonQuit.Text = "Quit";
			this.m_buttonQuit.Click += new System.EventHandler(this.m_buttonQuit_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 356);
			this.Controls.Add(this.m_buttonQuit);
			this.Controls.Add(this.m_syntaxRichTextBox);
			this.Name = "MainForm";
			this.Text = "Syntax-tester";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private SyntaxHighlighter.SyntaxRichTextBox m_syntaxRichTextBox;
		private System.Windows.Forms.Button m_buttonQuit;
	}
}

