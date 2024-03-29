﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheapskate
{
    public partial class Main : Form
    {
        //필드
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Construct
        public Main()
        {
            InitializeComponent();
            random = new Random();
            timer.Start();
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex==index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender!=null)
            {
                if(currentButton!=(Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    btnLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Info(), sender);
            //ActivateButton(sender);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.WriteOut(), sender);
            //ActivateButton(sender);
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Graph(), sender);
            //ActivateButton(sender);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Time.Text = DateTime.Now.ToString("HH:mm:ss");
            this.Date.Text = DateTime.Now.ToString("yyyy MM dd dddd");
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Home(), sender);
        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Memo(), sender);
            //ActivateButton(sender);
        }

        private void btnInWrite_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.WriteIn(), sender);
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
