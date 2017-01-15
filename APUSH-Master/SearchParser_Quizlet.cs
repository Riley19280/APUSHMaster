using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using APUSH_Master;

class SearchParser_Quizlet
{

	class quizletEntry
	{

		public quizletEntry(string titl, string def, string html)
		{
			title = titl;
			text = def;
			this.html = html;
			value = 0;
		}
		public string html;
		public string title;
		public string text;
		public int value;
	}

	public string OUTPUT;

	string searchTerm = "";
	List<string> termList = new List<string>();


	WebBrowser b = new WebBrowser();

	string quizletHTML = "";
	bool pageIsLoaded = false;

	public SearchParser_Quizlet(string HTML, string term, Form1 main)
	{
		searchTerm = term;

		MatchCollection m = Regex.Matches(HTML, @"<div class=.g.>((.|\n)*?)<br><\/div><\/div>");//the google search result class


		string url = Regex.Match(m[0].ToString(), @"<a href=((.|\n)*?>)").ToString().Remove(0, 16);//the url in the search result
		url = Regex.Replace(url, @"\/&amp((.|\n)*?>)", "");


		b.ScriptErrorsSuppressed = true;
		b.Navigate(url);//going to quizlet
		b.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(pageLoaded);

		while (!pageIsLoaded) { Application.DoEvents(); }

		MatchCollection quzentries = Regex.Matches(quizletHTML, @"<DIV class=.term ((.|\n)*?). data-id=.[0-9]+.>((.|\n)*?)<\/P><\/DIV><\/DIV>");
	
		List<quizletEntry> entries = new List<quizletEntry>();

		foreach (Match s in quzentries)
		{
			quizletEntry q = new quizletEntry(RipTags(Regex.Match(s.ToString(), @"<H3 class=.word ((.|\n)*?)<\/SPAN>").ToString()), RipTags(Regex.Match(s.ToString(), @"<P class=.definition ((.|\n)*?)<\/SPAN>").ToString()), s.ToString());		
			q.html = Regex.Replace(q.html, @"<DIV class=.details((.|\n)*?)<\/DIV><\/DIV><\/DIV>", "");
			entries.Add(q);
		}

		quizletEntry final = new quizletEntry(searchTerm, "NOT FOUND", "");//the final results

		foreach (string s in searchTerm.Split(' '))
			termList.Add(s);

		//assigning point values
		foreach (quizletEntry s in entries)
		{
			

			foreach (string t in termList)
			{
				if (s.title.ToLower().Contains(t.ToLower()))
					s.value += 2;
				if (s.text.ToLower().Contains(t.ToLower()))
					s.value += 1;
			}

			if (s.value > final.value)
				final = s;
		}
		if (final.text != "NOT FOUND")
			main.setStatus("Word completed: " + searchTerm);
		else
			main.setStatus("ERROR - WORD NOT FOUND: " + searchTerm);
		main.builtHTML += final.html;
		OUTPUT += ReplaceNewLine(final.title) + "\n" + ReplaceNewLine(final.text) + "\n\n";
		//OUTPUT = m[0].ToString();

	}
	private void pageLoaded(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		quizletHTML = b.DocumentText;
		pageIsLoaded = true;
	}

	private string RipTags(string s)
	{
		s = Regex.Replace(s, @"<style>(.|\n)*?<\/style>", string.Empty);
		s = Regex.Replace(s, @"<script(.|\n)*?>(.|\n)*?<\/script>", string.Empty);
		s = Regex.Replace(s, "<(.|\n)*?>", "");
		s = Regex.Replace(s, "\n*\n", "\n");
		return s;
	}

	private string ReplaceNewLine(string s)
	{
		s = Regex.Replace(s, @"\r\n?|\n", "");
		return s;
	}
}

