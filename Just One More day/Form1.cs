using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just_One_More_day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Item1_Click(object sender, EventArgs e)
        {

        }

        private void OknoWyboru_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (OknoWyboru.SelectedIndex)
            {
                case 0:
                    if(OknoWyboru.Items[0] == "Start Game") { 
                    OknoDialogu.AppendText("1");
                        POV.Image = Properties.Resources.nuke;
                        OknoWyboru.SelectedItem = null;
                        OknoWyboru.Items[0] = "Restart";
                    }
                    else if(OknoWyboru.Items[0] == "Restart")
                    {
                        POV.Image = Properties.Resources.Menu1;
                        OknoWyboru.SelectedItem = null;
                        OknoWyboru.Items[0] = "Start Game";
                        OknoDialogu.Text = null;
                    }
                    break;
                case 1:
                    this.Close();
                    break;
                case 2:
                    OknoDialogu.AppendText("\n3");
                    break;

            }
        }
    }
}
