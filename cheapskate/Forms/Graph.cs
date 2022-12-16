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
    public partial class Graph : Form
    {
        private OracleConnection odpConn = new OracleConnection();

        public Graph()
        {
            InitializeComponent();
        }

        /*
         private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
        }
             */

        private void Graph_Load(object sender, EventArgs e)
        {
            odpConn.ConnectionString = "User Id=jy2; Password=1234; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =xe)));";

            try
            {
                odpConn.Open();

                OracleCommand cmd = new OracleCommand("select amount, datein from outcome where bank_id=1", odpConn);

                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = cmd;

                DataSet ds = new DataSet();
                da.Fill(ds, "outcome");
                chart1.DataSource = ds.Tables["outcome"];
                chart1.Series["outcome"].XValueMember = "datein";
                chart1.Series["outcome"].YValueMembers = "amount";
                chart1.Series["outcome"].IsValueShownAsLabel = true;


                //-----------------------------------
                /*
                OracleCommand cmd2 = new OracleCommand("select amount, datein from income where bank_id=1", odpConn);

                OracleDataAdapter da2 = new OracleDataAdapter();
                da2.SelectCommand = cmd2;

                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "income");
                chart1.DataSource = ds2.Tables["income"];
                chart1.Series["income"].XValueMember = "datein";
                chart1.Series["income"].YValueMembers = "amount";
                chart1.Series["income"].IsValueShownAsLabel = true;
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                odpConn.Close();
            }
        }
    }
}
