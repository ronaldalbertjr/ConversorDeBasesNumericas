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
        string number2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    number = Convert.ToUInt64(textBox1.Text);
                    textBox2.Text = Convert.ToString(NumericBases.decimalToBinary(number));
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
            else
            {
                try
                {
                    number2 = textBox2.Text;
                    textBox1.Text = Convert.ToString(NumericBases.binaryToDecimal(number2));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Isso não é um binario");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                number = Convert.ToUInt64(textBox1.Text);
                textBox3.Text = NumericBases.decimalToHexadecimal(number);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
