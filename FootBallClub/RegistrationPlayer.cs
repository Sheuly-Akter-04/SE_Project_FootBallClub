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
using System.Text.RegularExpressions;

namespace FootBallClub
{
    public partial class RegistrationPlayer : Form
    {
        DBAccess objDb = new DBAccess();
        public RegistrationPlayer()
        {
            InitializeComponent();
        }

        private void BtnCloseDemo_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void RegistrationPlayer_Load(object sender, EventArgs e)
        {
            panelRegistrationTransparent.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void RoundButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaterialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void BtnClearPlayerRegistrationForm_Click(object sender, EventArgs e)
        {
            txtNamePlayerRegistrationForm.Text = "";
            txtBirthdayPlayerRegistrationForm.Text = "";
            rdBtnMalePlayerRegistrationForm.Checked = false;
            rdBtnFemalePlayerRegistrationForm.Checked = false;
            txtEmailPlayerRegistrationForm.Text = "";
            txtPhonePlayerRegistrationForm.Text = "";
            txtHeightPlayerRegistrationForm.Text = "";
            txtWeightPlayerRegistrationForm.Text = "";
            comboBoxNationalityPlayerRegistrationForm.Text = "";
            txtPasswordPlayerRegistrationForm.Text = "";
                
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            string playerName = txtNamePlayerRegistrationForm.Text;

            string playerBirthday = txtBirthdayPlayerRegistrationForm.Text;
            string playerGender = "";
            if(rdBtnMalePlayerRegistrationForm.Checked)
            {
                playerGender = "Male";
            }
            else
            {
                playerGender = "Female";
            }
            // rdBtnMalePlayerRegistrationForm.Checked;
            //rdBtnFemalePlayerRegistrationForm.Checked = false;
            string playerEmail = txtEmailPlayerRegistrationForm.Text;
            string playerPhone = txtPhonePlayerRegistrationForm.Text;
            string playerHeight = txtHeightPlayerRegistrationForm.Text;
            string playerWeight = txtWeightPlayerRegistrationForm.Text;
            string playerNation = comboBoxNationalityPlayerRegistrationForm.Text;
            string playerPassword = txtPasswordPlayerRegistrationForm.Text;

            if(playerName.Equals(""))
            {
                MessageBox.Show("Please Enter Name");
            }
            else if(playerBirthday.Equals(""))
            {
                MessageBox.Show("Please Enter Birthday");
            }
            else if(playerGender.Equals(""))
            {
                MessageBox.Show("Please Enter Gender");
            }
            else if(playerEmail.Equals(""))
            {
                MessageBox.Show("Please Enter Email");
            }
            else if(playerPhone.Equals(""))
            {
                MessageBox.Show("Please Enter Phone Number");
            }
            else if(playerHeight.Equals(""))
            {
                MessageBox.Show("Please Enter Height");
            }
            else if(playerWeight.Equals(""))
            {
                MessageBox.Show("Please Enter Weight");
            }
            else if(playerNation.Equals(""))
            {
                MessageBox.Show("Please Enter Nationality");
            }
            else if(playerPassword.Equals(""))
            {
                MessageBox.Show("Please Enter Password");
            }
            else
            {
                //MessageBox.Show("All ok");
                SqlCommand insertCommand = new SqlCommand("insert into PlayerInfo (Name,Birthday,Gender,Email,phone,Height,Weight,Nationality,Password) values" +
                    " (@name,@bdate,@gen,@email,@phone,@height,@weight,@nation,@password)");
                insertCommand.Parameters.AddWithValue("@name", playerName);
                insertCommand.Parameters.AddWithValue("@bdate", playerBirthday);
                insertCommand.Parameters.AddWithValue("@gen", playerGender);
                insertCommand.Parameters.AddWithValue("@email", playerEmail);
                insertCommand.Parameters.AddWithValue("@phone", playerPhone);
                insertCommand.Parameters.AddWithValue("@height", playerHeight);
                insertCommand.Parameters.AddWithValue("@weight", playerWeight);
                insertCommand.Parameters.AddWithValue("@nation", playerNation);
                insertCommand.Parameters.AddWithValue("@password", playerPassword);


                int row = objDb.executeQuery(insertCommand);
                if(row==1)
                {
                    MessageBox.Show("Congratulations");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }




        }
        ErrorProvider errorProvider1 = new ErrorProvider();
        private void txtEmail_leave(object sender, EventArgs e)
        {
            string patternEmail = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmailPlayerRegistrationForm.Text, patternEmail))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtEmailPlayerRegistrationForm, "please provide valid email address");
                return;
            }
        }
    }
}
