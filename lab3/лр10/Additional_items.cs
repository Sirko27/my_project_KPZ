using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace лр10
{
    public partial class Additional_items : Form
    {
        public Additional_items()
        {
            InitializeComponent();
            db = new DBmanager();
        }

        DBmanager db;
        Logger _Logger = Logger.getInstance();

        private void Additional_items_Load(object sender, EventArgs e)
        {
            db.ConnectMy();
            db.SelectAll("additional_items", dataGridView1);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID_product=" + tbID_product.Text + " ID_Items=" + tbID_items.Text + " Number=" + tbNumber.Text +
                " Description=" + tbDescription.Text);
            MessageBox.Show(_Logger.getLog());
            String[] f = { "ID_product", "ID_Items", "Number", "Description" };
            String[] v = { tbID_product.Text, tbID_items.Text, tbNumber.Text, "'" + tbDescription.Text.ToString() + "'" };
            db.Insert("additional_items", f, v);
            db.SelectAll("additional_items", dataGridView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID_product=" + tbID_product.Text + " ID_Items=" + tbID_items.Text + " Number=" + tbNumber.Text +
                " Description=" + tbDescription.Text);
            MessageBox.Show(_Logger.getLog());
            db.Delete("additional_items", "ID_product=" + tbID_product.Text);
            db.SelectAll("additional_items", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbID_product.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbID_items.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch { }
        }

        private void btnUptate_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID_product=" + tbID_product.Text + " ID_Items=" + tbID_items.Text + " Number=" + tbNumber.Text +
                " Description=" + tbDescription.Text);
            MessageBox.Show(_Logger.getLog());
            String[] f = { "ID_product", "ID_Items", "Number", "Description" };
            String[] v = { tbID_product.Text, tbID_items.Text, tbNumber.Text, "'" + tbDescription.Text.ToString() + "'" };
            db.Update("additional_items", f, v, " ID_product=" + tbID_product.Text);
            db.SelectAll("additional_items", dataGridView1);
        }

        private void Additional_items_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Logger.Logging("Close " + ((Form)sender).Name);
            MessageBox.Show(_Logger.getLog());
        }
    }
}
