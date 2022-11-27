namespace cheapskate.Forms
{
    partial class Write
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteBtn1 = new System.Windows.Forms.Button();
            this.UpdateBtn1 = new System.Windows.Forms.Button();
            this.AppendBtn1 = new System.Windows.Forms.Button();
            this.txtDate1 = new System.Windows.Forms.TextBox();
            this.txtMoney1 = new System.Windows.Forms.TextBox();
            this.txtBank1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DeleteBtn2 = new System.Windows.Forms.Button();
            this.UpdateBtn2 = new System.Windows.Forms.Button();
            this.AppendBtn2 = new System.Windows.Forms.Button();
            this.textTag2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDate2 = new System.Windows.Forms.TextBox();
            this.txtMoney2 = new System.Windows.Forms.TextBox();
            this.txtBank2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DBGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.DBGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.DBGrid.Location = new System.Drawing.Point(0, 0);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.ReadOnly = true;
            this.DBGrid.RowHeadersWidth = 51;
            this.DBGrid.RowTemplate.Height = 27;
            this.DBGrid.Size = new System.Drawing.Size(1011, 300);
            this.DBGrid.TabIndex = 0;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            this.DBGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DBGrid_CellFormatting);
            this.DBGrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DBGrid_RowPostPaint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DeleteBtn1);
            this.panel1.Controls.Add(this.UpdateBtn1);
            this.panel1.Controls.Add(this.AppendBtn1);
            this.panel1.Controls.Add(this.txtDate1);
            this.panel1.Controls.Add(this.txtMoney1);
            this.panel1.Controls.Add(this.txtBank1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 272);
            this.panel1.TabIndex = 7;
            // 
            // DeleteBtn1
            // 
            this.DeleteBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.DeleteBtn1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeleteBtn1.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn1.Location = new System.Drawing.Point(350, 25);
            this.DeleteBtn1.Name = "DeleteBtn1";
            this.DeleteBtn1.Size = new System.Drawing.Size(75, 30);
            this.DeleteBtn1.TabIndex = 16;
            this.DeleteBtn1.Text = "삭제";
            this.DeleteBtn1.UseVisualStyleBackColor = false;
            // 
            // UpdateBtn1
            // 
            this.UpdateBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.UpdateBtn1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UpdateBtn1.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn1.Location = new System.Drawing.Point(260, 25);
            this.UpdateBtn1.Name = "UpdateBtn1";
            this.UpdateBtn1.Size = new System.Drawing.Size(75, 30);
            this.UpdateBtn1.TabIndex = 15;
            this.UpdateBtn1.Text = "수정";
            this.UpdateBtn1.UseVisualStyleBackColor = false;
            // 
            // AppendBtn1
            // 
            this.AppendBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.AppendBtn1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AppendBtn1.ForeColor = System.Drawing.Color.White;
            this.AppendBtn1.Location = new System.Drawing.Point(170, 25);
            this.AppendBtn1.Name = "AppendBtn1";
            this.AppendBtn1.Size = new System.Drawing.Size(75, 30);
            this.AppendBtn1.TabIndex = 14;
            this.AppendBtn1.Text = "추가";
            this.AppendBtn1.UseVisualStyleBackColor = false;
            // 
            // txtDate1
            // 
            this.txtDate1.Location = new System.Drawing.Point(130, 73);
            this.txtDate1.Multiline = true;
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(284, 38);
            this.txtDate1.TabIndex = 9;
            // 
            // txtMoney1
            // 
            this.txtMoney1.Location = new System.Drawing.Point(130, 137);
            this.txtMoney1.Multiline = true;
            this.txtMoney1.Name = "txtMoney1";
            this.txtMoney1.Size = new System.Drawing.Size(284, 38);
            this.txtMoney1.TabIndex = 10;
            // 
            // txtBank1
            // 
            this.txtBank1.Location = new System.Drawing.Point(130, 203);
            this.txtBank1.Multiline = true;
            this.txtBank1.Name = "txtBank1";
            this.txtBank1.Size = new System.Drawing.Size(284, 38);
            this.txtBank1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "은행";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "금액";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "날짜";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(19, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 62);
            this.panel2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(39, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 38);
            this.label7.TabIndex = 7;
            this.label7.Text = "수입";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DeleteBtn2);
            this.panel3.Controls.Add(this.UpdateBtn2);
            this.panel3.Controls.Add(this.AppendBtn2);
            this.panel3.Controls.Add(this.textTag2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtDate2);
            this.panel3.Controls.Add(this.txtMoney2);
            this.panel3.Controls.Add(this.txtBank2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(531, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 272);
            this.panel3.TabIndex = 8;
            // 
            // DeleteBtn2
            // 
            this.DeleteBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.DeleteBtn2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeleteBtn2.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn2.Location = new System.Drawing.Point(350, 25);
            this.DeleteBtn2.Name = "DeleteBtn2";
            this.DeleteBtn2.Size = new System.Drawing.Size(75, 30);
            this.DeleteBtn2.TabIndex = 19;
            this.DeleteBtn2.Text = "삭제";
            this.DeleteBtn2.UseVisualStyleBackColor = false;
            // 
            // UpdateBtn2
            // 
            this.UpdateBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.UpdateBtn2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UpdateBtn2.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn2.Location = new System.Drawing.Point(260, 25);
            this.UpdateBtn2.Name = "UpdateBtn2";
            this.UpdateBtn2.Size = new System.Drawing.Size(75, 30);
            this.UpdateBtn2.TabIndex = 18;
            this.UpdateBtn2.Text = "수정";
            this.UpdateBtn2.UseVisualStyleBackColor = false;
            // 
            // AppendBtn2
            // 
            this.AppendBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.AppendBtn2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AppendBtn2.ForeColor = System.Drawing.Color.White;
            this.AppendBtn2.Location = new System.Drawing.Point(170, 25);
            this.AppendBtn2.Name = "AppendBtn2";
            this.AppendBtn2.Size = new System.Drawing.Size(75, 30);
            this.AppendBtn2.TabIndex = 17;
            this.AppendBtn2.Text = "추가";
            this.AppendBtn2.UseVisualStyleBackColor = false;
            this.AppendBtn2.Click += new System.EventHandler(this.AppendBtn2_Click);
            // 
            // textTag2
            // 
            this.textTag2.Location = new System.Drawing.Point(140, 220);
            this.textTag2.Multiline = true;
            this.textTag2.Name = "textTag2";
            this.textTag2.Size = new System.Drawing.Size(271, 28);
            this.textTag2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(47, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 28);
            this.label9.TabIndex = 12;
            this.label9.Text = "태그";
            // 
            // txtDate2
            // 
            this.txtDate2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDate2.Location = new System.Drawing.Point(140, 70);
            this.txtDate2.Multiline = true;
            this.txtDate2.Name = "txtDate2";
            this.txtDate2.Size = new System.Drawing.Size(271, 28);
            this.txtDate2.TabIndex = 9;
            // 
            // txtMoney2
            // 
            this.txtMoney2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoney2.Location = new System.Drawing.Point(140, 120);
            this.txtMoney2.Multiline = true;
            this.txtMoney2.Name = "txtMoney2";
            this.txtMoney2.Size = new System.Drawing.Size(271, 28);
            this.txtMoney2.TabIndex = 10;
            // 
            // txtBank2
            // 
            this.txtBank2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBank2.Location = new System.Drawing.Point(140, 170);
            this.txtBank2.Multiline = true;
            this.txtBank2.Name = "txtBank2";
            this.txtBank2.Size = new System.Drawing.Size(271, 28);
            this.txtBank2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "은행";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(161, 62);
            this.panel4.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(44, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 38);
            this.label8.TabIndex = 10;
            this.label8.Text = "지출";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "금액";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "날짜";
            // 
            // Write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1011, 590);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DBGrid);
            this.Name = "Write";
            this.Text = "Write";
            this.Load += new System.EventHandler(this.Write_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDate1;
        private System.Windows.Forms.TextBox txtMoney1;
        private System.Windows.Forms.TextBox txtBank1;
        private System.Windows.Forms.TextBox txtDate2;
        private System.Windows.Forms.TextBox txtMoney2;
        private System.Windows.Forms.TextBox txtBank2;
        private System.Windows.Forms.TextBox textTag2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeleteBtn1;
        private System.Windows.Forms.Button UpdateBtn1;
        private System.Windows.Forms.Button AppendBtn1;
        private System.Windows.Forms.Button DeleteBtn2;
        private System.Windows.Forms.Button UpdateBtn2;
        private System.Windows.Forms.Button AppendBtn2;
    }
}