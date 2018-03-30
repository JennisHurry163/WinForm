using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using UrielGuy.SyntaxHighlightingTextBox;

namespace Tester
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
        private Button button1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{	
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(336, 125);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Syntax Highlighting Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

        SyntaxHighlightingTextBox shtb = new SyntaxHighlightingTextBox();

        private void Form1_Load(object sender, System.EventArgs e)
		{
			
			shtb.Location = new Point(0,0);
			shtb.Dock = DockStyle.Fill;
			shtb.Seperators.Add(' ');
			shtb.Seperators.Add('\r');
			shtb.Seperators.Add('\n');
			shtb.Seperators.Add(',');
			shtb.Seperators.Add('.');
			shtb.Seperators.Add('-');
			shtb.Seperators.Add('+');
			//shtb.Seperators.Add('*');
			//shtb.Seperators.Add('/');
			Controls.Add(shtb);
			shtb.WordWrap = false;
			shtb.ScrollBars = RichTextBoxScrollBars.Both;// & RichTextBoxScrollBars.ForcedVertical;

			/*shtb.HighlightDescriptors.Add(new HighlightDescriptor("<", Color.Gray, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));

			shtb.HighlightDescriptors.Add(new HighlightDescriptor("<<", ">>", Color.DarkGreen, null, DescriptorType.ToCloseToken, DescriptorRecognition.StartsWith, false));
*/
			shtb.HighlightDescriptors.Add(new HighlightDescriptor("Hello", Color.Red, null, DescriptorType.Word, DescriptorRecognition.WholeWord, false));
			shtb.HighlightDescriptors.Add(new HighlightDescriptor("/*", "*/", Color.Magenta, null, DescriptorType.ToEOL, DescriptorRecognition.StartsWith, false));
		}

		private void syntaxHighlightingTextBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(shtb.Text);
        }
    }
}
