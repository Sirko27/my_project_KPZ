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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            db = new DBmanager();
        }

        DBmanager db;
        Logger _Logger = Logger.getInstance();

        private void Items_Load(object sender, EventArgs e)
        {
            db.ConnectMy();
            db.SelectAll("items", dataGridView1);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " Name=" + tbName.Text + "Cost=" + tbCost.Text);
            MessageBox.Show(_Logger.getLog());
            String[] f = { "ID", "Name", "Cost" };
            String[] v = { tbID.Text, "'" + tbName.Text.ToString() + "'", tbCost.Text };
            db.Insert("items", f, v);
            db.SelectAll("items", dataGridView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " Name=" + tbName.Text + "Cost=" + tbCost.Text);
            MessageBox.Show(_Logger.getLog());
            db.Delete("items", "ID=" + tbID.Text);
            db.SelectAll("items", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                tbID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbCost.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnUptate_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " Name=" + tbName.Text + "Cost=" + tbCost.Text);
            MessageBox.Show(_Logger.getLog());
            String[] f = { "ID", "Name", "Cost" };
            String[] v = { tbID.Text, "'" + tbName.Text.ToString() + "'", tbCost.Text };
            db.Update("items", f, v, " ID=" + tbID.Text);
            db.SelectAll("items", dataGridView1);
        }

        private void Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Logger.Logging("Close "+((Form)sender).Name);
            MessageBox.Show(_Logger.getLog());
        }
    }
}
