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
    public partial class changeOrUpdateCoachInfo : Form
    {
        DBAccess obj = new DBAccess();
        DataTable dTable = new DataTable();
        int id;


        public changeOrUpdateCoachInfo()
        {
            InitializeComponent();
        }

        private void MaterialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void ChangeOrUpdateCoachInfo_Load(object sender, EventArgs e)
        {
            loadData();
        }


        public void loadData()
        {
            dataGridViewchangeOrUpdateCoachInfo.DataSource = null;

            this.dTable.Rows.Clear();
            dataGridViewchangeOrUpdateCoachInfo.DataSource = dTable;

            string qur = "select * from PlayerInfo";
            obj.readDatathroughAdapter(qur, dTable);


            obj.closeConn();
        }

        private void DataGridViewchangeOrUpdateCoachInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewchangeOrUpdateCoachInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewchangeOrUpdateCoachInfo.MultiSelect = false;
            DataGridViewRow row = this.dataGridViewchangeOrUpdateCoachInfo.Rows[e.RowIndex];

            if (e.RowIndex >= 0)
            {
                // DataGridViewRow row = this.dataGridViewChangeOrUpdatePlayer.Rows[e.RowIndex];
                txtNamechangeOrUpdateCoachInfo.Text = row.Cells["Name"].Value.ToString();
                txtBirthdaychangeOrUpdateCoachInfo.Text = row.Cells["Birthday"].Value.ToString();
                string gerder = row.Cells["Gender"].Value.ToString();
                if (gerder == "Male")
                {
                    rbBtnMalechangeOrUpdateCoachInfo.Checked = true;
                }
                else
                {
                    rbBtnFemalechangeOrUpdateCoachInfo.Checked = true;
                }

                txtEmailchangeOrUpdateCoachInfo.Text = row.Cells["Email"].Value.ToString();
                txtPhonechangeOrUpdateCoachInfo.Text = row.Cells["Phone"].Value.ToString();
                txtHeightchangeOrUpdateCoachInfo.Text = row.Cells["Height"].Value.ToString();
                txtWeightchangeOrUpdateCoachInfo.Text = row.Cells["Weight"].Value.ToString();
                comboBoxNationaliltychangeOrUpdateCoachInfo.Text = row.Cells["Nationality"].Value.ToString();
                txtPasswordchangeOrUpdateCoachInfo.Text = row.Cells["Password"].Value.ToString();

                string nid = row.Cells["ID"].Value.ToString();
                id = Convert.ToInt32(nid);

            }

        }

        private void BtnUpdateCoachInfo_Click(object sender, EventArgs e)
        {
            string name = txtNamechangeOrUpdateCoachInfo.Text;
            string birthday = txtBirthdaychangeOrUpdateCoachInfo.Text;
            string gender = "";
            if (rbBtnMalechangeOrUpdateCoachInfo.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }


            string email = txtEmailchangeOrUpdateCoachInfo.Text;
            string phone = txtPhonechangeOrUpdateCoachInfo.Text;
            string height = txtHeightchangeOrUpdateCoachInfo.Text;
            string weight = txtWeightchangeOrUpdateCoachInfo.Text;
            string nationality = comboBoxNationaliltychangeOrUpdateCoachInfo.Text;
            string pass = txtPasswordchangeOrUpdateCoachInfo.Text;


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
    }
}
