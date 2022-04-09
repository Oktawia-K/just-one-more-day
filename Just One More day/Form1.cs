using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Just_One_More_day
{
    public partial class Form1 : Form
    {
        int charIndex = 0;
        //Soundtracks bgmusic = new Soundtracks();

        public Form1()
        {
            InitializeComponent();
            //OknoDialogu.AppendText(System.IO.Path.GetFullPath(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\..\Sounds\nuke incoming.wav")));
            Soundtracks.playmusic(0);
        }

        public class Soundtracks
        {
            static string firstSong = System.IO.Path.GetFullPath(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\..\Sounds\menu theme.wav"));
            static string[] ost = new string[] {firstSong};
         
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
               public static string prolog = "Hello world!!";
           
        }

        private void Animacjatekstu(string tekst)
        {
            while (charIndex < tekst.Length)
            {
                Thread.Sleep(35);
                OknoDialogu.Invoke(new Action(() =>
                {
                    OknoDialogu.Text += tekst[charIndex];
                }));
                charIndex++;
            }
        }

        private void game_start()
        {
            string SoundFile = System.IO.Path.GetFullPath(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\..\Sounds\nuke incoming.wav"));
            SoundPlayer splayer = new SoundPlayer(SoundFile);           

            if ((string)OknoWyboru.Items[0] == "Start Game")
            {
                charIndex = 0;
                OknoDialogu.Text = string.Empty;
                Thread t = new Thread(new ThreadStart(this.Animacjatekstu(Fabula.prolog)));
                t.Start();

                POV.Image = Properties.Resources.nuke;
                OknoWyboru.SelectedItem = null;
                OknoWyboru.Items[0] = "Restart";
                Soundtracks.stopmusic();
                //splayer.Play();              
       
            }
            else if ((string)OknoWyboru.Items[0] == "Restart")
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

        private void POV_Click(object sender, EventArgs e)
        {

        }
    }
}
