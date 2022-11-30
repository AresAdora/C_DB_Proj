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
        private void showDataGridView() //사용자 정의 함수
        {
            try
            {
                odpConn.ConnectionString = "User Id = jy;Password = 1206; Data Source = (DESCRIPTION = (ADDRESS =(PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)));";
                odpConn.Open();

                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new
                OracleCommand("SELECT income.in_amount, income.in_date, bank.b_name, bank.b_amount from income, bank", odpConn);

                DataTable dt = new DataTable();
                oda.Fill(dt);
                odpConn.Close();

                DBGrid.DataSource = dt;
                DBGrid.AutoResizeColumns();
                DBGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DBGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DBGrid.AllowUserToAddRows = false;
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
            try
            {
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS);
                OutcomeTable = DS.Tables["outcome"]; //지출 테이블
                IncomeTable = DS.Tables["income"]; //수입 테이블
                BankTable = DS.Tables["bank"]; //은행 테이블

                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > BankTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = BankTable.Rows[e.RowIndex];

                /*
                txtid.Text = currRow["id"].ToString();
                txtName.Text = currRow["PName"].ToString();
                txtPhone.Text = currRow["Phone"].ToString();
                txtMail.Text = currRow["EMail"].ToString();
                SelectedRowIndex = Convert.ToInt32(currRow["id"]);
                */
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
    }
}
