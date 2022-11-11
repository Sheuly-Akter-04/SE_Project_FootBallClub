namespace FootBallClub
{
    partial class ViewPlayer
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
            this.dataGridViewPlayerView = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.roundButton1 = new FootBallClub.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayerView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlayerView
            // 
            this.dataGridViewPlayerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayerView.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewPlayerView.Name = "dataGridViewPlayerView";
            this.dataGridViewPlayerView.Size = new System.Drawing.Size(542, 368);
            this.dataGridViewPlayerView.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(472, 435);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.Location = new System.Drawing.Point(21, 3);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(59, 51);
            this.roundButton1.TabIndex = 2;
            this.roundButton1.Text = "<";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.RoundButton1_Click);
            // 
            // ViewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 470);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewPlayerView);
            this.Name = "ViewPlayer";
            this.Text = "ViewPlayer";
            this.Load += new System.EventHandler(this.ViewPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayerView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlayerView;
        private System.Windows.Forms.Button btnRefresh;
        private RoundButton roundButton1;
    }
}