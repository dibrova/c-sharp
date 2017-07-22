using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int numButton = 1;
        int xyOffSet = 5;
        int xPos, yPos;
        Size buttonSize = new Size (50,25);
        
        const int N = 10, M = 10;
        Button[,] arrayButton = new Button[N, M];
        ToolTip tTip = new ToolTip();

        public Form1()
        {
            xPos = xyOffSet;
            yPos = xyOffSet;
            InitializeComponent();
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < M; j++) {
                    arrayButton[i, j] = new Button();
                    arrayButton[i, j].Text = numButton.ToString();
                    arrayButton[i, j].Location = new Point(xPos, yPos);
                    arrayButton[i, j].Size = buttonSize;
                    arrayButton[i, j].Click += Form1_mClick;
                    tTip.SetToolTip(arrayButton[i, j], $"строка: {i + 1}, столбец: {j + 1}");
                    this.Controls.Add(arrayButton[i, j]);
                    xPos += buttonSize.Width + xyOffSet;
                    numButton++;
                }
                yPos += buttonSize.Height + xyOffSet;
                xPos = xyOffSet;
            }
        }

        private void Form1_mClick(object sender, EventArgs e) {
            this.Controls.Remove((Button)sender);
        }
    }
}
