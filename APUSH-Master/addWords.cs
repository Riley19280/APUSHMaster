using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APUSH_Master
{
	public partial class addWords : Form
	{
		Form1 main;
		public addWords(Form1 m)
		{
			InitializeComponent();

			main = m;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			string[] lines = richTextBox1.Lines;
			foreach (string s in lines)
			{
				if (s != "" && s != Environment.NewLine && s != "\n\r" && s != "\n" && s != "\r")
					main.words.Add(s);
			}
			main.rtConsole.AppendText(main.words.Count + " words added!\n");
			main.setStatus(main.words.Count + " words added!");

			this.Close();

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
