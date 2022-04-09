using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Just_One_More_day
{
    public partial class Form1 : Form
    {
        Soundtracks bgmusic = new Soundtracks();
        public Form1()
        {
            InitializeComponent();       
            Soundtracks.playmusic(0);
        }

        public class Soundtracks
        {
           static string[] ost = new string[] { @"C:\Users\user\source\repos\just-one-more-day\Just One More day\Sounds\menu theme.wav" };
         
                static public void playmusic(int MusicTrack)
                {
                  SoundPlayer musicplayer = new SoundPlayer(ost[MusicTrack]);
                  musicplayer.PlayLooping();
                }

            static public void stopmusic()
            {
                SoundPlayer musicplayer = new SoundPlayer();
                musicplayer.Stop();

            }

        }

        public class Fabula 
        { 

        }


        private void game_start()
        {
            string SoundFile = @"C:\Users\user\source\repos\just-one-more-day\Just One More day\Sounds\nuke incoming.wav";
            SoundPlayer splayer = new SoundPlayer(SoundFile);         

            if (OknoWyboru.Items[0] == "Start Game")
            {
                OknoDialogu.AppendText("1");
                POV.Image = Properties.Resources.nuke;
                OknoWyboru.SelectedItem = null;
                OknoWyboru.Items[0] = "Restart";
                Soundtracks.stopmusic();
                //splayer.Play();              
       
            }
            else if (OknoWyboru.Items[0] == "Restart")
            {
                POV.Image = Properties.Resources.Menu1;
                OknoWyboru.SelectedItem = null;
                OknoWyboru.Items[0] = "Start Game";
                OknoDialogu.Text = null;
                //splayer.Stop();
                Soundtracks.playmusic(0);
            }
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
                    game_start();
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
