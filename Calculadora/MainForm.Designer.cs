/*
 * Created by SharpDevelop.
 * User: carol
 * Date: 12/2/2023
 * Time: 3:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculadora
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(18, 24);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(145, 32);
			this.textBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Brown;
			this.button1.Location = new System.Drawing.Point(120, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 27);
			this.button1.TabIndex = 1;
			this.button1.Text = "C";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Black;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(69, 111);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(44, 29);
			this.button2.TabIndex = 2;
			this.button2.Text = "8";
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Black;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.Location = new System.Drawing.Point(118, 111);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(43, 29);
			this.button3.TabIndex = 3;
			this.button3.Text = "9";
			this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Black;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button4.Location = new System.Drawing.Point(21, 111);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(42, 29);
			this.button4.TabIndex = 4;
			this.button4.Text = "7";
			this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Black;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button5.Location = new System.Drawing.Point(69, 291);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(44, 29);
			this.button5.TabIndex = 5;
			this.button5.Text = "-";
			this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Black;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button6.Location = new System.Drawing.Point(119, 291);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(42, 29);
			this.button6.TabIndex = 6;
			this.button6.Text = "+";
			this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Black;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button7.Location = new System.Drawing.Point(22, 200);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(41, 29);
			this.button7.TabIndex = 7;
			this.button7.Text = "1";
			this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.Black;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button8.Location = new System.Drawing.Point(69, 156);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(44, 29);
			this.button8.TabIndex = 8;
			this.button8.Text = "5";
			this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.Black;
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button9.Location = new System.Drawing.Point(118, 156);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(43, 29);
			this.button9.TabIndex = 9;
			this.button9.Text = "6";
			this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.Black;
			this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button10.Location = new System.Drawing.Point(21, 156);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(42, 29);
			this.button10.TabIndex = 10;
			this.button10.Text = "4";
			this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.Black;
			this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button11.Location = new System.Drawing.Point(119, 247);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(42, 29);
			this.button11.TabIndex = 11;
			this.button11.Text = "*";
			this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new System.EventHandler(this.Button11Click);
			// 
			// button12
			// 
			this.button12.BackColor = System.Drawing.Color.Black;
			this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button12.Location = new System.Drawing.Point(119, 200);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(42, 29);
			this.button12.TabIndex = 12;
			this.button12.Text = "3";
			this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Click += new System.EventHandler(this.Button12Click);
			// 
			// button13
			// 
			this.button13.BackColor = System.Drawing.Color.Black;
			this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button13.Location = new System.Drawing.Point(70, 200);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(43, 29);
			this.button13.TabIndex = 13;
			this.button13.Text = "2";
			this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button13.UseVisualStyleBackColor = false;
			this.button13.Click += new System.EventHandler(this.Button13Click);
			// 
			// button14
			// 
			this.button14.BackColor = System.Drawing.Color.Black;
			this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button14.Location = new System.Drawing.Point(22, 291);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(41, 29);
			this.button14.TabIndex = 14;
			this.button14.Text = "√";
			this.button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button14.UseVisualStyleBackColor = false;
			this.button14.Click += new System.EventHandler(this.Button14Click);
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.Color.Black;
			this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button15.Location = new System.Drawing.Point(70, 247);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(43, 29);
			this.button15.TabIndex = 15;
			this.button15.Text = "/";
			this.button15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += new System.EventHandler(this.Button15Click);
			// 
			// button16
			// 
			this.button16.BackColor = System.Drawing.Color.Black;
			this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button16.Location = new System.Drawing.Point(98, 326);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(63, 37);
			this.button16.TabIndex = 16;
			this.button16.Text = "=";
			this.button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button16.UseVisualStyleBackColor = false;
			this.button16.Click += new System.EventHandler(this.Button16Click);
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.Color.Black;
			this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button17.Location = new System.Drawing.Point(22, 247);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(41, 29);
			this.button17.TabIndex = 17;
			this.button17.Text = "0";
			this.button17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += new System.EventHandler(this.Button17Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(183, 364);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "Calculadora";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
