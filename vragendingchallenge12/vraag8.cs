using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vragendingchallenge12
{
    public partial class vraag8 : Form
    {
        public vraag8()
        {
            InitializeComponent();
            this.totalPoints.Text = Totalepuntjes.GetTotal().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form to = new vraag9();
            to.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form to = new vraag9();
            to.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Totalepuntjes.AddPoints(1, 1);
            Form to = new vraag9();
            to.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form to = new vraag9();
            to.Show();
            Hide();
        }
    }
}
