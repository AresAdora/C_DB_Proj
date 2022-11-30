namespace cheapskate
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnGoal = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnInWrite = new System.Windows.Forms.Button();
            this.btnOutWrite = new System.Windows.Forms.Button();
            this.btnSpending = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnGoal);
            this.panelMenu.Controls.Add(this.btnGraph);
            this.panelMenu.Controls.Add(this.btnInWrite);
            this.panelMenu.Controls.Add(this.btnOutWrite);
            this.panelMenu.Controls.Add(this.btnSpending);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 703);
            this.panelMenu.TabIndex = 0;
            // 
            // btnGoal
            // 
            this.btnGoal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGoal.FlatAppearance.BorderSize = 0;
            this.btnGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoal.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGoal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGoal.Location = new System.Drawing.Point(0, 340);
            this.btnGoal.Name = "btnGoal";
            this.btnGoal.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGoal.Size = new System.Drawing.Size(198, 60);
            this.btnGoal.TabIndex = 6;
            this.btnGoal.Text = "목표";
            this.btnGoal.UseVisualStyleBackColor = true;
            this.btnGoal.Click += new System.EventHandler(this.btnGoal_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGraph.FlatAppearance.BorderSize = 0;
            this.btnGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraph.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGraph.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGraph.Location = new System.Drawing.Point(0, 280);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGraph.Size = new System.Drawing.Size(198, 60);
            this.btnGraph.TabIndex = 5;
            this.btnGraph.Text = "그래프";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnInWrite
            // 
            this.btnInWrite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInWrite.FlatAppearance.BorderSize = 0;
            this.btnInWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInWrite.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInWrite.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInWrite.Location = new System.Drawing.Point(0, 220);
            this.btnInWrite.Name = "btnInWrite";
            this.btnInWrite.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInWrite.Size = new System.Drawing.Size(198, 60);
            this.btnInWrite.TabIndex = 4;
            this.btnInWrite.Text = "수입작성";
            this.btnInWrite.UseVisualStyleBackColor = true;
            this.btnInWrite.Click += new System.EventHandler(this.btnInWrite_Click);
            // 
            // btnOutWrite
            // 
            this.btnOutWrite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOutWrite.FlatAppearance.BorderSize = 0;
            this.btnOutWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutWrite.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOutWrite.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOutWrite.Location = new System.Drawing.Point(0, 160);
            this.btnOutWrite.Name = "btnOutWrite";
            this.btnOutWrite.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnOutWrite.Size = new System.Drawing.Size(198, 60);
            this.btnOutWrite.TabIndex = 3;
            this.btnOutWrite.Text = "지출작성";
            this.btnOutWrite.UseVisualStyleBackColor = true;
            this.btnOutWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnSpending
            // 
            this.btnSpending.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpending.FlatAppearance.BorderSize = 0;
            this.btnSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpending.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSpending.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSpending.Location = new System.Drawing.Point(0, 100);
            this.btnSpending.Name = "btnSpending";
            this.btnSpending.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSpending.Size = new System.Drawing.Size(198, 60);
            this.btnSpending.TabIndex = 0;
            this.btnSpending.Text = "마이페이지";
            this.btnSpending.UseVisualStyleBackColor = true;
            this.btnSpending.Click += new System.EventHandler(this.btnSpending_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.btnLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(198, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // btnLogo
            // 
            this.btnLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogo.ForeColor = System.Drawing.Color.White;
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(198, 100);
            this.btnLogo.TabIndex = 0;
            this.btnLogo.Text = "CheapSkate";
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1032, 100);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(434, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 40);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesktop.Controls.Add(this.Date);
            this.panelDesktop.Controls.Add(this.Time);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1032, 603);
            this.panelDesktop.TabIndex = 2;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Date.Location = new System.Drawing.Point(158, 292);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(223, 106);
            this.Date.TabIndex = 1;
            this.Date.Text = "Date";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Time.Location = new System.Drawing.Point(338, 134);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(232, 106);
            this.Time.TabIndex = 0;
            this.Time.Text = "Time";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Main";
            this.Text = "Main";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSpending;
        private System.Windows.Forms.Button btnInWrite;
        private System.Windows.Forms.Button btnOutWrite;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnGoal;
    }
}