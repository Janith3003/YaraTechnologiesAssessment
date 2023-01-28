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
        private DataTable dt;
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

        public DataTable getAllData()
        {
            con.Open();
            da = new MySqlDataAdapter("SELECT * FROM teachers", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getDataFromName(String name)
        {
            con.Open();
            da = new MySqlDataAdapter("SELECT * FROM teachers where name Like '%" + name + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
