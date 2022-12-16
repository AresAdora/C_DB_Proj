using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace cheapskate.Forms.Calendar
{
    class ClassCard
    {
        string connstring= "User Id=jy2; Password=1234; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =xe)));";
        public int memo_id { get; set; }
        public string user_id { get; set; }
        public string memo { get; set; }
        public string datein { get; set; }

        public void save()
        {
            OracleConnection conn = new OracleConnection(connstring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            string sql = "insert into memo(seq_memo_id.nextval,'ddd',memo,datein)VALUES(?,?,?,?) where user_info.user_id='ddd'";
            cmd.Parameters.Add("seq_memo_id",this.memo_id);
            cmd.Parameters.Add("'ddd'",this.user_id);
            cmd.Parameters.Add("memo",this.memo);
            cmd.Parameters.Add("datein",this.datein);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}
