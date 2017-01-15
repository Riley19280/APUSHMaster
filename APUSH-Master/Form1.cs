using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APUSH_Master
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(pageLoaded);
			browser.ScriptErrorsSuppressed = true;
			//checking for internet connectivity
			try
			{
				using (var client = new WebClient())
				{
					using (var stream = client.OpenRead("http://www.google.com"))
					{

					}
				}
			}
			catch
			{
				MessageBox.Show("No internet connection detected. You need internet for this application to work.");
			}
		}

		public string builtHTML;

		public List<string> words = new List<string>();

		WebBrowser browser = new WebBrowser();

		private void loadWords()
		{
			words.Clear();
			int counter = 0;
			string line;
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Choose a text file with a list of terms";
			// Read the file and display it line by line. 
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				try
				{

					StreamReader file = new StreamReader(ofd.OpenFile());
					while ((line = file.ReadLine()) != null)
					{
						words.Add(line);
						counter++;
					}

					file.Close();
					rtConsole.AppendText("\n" + counter + " words read from file");
				}
				catch (Exception e)
				{
					MessageBox.Show("Error reading file: \n" + e.StackTrace);
				}
			}
		}

		private void sendHTMLrequest()
		{
			if (words.Count > 0)
			{
				string s = words[0].Replace('\'', ' ');
				s = words[0].Replace('-', ' ');
				s = words[0].Replace(' ', '+');
				rtConsole.AppendText("\n" + words[0]);

				browser.Navigate("http://www.google.com/#q=" + words[0] + "+apush");
				setStatus("Retrieving word: " + words[0]);
			}
		}

		private void pageLoaded(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			if (words.Count > 0)
			{
				setStatus("Parsing word: " + words[0]);
				SearchParser_Quizlet spq = new SearchParser_Quizlet(browser.DocumentText, words[0], this);
				rtList.Text += spq.OUTPUT + "\n";
				setStatus("Finished word: " + words[0]);
				words.RemoveAt(0);
				sendHTMLrequest();
			}

		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			loadWords();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			addWords v = new addWords(this);

			v.ShowDialog();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			rtList.Clear();
			setStatus("");
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			if (words.Count > 0)
				sendHTMLrequest();
			else
				MessageBox.Show("Please add some words before starting!");
		}

		private void rtList_TextChanged(object sender, EventArgs e)
		{
			rtList.SelectionStart = rtList.TextLength;
			rtList.ScrollToCaret();
		}

		public void setStatus(string s)
		{
			statusLabel.Text = s;
			statusBar.Refresh();
		}

		#region Menu Items

		private void webpageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFile1 = new SaveFileDialog();

			saveFile1.DefaultExt = "*.html";
			saveFile1.Filter = "HTML Files|*.html";

			if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
			{
				File.WriteAllText(saveFile1.FileName, "<html>" + builtHTML + "</html>");
				Process.Start(saveFile1.FileName);

			}
		}

		private void textDocumentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFile1 = new SaveFileDialog();

			saveFile1.DefaultExt = "*.txt";
			saveFile1.Filter = "TXT Files|*.txt";

			if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
			{
				rtList.SaveFile(saveFile1.FileName);
				setStatus("File Saved: " + saveFile1.FileName);
			}
		}

		private void restartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			rtList.Clear();
			rtConsole.Clear();
			words.Clear();
			setStatus("");
		}

		private void openListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadWords();
		}

		private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addWords v = new addWords(this);

			v.ShowDialog();
		}

		private void clearDisplayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			rtList.Clear();
		}

		private void startToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (words.Count > 0)
				sendHTMLrequest();
			else
				MessageBox.Show("Please add some words before starting!");
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Help v = new Help();
			v.ShowDialog();
		}
		#endregion

	}
}
