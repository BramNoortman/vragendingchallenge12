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
        }

        private void vraag1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form to = new vraag_2();
            to.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form to = new vraag_2();
            to.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form to = new vraag_2();
            to.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form to = new vraag_2();
            to.Show();
            Hide();
        }
    }
}
