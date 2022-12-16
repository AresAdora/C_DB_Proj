using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace cheapskate.Forms
{
    public partial class Memo : Form
    {
        int month, year;

        public static int static_month, static_year;
        public Memo()
        {
            InitializeComponent();
        }

        private void Memo_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = year + "년" + monthname;

            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;

            for(int i=1;i<dayoftheweek;i++)
            {
                Calendar1 calendar = new Calendar1();
                daycontainer.Controls.Add(calendar);
            }
            for(int i=1;i<=days;i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (month == 1)
            {
                year--;
                month = 13;
            }
            daycontainer.Controls.Clear();
            month--;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = year + "년" + monthname;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                Calendar1 calendar = new Calendar1();
                daycontainer.Controls.Add(calendar);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if(month==12)
            {
                year++;
                month = 0;
            }
            daycontainer.Controls.Clear();
            month++;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = year + "년" + monthname;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                Calendar1 calendar = new Calendar1();
                daycontainer.Controls.Add(calendar);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
