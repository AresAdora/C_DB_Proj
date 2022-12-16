using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace cheapskate.Forms
{
    public partial class EventForm : Form
    {
        private OracleConnection odpConn = new OracleConnection();
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txtDate.Text = Memo.static_year + "/" + Memo.static_month + "/" + UserControlDays.static_day;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                odpConn.ConnectionString= "User Id=jy2; Password=1234; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =xe)));";
                odpConn.Open();

                OracleDataAdapter odp = new OracleDataAdapter();
                String Date = txtDate.Text;
                String Event = txtEvent.Text;

                string insertSql = "insert into memo values ( SEQ_MEMO.nextval," + "'" + "ddd" + "'" + "," + "'" + Event + "'" + "," + "'" + Date + "'" + ")";
                odp.SelectCommand = new OracleCommand(insertSql, odpConn);
                DataSet DS = new DataSet();
                odp.Fill(DS);

                MessageBox.Show("Saved!");
                odpConn.Close();

                EventForm eventform = new EventForm();
                eventform.Dispose();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public string DateResult()
        {
            string date = txtDate.Text;
            return date;
        }
    }
}
