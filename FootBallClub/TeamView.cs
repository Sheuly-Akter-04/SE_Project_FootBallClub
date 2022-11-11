using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBallClub
{
    public partial class TeamView : Form
    {
        public TeamView()
        {
            InitializeComponent();
        }

        private void RoundButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
