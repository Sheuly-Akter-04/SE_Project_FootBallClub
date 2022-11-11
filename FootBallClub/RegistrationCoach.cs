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
    public partial class RegistrationCoach : Form
    {
        DBAccess objCoachDB = new DBAccess();
        public RegistrationCoach()
        {
            InitializeComponent();
        }

        private void RegistrationCoach_Load(object sender, EventArgs e)
        {
            panelRegistrationCoachTransparent.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void RoundButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClearCoachRegistrationForm_Click(object sender, EventArgs e)
        {
            txtNameCoachRegistration.Text = "";
            txtBirthdayCoachRegistration.Text = "";
            rdBtnMaleCoachRegistration.Checked = false;
            rdBtnFemaleCoachRegistration.Checked = false;
            txtEmailCoachRegistration.Text = "";
            txtPhoneCoachRegistration.Text = "";
            comboBoxNationalityCoachRegistration.Text = "";
            txtHeightCoachRegistration.Text = "";
            txtWeightCoachRegistration.Text = "";
            txtPasswordCoachRegistration.Text = "";
        }

        private void BtnSIGNinCoachRegistrationForm_Click(object sender, EventArgs e)
        {
            string coachName = txtNameCoachRegistration.Text;

            string coachBirthday = txtBirthdayCoachRegistration.Text;
            string coachGender = "";
            if (rdBtnMaleCoachRegistration.Checked)
            {
                coachGender = "Male";
            }
            else
            {
                coachGender = "Female";
            }
          
            string coachEmail = txtEmailCoachRegistration.Text;
            string coachPhone = txtPhoneCoachRegistration.Text;
            string coachNation = comboBoxNationalityCoachRegistration.Text;
            string coachHeight =  txtHeightCoachRegistration.Text;
            string coachWeight =  txtWeightCoachRegistration.Text;
            string coachPassword = txtPasswordCoachRegistration.Text;

            if (coachName.Equals(""))
            {
                MessageBox.Show("Please Enter Name");
            }
            else if (coachBirthday.Equals(""))
            {
                MessageBox.Show("Please Enter Birthday");
            }
            else if (coachGender.Equals(""))
            {
                MessageBox.Show("Please Enter Gender");
            }
            else if (coachEmail.Equals(""))
            {
                MessageBox.Show("Please Enter Email");
            }
            else if (coachPhone.Equals(""))
            {
                MessageBox.Show("Please Enter Phone Number");
            }
            else if (coachHeight.Equals(""))
            {
                MessageBox.Show("Please Enter Height");
            }
            else if (coachWeight.Equals(""))
            {
                MessageBox.Show("Please Enter Weight");
            }
            else if (coachNation.Equals(""))
            {
                MessageBox.Show("Please Enter Nationality");
            }
            else if (coachPassword.Equals(""))
            {
                MessageBox.Show("Please Enter Password");
            }
            else
            {
                SqlCommand insertCommand1 = new SqlCommand("insert into CoachInfo (Name,Birthday,Gender,Email,phone,Height,Weight,Nationality,Password) values" +
                    " (@name,@bdate,@gen,@email,@phone,@height,@weight,@nation,@password)");
                insertCommand1.Parameters.AddWithValue("@name", coachName);
                insertCommand1.Parameters.AddWithValue("@bdate", coachBirthday);
                insertCommand1.Parameters.AddWithValue("@gen", coachGender);
                insertCommand1.Parameters.AddWithValue("@email", coachEmail);
                insertCommand1.Parameters.AddWithValue("@phone", coachPhone);
                insertCommand1.Parameters.AddWithValue("@height", coachHeight);
                insertCommand1.Parameters.AddWithValue("@weight", coachWeight);
                insertCommand1.Parameters.AddWithValue("@nation", coachNation);
                insertCommand1.Parameters.AddWithValue("@password", coachPassword);

                int row = objCoachDB.executeQuery(insertCommand1);
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
        ErrorProvider errorProvider1 = new ErrorProvider();
        private void txtEmail_leave(object sender, EventArgs e)
        {
            string patternEmail = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmailCoachRegistration.Text, patternEmail))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtEmailCoachRegistration, "please provide valid email address");
                return;
            }
        }
    }
}
