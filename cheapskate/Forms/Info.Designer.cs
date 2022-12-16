namespace cheapskate.Forms
{
    partial class Info
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
            this.label1 = new System.Windows.Forms.Label();
            this.DBGrid1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.DBGrid2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "현재 내계좌 잔액";
            // 
            // DBGrid1
            // 
            this.DBGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid1.Location = new System.Drawing.Point(26, 55);
            this.DBGrid1.Name = "DBGrid1";
            this.DBGrid1.RowHeadersWidth = 51;
            this.DBGrid1.RowTemplate.Height = 27;
            this.DBGrid1.Size = new System.Drawing.Size(240, 90);
            this.DBGrid1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "가장 지출많았던 태그";
            // 
            // DBGrid2
            // 
            this.DBGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid2.Location = new System.Drawing.Point(26, 222);
            this.DBGrid2.Name = "DBGrid2";
            this.DBGrid2.RowHeadersWidth = 51;
            this.DBGrid2.RowTemplate.Height = 27;
            this.DBGrid2.Size = new System.Drawing.Size(240, 150);
            this.DBGrid2.TabIndex = 3;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 505);
            this.Controls.Add(this.DBGrid2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DBGrid1);
            this.Controls.Add(this.label1);
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DBGrid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DBGrid2;
    }
}