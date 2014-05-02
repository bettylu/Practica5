using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practica5
{
	
	public partial class MainForm : Form
	{
		int pts = 0;
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		void RespuestasCheckedChanged(object sender, EventArgs e)
		{
			
		}
		void MonthCalendar1DateChanged(object sender, DateRangeEventArgs e)
		{
			
		}
		void Button1Click(object sender, System.EventArgs e)
		{
			string contestar = "";
			contestar = this.btnContestar.Text; 
			
			if(this.checkBox1.Checked & this.checkBox4.Checked){
				contestar = "Preguntas Correctas 1 de 4";
			}
			
			if(this.checkBox1.Checked & this.checkBox4.Checked & this.radioButton2.Checked){
				contestar = "Preguntas Correctas 2 de 4";
			}
			
			if(this.checkBox1.Checked & this.checkBox4.Checked & this.radioButton2.Checked
			   & this.comboBox1.Text == "31"){
				contestar = "Preguntas Correctas 3 de 4";
			}
			
			if(this.checkBox1.Checked & this.checkBox4.Checked & this.radioButton2.Checked
			   & this.comboBox1.Text == "31" & 
			   this.monthCalendar1.SelectionStart.Date.ToShortDateString() == "16/09/1810"){
				contestar = "Preguntas Correctas 4 de 4 , Felicidades!! Acertaste todas ";				
			}
			
			 System.Windows.Forms.MessageBox.Show(contestar); 
		}
		
		
	}
		
		
}
		
		
