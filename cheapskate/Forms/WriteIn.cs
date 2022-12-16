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
    public partial class WriteIn : Form
    {
        private int SelectedRowIndex; //수정하거나 삭제하기위한 행의 인덱스를 저장
        OracleDataAdapter DBAdapter; // Data Provider인 Data Adapter 이다.
        DataSet DS; //Data Set 객체이다.
        OracleCommandBuilder myCommandBuilder; //추가, 수정, 삭제시 필요한 명령문을 자동으로 작성해주는 객체
        DataTable MemberTable;//데이터 테이블 객체이다.
        DataTable OutcomeTable;
        DataTable IncomeTable;
        DataTable BankTable;
        private int SelectedKeyValue; // 수정, 삭제할때 필요한 레코드의키 값을 보관할필드
        private OracleConnection odpConn = new OracleConnection();
        public WriteIn()
        {
            InitializeComponent();
            showDataGridView();
        }
        private void ClearTextBoxes()
        {
            txtDate.Clear();
            txtIn.Clear();
            txtTag.Clear();
        }
        private void showDataGridView() //사용자 정의 함수
        {
            try
            {
                odpConn.ConnectionString = "User Id = jy2;Password = 1234; Data Source = (DESCRIPTION = (ADDRESS =(PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)));";
                odpConn.Open();

                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new
                OracleCommand("SELECT income_id, amount, text, datein from income", odpConn);

                DataTable dt = new DataTable();
                oda.Fill(dt);
                odpConn.Close();

                DBGrid.DataSource = dt;
                DBGrid.AutoResizeColumns();
                DBGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DBGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DBGrid.AllowUserToAddRows = false;

                DBGrid.Columns[0].HeaderText = "ID";
                DBGrid.Columns[1].HeaderText = "수입금액";
                DBGrid.Columns[2].HeaderText = "태그";
                DBGrid.Columns[3].HeaderText = "날짜";
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.ToString());
                odpConn.Close();
            }
        }

        private void DBGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DBGrid.DefaultCellStyle.BackColor = Color.FromArgb(39, 39, 58);
            DBGrid.DefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
            DBGrid.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            DBGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DBGrid.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            DBGrid.EnableHeadersVisualStyles = false;

            DBGrid.DefaultCellStyle.ForeColor = Color.White;
            DBGrid.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        }

        private void DBGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DBGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            string rowNumber = (e.RowIndex + 1).ToString();

            StringFormat stringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle drawRectangle = new Rectangle
            (
                e.RowBounds.Left,
                e.RowBounds.Top,
                dataGridView.RowHeadersWidth,
                e.RowBounds.Height
            );

            SolidBrush drawBrush = new SolidBrush(Color.White);
            e.Graphics.DrawString(rowNumber, this.Font, drawBrush, drawRectangle, stringFormat);
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                OracleDataAdapter odp = new OracleDataAdapter();
                int amount = Convert.ToInt32(txtIn.Text);
                String Tag = txtTag.Text;
                String Date = txtDate.Text;

                string insertSql = "insert into income values ( SEQ_INCOME.nextval," + "1" + "," + amount + "," + "'" + Tag + "'" + "," + "'" + Date + "'" + ")";
                odp.SelectCommand = new OracleCommand(insertSql, odpConn);
                DataSet DS = new DataSet();
                odp.Fill(DS);

                string updateSql = "update bank set b_amount=b_amount+" + amount + " where bank.bank_id=1";
                odp.SelectCommand = new OracleCommand(updateSql, odpConn);
                DataSet DS2 = new DataSet();
                odp.Fill(DS2);

                ClearTextBoxes();
                showDataGridView();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OracleDataAdapter odp = new OracleDataAdapter();
                int amount = Convert.ToInt32(txtIn.Text);
                String Date = txtDate.Text;
                String Tag = txtTag.Text;

                int row = Convert.ToInt32(DBGrid.SelectedCells[0].Value);
                string updateSql = "update income set amount=" + amount + "," + "text=" + "'" + Tag + "'" + "," + "datein=" + "'" + Date + "'" + " where income_id=" + row;
                odp.SelectCommand = new OracleCommand(updateSql, odpConn);
                DataSet DS = new DataSet();
                odp.Fill(DS);

                ClearTextBoxes();
                showDataGridView();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(DBGrid.SelectedCells[0].Value);
            OracleDataAdapter odp = new OracleDataAdapter();
            string deleteSql = "delete from income where income_id=" + row;
            odp.SelectCommand = new OracleCommand(deleteSql, odpConn);
            DataSet DS = new DataSet();
            odp.Fill(DS);
            showDataGridView();
        }
    }
}
