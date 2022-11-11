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
    public partial class DashboardCoach : Form
    {
        public DashboardCoach()
        {
            InitializeComponent();
            customizeDesign();
        }

        public void customizeDesign()
        {
            panelPlayerDropDown1.Visible = false;
            //panelStaff1Demo.Visible = false;
        }

        public void hideSubManu()
        {
            if (panelPlayerDropDown1.Visible == true)
            {
                panelPlayerDropDown1.Visible = false;
            }
        }

        public void showSubManu(Panel subManu)
        {
            if (subManu.Visible == false)
            {
                hideSubManu();
                subManu.Visible = true;
            }
            else
            {
                subManu.Visible = false;
            }
        }


        private void DashboardCoach_Load(object sender, EventArgs e)
        {

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

            panelChildCoachAllViewPanel.Controls.Add(childForm);
            panelChildCoachAllViewPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void BtnViewTeam_Click(object sender, EventArgs e)
        {
            openChildForm(new TeamView());
        }

        private void BtnDropDownPlayerIUD_Click(object sender, EventArgs e)
        {
            showSubManu(panelPlayerDropDown1);

            openChildForm(new ViewPlayer());


           // hideSubManu();

        }

        private void BtnInsertPlayerByCoach_Click(object sender, EventArgs e)
        {
            openChildForm(new RegistrationPlayer());


            hideSubManu();
        }

        private void BtnUpdateDeletePlayerByCoach_Click(object sender, EventArgs e)
        {
            openChildForm(new changeOrUpdate());


            hideSubManu();
        }
    }
}
