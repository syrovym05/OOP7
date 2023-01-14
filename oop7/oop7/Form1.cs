using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produkt produkt = new Produkt(textBox1.Text, (int)numericUpDown1.Value, dateTimePicker1.Value, (int)numericUpDown2.Value, checkBox1.Checked);
            label6.Text = produkt.ToString();
        }
    }
}
