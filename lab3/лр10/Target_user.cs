using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр10
{
    public partial class Target_user : Form
    {
        public Target_user()
        {
            InitializeComponent();
            db = new DBmanager();
        }

        DBmanager db;
        Logger _Logger = Logger.getInstance();

        private void Target_user_Load(object sender, EventArgs e)
        {
            db.ConnectMy();
            db.SelectAll("target_user", dataGridView1);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " Name=" + tbName.Text);
            MessageBox.Show(_Logger.getLog());
            String[] f = { "ID", "Name" };
            String[] v = { tbID.Text, "'" + tbName.Text.ToString() + "'" };
            db.Insert("target_user", f, v);
            db.SelectAll("target_user", dataGridView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " Name=" + tbName.Text);
            MessageBox.Show(_Logger.getLog());
            db.Delete("target_user", "ID=" + tbID.Text);
            db.SelectAll("target_user", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnUptate_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " Name=" + tbName.Text);
            MessageBox.Show(_Logger.getLog());
            String[] f = { "ID", "Name" };
            String[] v = { tbID.Text, "'" + tbName.Text.ToString() + "'" };
            db.Update("target_user", f, v, " ID=" + tbID.Text);
            db.SelectAll("target_user", dataGridView1);
        }

        private void Target_user_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Logger.Logging("Close " + ((Form)sender).Name);
            MessageBox.Show(_Logger.getLog());
        }
    }
}
