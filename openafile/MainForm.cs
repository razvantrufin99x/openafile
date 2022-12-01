/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 10/21/2020
 * Time: 6:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace openafile
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			openFileDialog1.ShowDialog();
			string [] randuri;
			randuri = File.ReadAllLines(openFileDialog1.FileName);
			foreach (string element in randuri) {
				textBox1.Text += element + "\r\n";
			}
			}
			catch{}
			
		}
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			saveFileDialog1.ShowDialog();
			saveFileDialog1.FileName = "fila.tmp";
			string [] lineArray = textBox1.Lines;
           	string fila = saveFileDialog1.FileName;
			

            
			File.WriteAllLines(fila, lineArray);
			
				}
			
			catch{}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
		/*
 //nu merge 
	try{
		FileStream fout;
	saveFileDialog1.ShowDialog();
	saveFileDialog1.FileName = "fila.tmp";

	fout = new FileStream(openFileDialog1.FileName, FileMode.Create);

	fout.WriteByte(1);
	for(int i = 0; i< textBox1.Text.Length; i++){
		fout.WriteByte((byte) textBox1.Text[i]);
		Text = textBox1.Text[i].ToString();
	}
	//File.WriteAllLines(fileName, lineArray);
	fout.Close();
		}

	catch{}
 */
	}
}
