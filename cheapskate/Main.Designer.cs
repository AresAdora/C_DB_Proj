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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnSpending = new System.Windows.Forms.Button();
            this.btnProperty = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnGraph);
            this.panelMenu.Controls.Add(this.btnWrite);
            this.panelMenu.Controls.Add(this.btnProperty);
            this.panelMenu.Controls.Add(this.btnSpending);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 566);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(198, 100);
            this.panelLogo.TabIndex = 1;
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
            this.btnSpending.Text = "지출내역";
            this.btnSpending.UseVisualStyleBackColor = true;
            this.btnSpending.Click += new System.EventHandler(this.btnSpending_Click);
            // 
            // btnProperty
            // 
            this.btnProperty.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProperty.FlatAppearance.BorderSize = 0;
            this.btnProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProperty.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProperty.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProperty.Location = new System.Drawing.Point(0, 160);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProperty.Size = new System.Drawing.Size(198, 60);
            this.btnProperty.TabIndex = 2;
            this.btnProperty.Text = "자산내역";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWrite.FlatAppearance.BorderSize = 0;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrite.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWrite.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWrite.Location = new System.Drawing.Point(0, 220);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnWrite.Size = new System.Drawing.Size(198, 60);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "작성";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
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
            this.btnGraph.TabIndex = 4;
            this.btnGraph.Text = "그래프";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(859, 100);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(347, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 40);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "HOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "CheapSkate";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(859, 466);
            this.panelDesktop.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 566);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Main";
            this.Text = "Main";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSpending;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDesktop;
    }
}