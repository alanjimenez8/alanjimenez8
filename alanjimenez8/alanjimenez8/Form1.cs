/*
 * Created by SharpDevelop.
 * User: CC2-PC44
 * Date: 20/11/2024
 * Time: 03:20 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace alanjimenez8
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		int a=0;
		int b,c,d,x,f;
		void Button1Click(object sender, EventArgs e)
		{
			int s=int.Parse(textBox2.Text);
			if(a+s>100){
				MessageBox.Show("Excedes el 100%");
			}
			else {
				if(comboBox1.SelectedIndex == 0){
					b+=s;
				}
				else if(comboBox1.SelectedIndex == 1){
					c+=s;
				}
				else if(comboBox1.SelectedIndex == 2){
					d+=s;
				}
				else if(comboBox1.SelectedIndex == 3){
					x=x+s;
				}
				else if(comboBox1.SelectedIndex == 4){
					f+=s;
				}
				else{
				a-=s;
				MessageBox.Show("NO SELECCIONASTE NADA");
				}
				a+=s;
			}
			string h=string.Empty;
			textBox2.Text=h;
		}
		
		void Button2Click(object sender, EventArgs e)
		{	
			int op=int.Parse(textBox1.Text);
			if(a!=100){
				int p=100-a;
				MessageBox.Show(p.ToString(),"te falta del porcentaje");
			}
			else if(op==0){
				MessageBox.Show("No hay trabajadores")
			}
			else{
			int g=int.Parse(textBox1.Text);
			b=(50*b)*g/100;
			MessageBox.Show(b.ToString(),"El valor del aserrin es");
			b=0;
			a=0;
			if(x>0){
				x=(45*x)*g/100;
			MessageBox.Show(x.ToString(),"El valor del flores es");
			x=0;
			}
			if(d>0){
			d=(21*d)*g/100;
			MessageBox.Show(d.ToString(),"El valor del frutos secos es");
			d=0;	
			}
			if(c>0){
			c=(53*c)*g/100;
			MessageBox.Show(d.ToString(),"El valor del pintura es");
			d=0;	
			}
			if(f>0){
			d=(96*d)*g/100;
			MessageBox.Show(d.ToString(),"El valor del agua es");
			d=0;	
			}
			op=op*500;
			MessageBox.Show(op.ToString(),"El valor de la mano de obra");
			}
		}
	}
}
