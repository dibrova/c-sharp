using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string textB
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Program.Frm1.textB = textB;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Frm1.Close();
        }
    }
    
}
