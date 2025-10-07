using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace лр10
{
    public class DBmanager
    {
        static DBmanager Instance;
        public DBmanager()
        {
            cmd_my.Connection = con_my;
        }

        public static DBmanager getInstance()
        {
            if (Instance == null)
            {
                return new DBmanager();
            }
            return Instance;
        }

        MySqlConnection con_my = new MySqlConnection();
        MySqlCommand cmd_my = new MySqlCommand();
        String conStr_my = "Server=localhost;Database=db_Product_package;Uid=root;Pwd=Sirko;";

        public bool ConnectMy()
        {
            try
            {
                con_my.ConnectionString = conStr_my;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void DisconnectMy()
        {
            con_my.Close();
        }
        public void CreateTable(String sqlcmd)
        {
            try
            {
                con_my.Open();
                cmd_my.CommandText = sqlcmd;
                cmd_my.ExecuteNonQuery();
                con_my.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<List<Object>> SelectAll(String tablename)
        {
            try
            {
                var res = new List<List<Object>>();
                cmd_my.CommandText = "select * from " + tablename;
                con_my.Open();
                MySqlDataReader r = cmd_my.ExecuteReader();

                while (r.Read())
                {
                    List<Object> row = new List<object>();
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        row.Add(r[i]);
                    }
                    res.Add(row);
                }

                con_my.Close();

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void fillGrid(DataGridView dg, MySqlDataReader r)
        {
            dg.Columns.Clear();
            for (int i = 0; i < r.FieldCount; i++)
            {
                dg.Columns.Add("col" + i.ToString(), r.GetName(i));
            }



            while (r.Read())
            {
                String[] s = new String[r.FieldCount];
                for (int i = 0; i < r.FieldCount; i++)
                {
                    s[i] = r[i].ToString();
                }
                dg.Rows.Add(s);
            }
        }

        public void SelectAll(String tablename, DataGridView dg)
        {
            try
            {
                cmd_my.CommandText = "select * from " + tablename;
                con_my.Open();
                MySqlDataReader r = cmd_my.ExecuteReader();

                fillGrid(dg, r);

                con_my.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExecMySQL(String query)
        {
            try
            {
                cmd_my.CommandText = query;
                con_my.Open();
                cmd_my.ExecuteNonQuery();
                con_my.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(String table_name, String[] fields, String[] values)
        {
            try
            {
                cmd_my.CommandText = "insert into " + table_name + "(" + String.Join(",", fields) + ") values(" + String.Join(",", values) + ")";
                con_my.Open();
                cmd_my.ExecuteNonQuery();
                con_my.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(String table_name, String cond)
        {
            try
            {
                if (cond != "")
                    cmd_my.CommandText = "delete from " + table_name + " where " + cond;
                else
                    cmd_my.CommandText = "delete from " + table_name;

                con_my.Open();
                cmd_my.ExecuteNonQuery();
                con_my.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(String table_name, String[] fields, String[] values, String cond)
        {
            try
            {
                string[] vapours = new string[fields.Length];
                for (int i = 0; i < fields.Length; i++)
                {
                    vapours[i] = $"{fields[i]} = {values[i]}";
                }

                string vp = String.Join(", ", vapours);

                cmd_my.CommandText = "update " + table_name + " set " + vp + " where " + cond;
                con_my.Open();
                cmd_my.ExecuteNonQuery();
                con_my.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}