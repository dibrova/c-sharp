using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        Timer tm = new Timer();
        int mlSec = 0;

        public Form1()
        {
            
            tm.Interval = 100;
            tm.Tick += Tm_Tick;
            tm.Start();
            InitializeComponent();
            this.MouseDoubleClick += Form1_MouseDoubleClick;
            this.BackColor = Color.Beige;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mlSec = 0;
            this.MouseClick += Form1_MouseClick1;
        }

        private void Form1_MouseClick1(object sender, MouseEventArgs e)
        {
            if (mlSec < 6) {
               this.BackColor = Color.GreenYellow;
               MessageBox.Show($"Triple Click!!! {mlSec}00ms");
                
            }
            else {
                this.BackColor = Color.DarkRed;
                MessageBox.Show($"Whery Slow! {mlSec}00ms");
                
            }
            this.BackColor = Color.Beige;
            this.MouseClick -= Form1_MouseClick1;
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            mlSec++;
        }
    }
}
