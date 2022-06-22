using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vragendingchallenge12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:/Users/bram/source/repos/vragendingchallenge12/vragendingchallenge12/sounds/YT2mp3.info_-Anime-Shine-Sound-Effect-ProSounds-_320kbps_-AudioTrimmer.com.wav");
            player.Play();
            Form to = new vragen();
            to.Show();
            Hide();
        }
    }
}
