namespace FootBallClub
{
    partial class DashboardCoach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelChildCoachAllViewPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPlayerDropDown1 = new System.Windows.Forms.Panel();
            this.btnUpdateDeletePlayerByCoach = new System.Windows.Forms.Button();
            this.btnInsertPlayerByCoach = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnViewTeam = new System.Windows.Forms.Button();
            this.btnDropDownPlayerIUD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelPlayerDropDown1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildCoachAllViewPanel
            // 
            this.panelChildCoachAllViewPanel.BackgroundImage = global::FootBallClub.Properties.Resources.Coach_Animation;
            this.panelChildCoachAllViewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChildCoachAllViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildCoachAllViewPanel.Location = new System.Drawing.Point(208, 0);
            this.panelChildCoachAllViewPanel.Name = "panelChildCoachAllViewPanel";
            this.panelChildCoachAllViewPanel.Size = new System.Drawing.Size(582, 509);
            this.panelChildCoachAllViewPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FootBallClub.Properties.Resources.Football1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panelPlayerDropDown1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnViewTeam);
            this.panel1.Controls.Add(this.btnDropDownPlayerIUD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 509);
            this.panel1.TabIndex = 0;
            // 
            // panelPlayerDropDown1
            // 
            this.panelPlayerDropDown1.Controls.Add(this.btnUpdateDeletePlayerByCoach);
            this.panelPlayerDropDown1.Controls.Add(this.btnInsertPlayerByCoach);
            this.panelPlayerDropDown1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlayerDropDown1.Location = new System.Drawing.Point(0, 51);
            this.panelPlayerDropDown1.Name = "panelPlayerDropDown1";
            this.panelPlayerDropDown1.Size = new System.Drawing.Size(208, 112);
            this.panelPlayerDropDown1.TabIndex = 1;
            // 
            // btnUpdateDeletePlayerByCoach
            // 
            this.btnUpdateDeletePlayerByCoach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateDeletePlayerByCoach.Location = new System.Drawing.Point(0, 52);
            this.btnUpdateDeletePlayerByCoach.Name = "btnUpdateDeletePlayerByCoach";
            this.btnUpdateDeletePlayerByCoach.Size = new System.Drawing.Size(208, 53);
            this.btnUpdateDeletePlayerByCoach.TabIndex = 1;
            this.btnUpdateDeletePlayerByCoach.Text = "Update and Delete";
            this.btnUpdateDeletePlayerByCoach.UseVisualStyleBackColor = true;
            this.btnUpdateDeletePlayerByCoach.Click += new System.EventHandler(this.BtnUpdateDeletePlayerByCoach_Click);
            // 
            // btnInsertPlayerByCoach
            // 
            this.btnInsertPlayerByCoach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsertPlayerByCoach.Location = new System.Drawing.Point(0, 0);
            this.btnInsertPlayerByCoach.Name = "btnInsertPlayerByCoach";
            this.btnInsertPlayerByCoach.Size = new System.Drawing.Size(208, 52);
            this.btnInsertPlayerByCoach.TabIndex = 0;
            this.btnInsertPlayerByCoach.Text = "Insert";
            this.btnInsertPlayerByCoach.UseVisualStyleBackColor = true;
            this.btnInsertPlayerByCoach.Click += new System.EventHandler(this.BtnInsertPlayerByCoach_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 90);
            this.button4.TabIndex = 0;
            this.button4.Text = "My Info ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 90);
            this.button3.TabIndex = 0;
            this.button3.Text = "Other";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnViewTeam
            // 
            this.btnViewTeam.Location = new System.Drawing.Point(-3, 169);
            this.btnViewTeam.Name = "btnViewTeam";
            this.btnViewTeam.Size = new System.Drawing.Size(208, 90);
            this.btnViewTeam.TabIndex = 0;
            this.btnViewTeam.Text = "View Team";
            this.btnViewTeam.UseVisualStyleBackColor = true;
            this.btnViewTeam.Click += new System.EventHandler(this.BtnViewTeam_Click);
            // 
            // btnDropDownPlayerIUD
            // 
            this.btnDropDownPlayerIUD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDropDownPlayerIUD.Location = new System.Drawing.Point(0, 0);
            this.btnDropDownPlayerIUD.Name = "btnDropDownPlayerIUD";
            this.btnDropDownPlayerIUD.Size = new System.Drawing.Size(208, 51);
            this.btnDropDownPlayerIUD.TabIndex = 0;
            this.btnDropDownPlayerIUD.Text = "View Players List";
            this.btnDropDownPlayerIUD.UseVisualStyleBackColor = true;
            this.btnDropDownPlayerIUD.Click += new System.EventHandler(this.BtnDropDownPlayerIUD_Click);
            // 
            // DashboardCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 509);
            this.Controls.Add(this.panelChildCoachAllViewPanel);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardCoach";
            this.Text = "Dashboard Coach";
            this.Load += new System.EventHandler(this.DashboardCoach_Load);
            this.panel1.ResumeLayout(false);
            this.panelPlayerDropDown1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChildCoachAllViewPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnViewTeam;
        private System.Windows.Forms.Button btnDropDownPlayerIUD;
        private System.Windows.Forms.Panel panelPlayerDropDown1;
        private System.Windows.Forms.Button btnUpdateDeletePlayerByCoach;
        private System.Windows.Forms.Button btnInsertPlayerByCoach;
    }
}