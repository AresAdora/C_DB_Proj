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
    public partial class Info : Form
    {
        OracleConnection odpConn = new OracleConnection();
        public Info()
        {
            InitializeComponent();
        }

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
            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void Info_Load(object sender, EventArgs e)
        {
            LoadTheme();
            showDataGridView();
        }

        private void showDataGridView()
        {
            odpConn.ConnectionString = "User Id=jy2; Password=1234; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =xe)));";
            odpConn.Open();
            OracleDataAdapter oda = new OracleDataAdapter();

            oda.SelectCommand = new OracleCommand("select b_amount from bank where bank_id=1", odpConn);
            DataTable IncomeTable = new DataTable();
            oda.Fill(IncomeTable);
            DBGrid1.DataSource = IncomeTable;
            DBGrid1.AutoResizeColumns();
            DBGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DBGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DBGrid1.AllowUserToAddRows = false;

            oda.SelectCommand = new OracleCommand("select text from outcome where bank_id=1 and rownum<=3 group by text order by text desc", odpConn);
            DataTable OutcomeManyTable = new DataTable();
            oda.Fill(OutcomeManyTable);
            DBGrid2.DataSource = OutcomeManyTable;
            DBGrid2.AutoResizeColumns();
            DBGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DBGrid2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DBGrid2.AllowUserToAddRows = false;

            odpConn.Close();
        }
    }
}
