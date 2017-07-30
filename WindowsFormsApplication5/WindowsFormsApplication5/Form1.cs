using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        int count = 0;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(count.ToString());
            
            item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem });

            toolStripMenuItem.MouseHover += (this.toolStripMenuItem1_MouseHover);
            item.MouseHover-= (this.toolStripMenuItem1_MouseHover);

            count++;
        }
    }
}
