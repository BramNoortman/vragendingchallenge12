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
    public partial class Resultaat : Form
    {
        public Resultaat()
        {
            InitializeComponent();
            this.totalPoints.Text = Totalepuntjes.GetTotal().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Resultaat_Load(object sender, EventArgs e)
        {

        }
    }
}
