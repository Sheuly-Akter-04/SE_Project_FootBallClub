using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FootBallClub
{
    public partial class ViewCoach : Form
    {
        DBAccess obj = new DBAccess();
        DataTable dTable = new DataTable();


        public ViewCoach()
        {
            InitializeComponent();
        }

        private void ViewCoach_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            this.dataGridViewCoach.DataSource = null;

            this.dTable.Rows.Clear();
            this.dataGridViewCoach.DataSource = dTable;

            string qur = "select * from PlayerInfo";
            obj.readDatathroughAdapter(qur, dTable);


            obj.closeConn();
        }

        private void BtnRefreshCoach_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void RoundButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
