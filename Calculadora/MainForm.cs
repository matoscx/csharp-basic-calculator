/*
 * Created by SharpDevelop.
 * User: carol
 * Date: 12/2/2023
 * Time: 3:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
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
		
		void MainFormLoad(object sender, EventArgs e) //boton borrar
		{
			
		}
		double var1=0;
		string op="";

		
		void Button1Click(object sender, EventArgs e) //boton borrar
		{
			var1=0;
			textBox1.Text="";
		}
		
		void Button16Click(object sender, EventArgs e) //boton igual
		{
			switch(op)
			{
					case"+": textBox1.Text =(var1+Convert.ToDouble(textBox1.Text)).ToString();break;
					case"-": textBox1.Text =(var1-Convert.ToDouble(textBox1.Text)).ToString();break;
					case"*": textBox1.Text =(var1*Convert.ToDouble(textBox1.Text)).ToString();break;
					case"/": textBox1.Text =(var1/Convert.ToDouble(textBox1.Text)).ToString();break;
					
			}
		}
		
		void Button7Click(object sender, EventArgs e) //boton 1
		{
			textBox1.Text += "1";
				
		}
		
		void Button13Click(object sender, EventArgs e) //boton 2
		{
			textBox1.Text += "2";
		}
		
		void Button12Click(object sender, EventArgs e) //boton 3
		{
			textBox1.Text += "3";
		}
		
		void Button10Click(object sender, EventArgs e) //boton 4
		{
			textBox1.Text += "4";
		}
		
		void Button8Click(object sender, EventArgs e) //boton 5
		{
			textBox1.Text += "5";
		}
		
		void Button9Click(object sender, EventArgs e) //boton 6
		{
			textBox1.Text += "6";
		}
		
		void Button4Click(object sender, EventArgs e) //boton 7
		{
			textBox1.Text += "7";
		}
		
		void Button2Click(object sender, EventArgs e) //boton 8
		{
			textBox1.Text += "8";
		}
		
		void Button3Click(object sender, EventArgs e) //boton 9
		{
			textBox1.Text += "9";
		}
		
		void Button17Click(object sender, EventArgs e) //boton 0
		{
			if (textBox1.Text!="0" && textBox1.Text!="")textBox1.Text += "0";
		}
		
		void Button6Click(object sender, EventArgs e) //boton suma
			
		{
            var1=Convert.ToDouble(textBox1.Text);
			textBox1.Text="";
			op="+";
		}
		
		void Button11Click(object sender, EventArgs e) //boton multiplicación
		{
			var1=Convert.ToDouble(textBox1.Text);
			textBox1.Text="";
			op="*";
		}
		
		void Button14Click(object sender, EventArgs e) //boton radicación 
		{
			textBox1.Text=(Math.Sqrt(Convert.ToDouble(textBox1.Text))).ToString();
		}
		
		void Button5Click(object sender, EventArgs e) //boton resta
		{
		    var1=Convert.ToDouble(textBox1.Text);
		    textBox1.Text="";
		    op="-";	
		}
		
		void Button15Click(object sender, EventArgs e) //boton división
		{
			var1=Convert.ToDouble(textBox1.Text);
			textBox1.Text="";
			op="/";
		}
	}
}
