using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vragendingchallenge12
{
    public partial class vragen : Form
    {
        public vragen()
        {
            InitializeComponent();
            this.totalPoints.Text = Totalepuntjes.GetTotal().ToString();
        }

        private void vraag1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:/Users/bram/source/repos/vragendingchallenge12/vragendingchallenge12/sounds/YT2mp3.info_-Anime-Shine-Sound-Effect-ProSounds-_320kbps_-AudioTrimmer.com.wav");
            player.Play();
            Totalepuntjes.AddPoints(1, 1);
            Form to = new vraag_2();
            to.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:/Users/bram/source/repos/vragendingchallenge12/vragendingchallenge12/sounds/YT2mp3.info_-Awkward-Moment-Anime-Sound-Sound-Effect-for-editing-_320kbps_-AudioTrimmer.com.wav");
            player.Play();
            Form to = new vraag_2();
            to.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:/Users/bram/source/repos/vragendingchallenge12/vragendingchallenge12/sounds/YT2mp3.info_-Awkward-Moment-Anime-Sound-Sound-Effect-for-editing-_320kbps_-AudioTrimmer.com.wav");
            player.Play();
            Form to = new vraag_2();
            to.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:/Users/bram/source/repos/vragendingchallenge12/vragendingchallenge12/sounds/YT2mp3.info_-Awkward-Moment-Anime-Sound-Sound-Effect-for-editing-_320kbps_-AudioTrimmer.com.wav");
            player.Play();
            Form to = new vraag_2();
            to.Show();
            Hide();
        }

        private void totalPoints_Click(object sender, EventArgs e)
        {

        }
    }
}
