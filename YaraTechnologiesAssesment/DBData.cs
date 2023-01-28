using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace YaraTechnologiesAssesment
{
    class DBData
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        public DBData()
        {
            con = new MySqlConnection("server=localhost; uid=root; password=; database=yaratechnologiesassessment");
        }

        public int insertData(String name, String subject)
        {
            con.Open();
            cmd = new MySqlCommand("INSERT INTO teachers (name, subject) VALUES('" + name + "', '" + subject + "')", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
