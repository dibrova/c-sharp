using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tm.Interval=(5000);
            tm.Start();
            tm.Tick += Tm_Tick;
            graph = Graphics.FromImage(bmp);
        }

        Timer tm = new Timer();
        String filename;
        Graphics graph;
        Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);


        private void Tm_Tick(object sender, EventArgs e)
        {
            filename = ("img_" + System.DateTime.Now.Hour.ToString() + "-"
                + System.DateTime.Now.Minute.ToString() + "-"
                + System.DateTime.Now.Second.ToString() + ".png");

            graph.CopyFromScreen(0, 0, 0, 0, bmp.Size);
            bmp.Save(filename);
            pictureBox1.Image = System.Drawing.Image.FromFile(filename);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tm.Enabled) {
                tm.Stop();
                button1.Text = "Start";
            }
            else {
                tm.Start();
                button1.Text = "Stop";
            }
        }
    }
}
