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
    public partial class changeOrUpdate : Form
    {

        DBAccess obj = new DBAccess();
        DataTable dTable = new DataTable();
        int id;


        public changeOrUpdate()
        {
            InitializeComponent();
        }

        private void ChangeOrUpdate_Load(object sender, EventArgs e)
        {
            loadData();
        }



        public void loadData()
        {
            dataGridViewChangeOrUpdatePlayer.DataSource = null;

            this.dTable.Rows.Clear();
            dataGridViewChangeOrUpdatePlayer.DataSource = dTable;

            string qur = "select * from PlayerInfo";
            obj.readDatathroughAdapter(qur, dTable);


            obj.closeConn();
        }

        private void BtnUpdatePlayerChangeOrUpdate_Click(object sender, EventArgs e)
        {
            string name = txtNamePlayerChangeOrUpdate.Text;
            string birthday = txtBirthdayPlayerChangeOrUpdate.Text;
            string gender = "";
            if (rbBtnMalePlayerChangeOrUpdate.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }


            string email = txtEmailPlayerChangeOrUpdate.Text;
            string phone = txtPhonePlayerChangeOrUpdate.Text;
            string height = txtHeightPlayerChangeOrUpdate.Text;
            string weight = txtWeightPlayerChangeOrUpdate.Text;
            string nationality = txtNationalitylayerChangeOrUpdate.Text;
            string pass = txtPasswordlayerChangeOrUpdate.Text;


            string query = "Update PlayerInfo SET Name = '" + name + "', Birthday = '" + birthday + "', Gender = '" + gender + "', Email = '" + email
                + "', phone = '" + phone + "', Height = '" + height + "', Weight = '" + weight + "', Nationality = '" + nationality + "', Password = '" + pass + "' Where ID = '" + id + "'";

            SqlCommand updateCommand = new SqlCommand(query);

            int row = obj.executeQuery(updateCommand);
            if (row == 1)
            {
                MessageBox.Show("Congratulations");
            }
            else
            {
                MessageBox.Show("Failed");
            }




        }

        private void DataGridViewChangeOrUpdatePlayer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewChangeOrUpdatePlayer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewChangeOrUpdatePlayer.MultiSelect = false;
            DataGridViewRow row = this.dataGridViewChangeOrUpdatePlayer.Rows[e.RowIndex];



            if (e.RowIndex >= 0)
            {
                // DataGridViewRow row = this.dataGridViewChangeOrUpdatePlayer.Rows[e.RowIndex];
                txtNamePlayerChangeOrUpdate.Text = row.Cells["Name"].Value.ToString();
                txtBirthdayPlayerChangeOrUpdate.Text = row.Cells["Birthday"].Value.ToString();
                string gerder = row.Cells["Gender"].Value.ToString();
                if(gerder=="Male")
                {
                    rbBtnMalePlayerChangeOrUpdate.Checked = true;
                }
                else
                {
                    rbBtnFemalePlayerChangeOrUpdate.Checked = true;
                }
                
                txtEmailPlayerChangeOrUpdate.Text = row.Cells["Email"].Value.ToString();
                txtPhonePlayerChangeOrUpdate.Text = row.Cells["Phone"].Value.ToString();
                txtHeightPlayerChangeOrUpdate.Text = row.Cells["Height"].Value.ToString();
                txtWeightPlayerChangeOrUpdate.Text = row.Cells["Weight"].Value.ToString();
                txtNationalitylayerChangeOrUpdate.Text = row.Cells["Nationality"].Value.ToString();
                txtPasswordlayerChangeOrUpdate.Text = row.Cells["Password"].Value.ToString();

                string nid = row.Cells["ID"].Value.ToString();
                id = Convert.ToInt32(nid);

            }
        }

        private void TxtNationalitylayerChangeOrUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
