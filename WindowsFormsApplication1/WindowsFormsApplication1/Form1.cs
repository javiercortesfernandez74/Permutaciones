using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private TOrden lis;
        public Form1()
        {
            InitializeComponent();
            lis = new TOrden(new int[100]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lis = new TOrden(textBox1.Text);
            lis.perm();
            textBox1.Text += " --> "+lis.ToString();
        }
    }
}
