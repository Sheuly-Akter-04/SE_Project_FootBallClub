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
    public partial class DashBoardAdmin : Form
    {
        public DashBoardAdmin()
        {
            InitializeComponent();
            customizeDesign();
        }
        public void customizeDesign()
        {
            panelDown1SubMenu.Visible = false;
            panelStaff1Demo.Visible = false;
            panelPresidentsDemo.Visible = false;
            panelOthersDown.Visible = false;

        }
        public void hideSubManu()
        {
            if(panelDown1SubMenu.Visible == true)
            {
                panelDown1SubMenu.Visible = false;
            }
            if(panelPresidentsDemo.Visible == true)
            {
                panelPresidentsDemo.Visible = false;
            }
            if(panelStaff1Demo.Visible==true)
            {
                panelStaff1Demo.Visible = false;
            }
            if(panelOthersDown.Visible == true)
            {
                panelOthersDown.Visible = false;
            }
        }

        public void showSubManu(Panel subManu)
        {
            if(subManu.Visible == false)
            {
                hideSubManu();
                subManu.Visible = true;
            }
            else
            {
                subManu.Visible = false;
            }


        }

        private void BtnDown1_Click(object sender, EventArgs e)
        {
            showSubManu(panelDown1SubMenu);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewPlayer());


            hideSubManu();

        }

        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                panelChild1DashBoardAdmin.Controls.Add(childForm);
                panelChild1DashBoardAdmin.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
        }

        private void BtnRegistrationDemo_Click(object sender, EventArgs e)
        {
            
           // p1.Show();
            openChildForm(new RegistrationPlayer());
            hideSubManu();
        }

        private void BtnStaffDemo1_Click(object sender, EventArgs e)
        {
            showSubManu(panelStaff1Demo);
        }

        private void DashBoardAdmin_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddCourseByAdmin_Click(object sender, EventArgs e)
        {

            openChildForm(new RegistrationCoach());
            hideSubManu();
        }

        private void BtnOthersDown_Click(object sender, EventArgs e)
        {
            showSubManu(panelPresidentsDemo);
        }

        private void BtnOtherNewDown_Click(object sender, EventArgs e)
        {
            showSubManu(panelOthersDown);
        }

        private void BtnCoachUpdateOrDelete_Click(object sender, EventArgs e)
        {
            openChildForm(new changeOrUpdateCoachInfo());
            hideSubManu();
        }

        private void BtnTeamEditOrShow_Click(object sender, EventArgs e)
        {
            openChildForm(new TeamView());
            hideSubManu();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //change and update
            openChildForm(new changeOrUpdate());
            hideSubManu();



        }

        private void ButtonSeeCoach_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewCoach());
            hideSubManu();


        }
    }
}
