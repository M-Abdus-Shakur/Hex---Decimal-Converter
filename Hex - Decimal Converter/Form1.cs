using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hex___Decimal_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hex_btn_Click(object sender, EventArgs e)
        {
            int dec = int.Parse(num1.Text);
            num2.Text = dec.ToString("x");
        }

        private void dec_btn_Click(object sender, EventArgs e)
        {
            string hex = num1.Text;
            int dec = Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            num2.Text = dec.ToString();
        }
    }
}
