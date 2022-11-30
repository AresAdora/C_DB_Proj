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
        
        public WriteOut()
        {
            InitializeComponent();
            showDataGridView();
        }

        private void showDataGridView() //사용자 정의 함수
        {
            try
            {
                odpConn.ConnectionString = "User Id=jy2; Password=1234; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =xe)));";
                odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand("select outcome_id, amount, text, datein from outcome", odpConn);
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
                odpConn.ConnectionString = "User Id = jy2;Password = 1234; Data Source = (DESCRIPTION = (ADDRESS =(PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                odpConn.Open();
                int amount = Convert.ToInt32(txtOut.Text.Trim()); //**
                int b_id = 1;
                String out_tag = txtTag.Text.Trim(); //**
                String out_date = txtDate.Text.Trim(); //**
                string strqry = "INSERT INTO outcome VALUES (" + "'" + b_id + "'" + "," + amount + "," + "'" + out_tag + "'" + "," + "'" + out_date + "'" + ")";
                //"INSERT INTO phone VALUES (id, pname, phone, email)"을 수정
                OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
                //return OraCmd.ExecuteNonQuery(); //추가되는 행수 반환
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
