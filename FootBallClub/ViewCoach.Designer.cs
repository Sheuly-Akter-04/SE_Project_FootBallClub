namespace FootBallClub
{
    partial class ViewCoach
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
            this.dataGridViewCoach = new System.Windows.Forms.DataGridView();
            this.btnRefreshCoach = new System.Windows.Forms.Button();
            this.roundButton1 = new FootBallClub.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoach)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCoach
            // 
            this.dataGridViewCoach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoach.Location = new System.Drawing.Point(12, 82);
            this.dataGridViewCoach.Name = "dataGridViewCoach";
            this.dataGridViewCoach.Size = new System.Drawing.Size(531, 332);
            this.dataGridViewCoach.TabIndex = 0;
            // 
            // btnRefreshCoach
            // 
            this.btnRefreshCoach.Location = new System.Drawing.Point(390, 435);
            this.btnRefreshCoach.Name = "btnRefreshCoach";
            this.btnRefreshCoach.Size = new System.Drawing.Size(131, 23);
            this.btnRefreshCoach.TabIndex = 1;
            this.btnRefreshCoach.Text = "Refesh";
            this.btnRefreshCoach.UseVisualStyleBackColor = true;
            this.btnRefreshCoach.Click += new System.EventHandler(this.BtnRefreshCoach_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Location = new System.Drawing.Point(12, 12);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(75, 48);
            this.roundButton1.TabIndex = 2;
            this.roundButton1.Text = "<";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.RoundButton1_Click);
            // 
            // ViewCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 470);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.btnRefreshCoach);
            this.Controls.Add(this.dataGridViewCoach);
            this.Name = "ViewCoach";
            this.Text = "ViewCoach";
            this.Load += new System.EventHandler(this.ViewCoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCoach;
        private System.Windows.Forms.Button btnRefreshCoach;
        private RoundButton roundButton1;
    }
}