using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string path = Environment.CurrentDirectory + "\\" + "sample.txt";

		private void button1_Click(object sender, EventArgs e)
		{
			
			
			FileStream f = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
			MessageBox.Show("File created");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			using (StreamWriter sw = new StreamWriter(path))
			{
				sw.WriteLine("hello");
			}
			MessageBox.Show("File edited");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			using (StreamReader sr = new StreamReader(path))
			{
				string txt = sr.ReadLine();
				richTextBox1.Text = txt;
			}
			MessageBox.Show("File opened");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			File.Delete(path);
			MessageBox.Show("File Deleted");
		}
	}
}
