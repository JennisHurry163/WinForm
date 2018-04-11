using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SyntaxTester
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void m_buttonQuit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// Add the keywords to the list.
			m_syntaxRichTextBox.Settings.Keywords.Add("function");
			m_syntaxRichTextBox.Settings.Keywords.Add("if");
			m_syntaxRichTextBox.Settings.Keywords.Add("then");
			m_syntaxRichTextBox.Settings.Keywords.Add("else");
			m_syntaxRichTextBox.Settings.Keywords.Add("elseif");
			m_syntaxRichTextBox.Settings.Keywords.Add("end");

			// Set the comment identifier. For Lua this is two minus-signs after each other (--). 
			// For C++ we would set this property to "//".
			m_syntaxRichTextBox.Settings.Comment = "--";

			// Set the colors that will be used.
			m_syntaxRichTextBox.Settings.KeywordColor = Color.Blue;
			m_syntaxRichTextBox.Settings.CommentColor = Color.Green;
			m_syntaxRichTextBox.Settings.StringColor = Color.Gray;
			m_syntaxRichTextBox.Settings.IntegerColor = Color.Red;

			// Let's not process strings and integers.
			m_syntaxRichTextBox.Settings.EnableStrings = false;
			m_syntaxRichTextBox.Settings.EnableIntegers = false;

			// Let's make the settings we just set valid by compiling
			// the keywords to a regular expression.
			m_syntaxRichTextBox.CompileKeywords();

			// Load a file and update the syntax highlighting.
			m_syntaxRichTextBox.LoadFile("../../script.lua", RichTextBoxStreamType.PlainText);
			m_syntaxRichTextBox.ProcessAllLines();
		}
	}
}