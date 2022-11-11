using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace FootBallClub
{
    public partial class ViewPlayer : Form
    {
        DBAccess obj = new DBAccess();
        DataTable dTable = new DataTable();

        

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

      

        public ViewPlayer()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            this.dataGridViewPlayerView.DataSource = null;

            this.dTable.Rows.Clear();
            this.dataGridViewPlayerView.DataSource = dTable;

            string qur = "select * from PlayerInfo";
            obj.readDatathroughAdapter(qur, dTable);


            obj.closeConn();
        }

        private void RoundButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewPlayer_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
