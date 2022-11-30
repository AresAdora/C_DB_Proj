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
    public partial class WriteOut : Form
    {
        private OracleConnection odpConn = new OracleConnection();
        private int SelectedRowIndex; //수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다. 
        OracleDataAdapter DBAdapter; // Data Provider인 DBAdapter 입니다. 
        DataSet DS; // DataSet 객체입니다. 
        OracleCommandBuilder myCommandBuilder; // 추가, 수정, 삭제시에 필요한 명령문을 자동으로 작성해주는 객체입니다. 
        private int SelectedKeyValue; // 수정, 삭제할 때 필요한 레코드의 키값을
        OracleCommand cmd;
        public WriteOut()
        {
            InitializeComponent();
            showDataGridView();
        }

        private void ClearTextBoxes()
        {
            txtTag.Clear();
            txtDate.Clear();
            txtOut.Clear();
        }

        private void showDataGridView() //사용자 정의 함수
        {
            try
            {
                odpConn.ConnectionString = "User Id=jy2; Password=1234; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =xe)));";
                odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand("select outcome.outcome_id, outcome.amount, outcome.text, outcome.datein, bank.b_amount from outcome, bank where bank.bank_id=1", odpConn);
                //outcome_id, amount, text, datein
                //OracleCommand("SELECT out_id, out_amount, out_tag, out_date from outcome where b_id=1", odpConn);
                DataTable OutcomeTable = new DataTable();
                oda.Fill(OutcomeTable);
                odpConn.Close();
                DBGrid.DataSource = OutcomeTable;
                DBGrid.AutoResizeColumns();
                DBGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DBGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DBGrid.AllowUserToAddRows = false;

                DBGrid.Columns[0].HeaderText = "ID";
                DBGrid.Columns[1].HeaderText = "지출금액";
                DBGrid.Columns[2].HeaderText = "태그";
                DBGrid.Columns[3].HeaderText = "날짜";
                DBGrid.Columns[4].HeaderText = "현재계좌잔액";
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.ToString());
                odpConn.Close();
            }
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

        private void DBGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                OracleDataAdapter odp = new OracleDataAdapter();
                int amount = Convert.ToInt32(txtOut.Text);
                String Date = txtDate.Text;
                String Tag = txtTag.Text;

                string insertSql = "insert into outcome values ( SEQ_OUTCOME.nextval,"+"1"+","+amount+","+"'"+ Tag + "'"+","+"'"+Date+"'"+")";
                odp.SelectCommand = new OracleCommand(insertSql, odpConn);
                DataSet DS = new DataSet();
                odp.Fill(DS);

                string updateSql = "update bank set b_amount=b_amount-"+amount+" where bank.bank_id=1";
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
