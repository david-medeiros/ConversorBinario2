using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorBinario2
{
    public partial class Form1 : Form
    {
        string text;
        int numero;
        string bin = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void BotãoConverter(object sender, EventArgs e)
        {
            text = textBox2.Text;
            numero = Convert.ToInt32(text);
            int num = numero;
            string b = "";
            //if (num = 0)
            //{ textBox1.Text = 0; }
            while (num > 0)
            {
                b += (num % 2).ToString();
                num = num / 2;
            }
            char[] result = b.ToCharArray();
            Array.Reverse(result);
            b = string.Join("", result);
            textBox1.Text = b;
        }
    }
}
