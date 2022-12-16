using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace cheapskate.Forms
{
    public partial class UserControlDays : UserControl
    {
        OracleConnection odpConn = new OracleConnection();
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbdays.Text = numday+"";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            timer1.Start();
            EventForm eventform = new EventForm();
            eventform.Show();
        }

        private void displayEvent()
        {
            odpConn.ConnectionString = "User Id=jy2; Password=1234; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =xe)));";
            odpConn.Open();

            String sql = "select memo, datein from memo where user_id='ddd'";
            OracleCommand cmd = odpConn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("datein", Memo.static_year + "-" + Memo.static_month + "-" + lbdays.Text);

            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lbevent.Text = reader["memo"].ToString();
                reader.NextResult();
            }
            reader.Dispose();
            cmd.Dispose();
            odpConn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
