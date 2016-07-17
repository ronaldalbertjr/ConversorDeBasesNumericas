using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbeToBinaryConverter
{
    public partial class Form1 : Form
    {
        ulong number;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                number = Convert.ToUInt64(textBox1.Text);
                textBox2.Text = Convert.ToString(Bin.numberToBin(number));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Esse caractere não é um numero");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Número Não Aceito");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                number = Convert.ToUInt64(textBox1.Text);
                textBox3.Text = Bin.decimalToHexadecimal(number);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Esse caractere não é um numero");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Número Não Aceito");
            }
        }
    }
}
