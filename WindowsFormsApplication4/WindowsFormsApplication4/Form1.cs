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
        int count = 1;
        int mlsec = 0;

        public Form1()
        {
            
            tm.Interval = 100;
            tm.Tick += Tm_Tick;
            tm.Start();
            InitializeComponent();
            this.MouseClick += Form1_MouseClick;
            
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            mlsec++;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //this.BackColor=Color.Beige;
            ///MessageBox.Show($"MouseClick {count} {mlsec}");
            if (count == 3) {
                if (mlsec < 11)
                {
                    MessageBox.Show($"Mouse Triple Click!!! \n{count} Click\t{mlsec}");
                }
                else MessageBox.Show($"Whery Slow! \n{count} Click\t{mlsec}");
                count = 0;
                mlsec = 0;
            }
            count++;
        }
    }
}
