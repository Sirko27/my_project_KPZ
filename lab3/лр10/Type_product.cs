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
    public partial class Type_product : Form
    {
        public Type_product()
        {
            InitializeComponent();
            db = new DBmanager();
        }

        DBmanager db;
        Logger _Logger = Logger.getInstance();

        private void Type_product_Load(object sender, EventArgs e)
        {
            db.ConnectMy();
            db.SelectAll("type_product", dataGridView1);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " Name=" + tbName.Text + " Description=" + tbDescription.Text);
            MessageBox.Show(_Logger.getLog());
            String[] f = { "ID", "Name", "Description" };
            String[] v = { tbID.Text, "'" + tbName.Text.ToString() + "'", "'" + tbDescription.Text.ToString() + "'" };
            db.Insert("type_product", f, v);
            db.SelectAll("type_product", dataGridView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " Name=" + tbName.Text + " Description=" + tbDescription.Text);
            MessageBox.Show(_Logger.getLog());
            db.Delete("type_product", "ID=" + tbID.Text);
            db.SelectAll("type_product", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch { }
        }

        private void btnUptate_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " Name=" + tbName.Text + " Description=" + tbDescription.Text);
            MessageBox.Show(_Logger.getLog());
            String[] f = { "ID", "Name", "Description" };
            String[] v = { tbID.Text, "'" + tbName.Text.ToString() + "'", "'" + tbDescription.Text.ToString() + "'" };
            db.Update("type_product", f, v, " ID=" + tbID.Text);
            db.SelectAll("type_product", dataGridView1);
        }

        private void Type_product_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Logger.Logging("Close " + ((Form)sender).Name);
            MessageBox.Show(_Logger.getLog());
        }
    }
}
