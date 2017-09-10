using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        private Graphics g;
        
        public Form1()
        {
            InitializeComponent();
        }

               
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();
            
            // Создаем два прямоугольника
            Rectangle rect1 = new Rectangle(100, 100, 120, 120);
            Rectangle rect2 = new Rectangle(70, 70, 120, 120);
            
            
            // Создаем два региона
            Region rgn1 = new Region(rect1);
            Region rgn2 = new Region(rect2);
            

            // рисуем прямоугольники
            g.DrawRectangle(Pens.Green, rect1);
            g.DrawRectangle(Pens.Red, rect2);
            g.FillRegion(Brushes.LightSkyBlue, rgn1);

            g.TranslateTransform(40, 20);
            
            g.DrawEllipse(new Pen (Color.Tan,10), 50, 50, 100, 130);
            g.FillEllipse(Brushes.GreenYellow, 55, 55, 90, 120);
            g.FillEllipse(Brushes.GreenYellow, 75, 30, 50, 30);
            g.FillEllipse(Brushes.GreenYellow, 85, 15, 30, 50);

            g.FillEllipse(Brushes.Yellow, 73, 105,55, 60);
            g.FillRectangle(Brushes.Yellow, 73, 78, 55, 60);

            g.FillEllipse(Brushes.GreenYellow, 40, 130, 25, 25);
            g.FillEllipse(Brushes.GreenYellow, 130, 130, 25, 25);
            g.FillRectangle(Brushes.GreenYellow, 80, 165, 15, 40);
            g.FillPie(Brushes.Red, 80, 40, 30, 20, 0, 30);
            g.FillRectangle(Brushes.GreenYellow, 108, 165, 15, 40);

            g.FillRectangle(Brushes.Blue, 80, 25, 40, 10);
            g.FillRectangle(Brushes.Blue, 80, 190, 15, 10);
            g.FillRectangle(Brushes.Blue, 108, 190, 15, 10);

            g.DrawLine(new Pen(Color.Silver, 5), 30, 50, 50, 140);
            g.DrawLine(new Pen(Color.Silver, 5), 178, 50, 145, 140);

            g.FillEllipse(Brushes.LightSkyBlue, 85, 25, 10, 10);
            g.FillEllipse(Brushes.LightSkyBlue, 105, 25, 10, 10);

            g.FillEllipse(Brushes.Black, 86, 28, 5, 7);
            g.FillEllipse(Brushes.Black, 106, 28, 5, 7);

            g.DrawEllipse(new Pen(Color.Black, 1), 85, 25, 10, 10);
            g.DrawEllipse(new Pen(Color.Black, 1), 105, 25, 10, 10);

            g.Dispose();
            this.BackColor = Color.Black;
        }
    }
    }
