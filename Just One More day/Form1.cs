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
        static int charIndex = 0;
        static int tableindex = 0;
        //Soundtracks bgmusic = new Soundtracks();

        public List<string> ListaWyboru = new List<string>();

        


        public Form1()
        {
            InitializeComponent();
            ListaWyboru.Add("");
            ListaWyboru.Add("Start Game");
            ListaWyboru.Add("Exit Game");
            ListaWyboru.Add("");
            OknoWyboru.DataSource = ListaWyboru;
            OknoWyboru.SelectedIndex = -1;          
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
            static public string[] scenariusz = new string[] { "kill me",
              "Decydujesz się szybko wstać, wziąć cokolwiek jest pod ręką i szybko pobiec do osiedlowego bunkra Wybierz co chcesz ze sobą zabrać(masz tylko 2 ręce): ",
                "1) racje żywnościowe" +
                "\n2) broń" +
                "\n3) amunicja" +
                "\n4) mapa" +
                "\n5) dyplom ukończenia wsb",
                "cos"
                                                              }; 

        }

        public void Animacjatekstu()
        {
            string dialog = Fabula.scenariusz[tableindex];
            while (charIndex < dialog.Length)
            {
                Thread.Sleep(25);
                OknoDialogu.Invoke(new Action(() =>
                {
                    OknoDialogu.Text += dialog[charIndex];
                }));
                charIndex++;
            }
        }

        public void wyswietltekst()
        {
            charIndex = 0;
            OknoDialogu.Text = string.Empty;
            Thread t = new Thread(new ThreadStart(this.Animacjatekstu));
            t.Start();
        }

      

        private void game_start()
        {
            string SoundFile = System.IO.Path.GetFullPath(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\..\Sounds\nuke incoming.wav"));
            SoundPlayer splayer = new SoundPlayer(SoundFile);           

            if ((string)OknoWyboru.Items[0] == "Start Game")
            {
                tableindex = 0;
                //wyswietltekst();
                OknoDialogu.Text = OknoWyboru.SelectedIndex.ToString();
                POV.Image = Properties.Resources.nuke;
                OknoWyboru.SelectedItem = null;
                ListaWyboru.RemoveAt(0);
                ListaWyboru.Insert(0, "Restart");
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
            OknoDialogu.Text = OknoWyboru.SelectedIndex.ToString();
            switch (OknoWyboru.SelectedIndex)
            {
                case 0:
                    game_start();
                    break;
                case 2:
                    this.Close();
                    break;
                case 3:
                    OknoDialogu.Text = null;
                    OknoWyboru.SelectedItem = null;
                    tableindex += 1;
                    wyswietltekst();
                    break;

            }
        }

        private void POV_Click(object sender, EventArgs e)
        {

        }

        private void OknoDialogu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
