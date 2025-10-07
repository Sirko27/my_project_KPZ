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
    public partial class List_product : Form
    {
        public List_product()
        {
            InitializeComponent();
            db = new DBmanager();
        }

        DBmanager db;
        Logger _Logger = Logger.getInstance();

        private void btnInsert_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " Name=" + tbName.Text + " Main_component=" + tbMain_component.Text +
                " Cost=" + tbCost.Text + " Product_weight=" + tbProduct_weight.Text + " Product_type=" + tbProduct_tupe.Text);
            MessageBox.Show(_Logger.getLog());
            String[] f = { "ID", "Name", "Main_component", "Cost", "Product_weight", "Product_type" };
            String[] v = { tbID.Text, "'" + tbName.Text.ToString() + "'", "'" + tbMain_component.Text.ToString() + "'", tbCost.Text, tbProduct_weight.Text, tbProduct_tupe.Text };
            db.Insert("list_product", f, v);
            db.SelectAll("list_product", dataGridView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " Name=" + tbName.Text + " Main_component=" + tbMain_component.Text +
                " Cost=" + tbCost.Text + " Product_weight=" + tbProduct_weight.Text + " Product_type=" + tbProduct_tupe.Text);
            MessageBox.Show(_Logger.getLog());
            db.Delete("list_product", "ID=" + tbID.Text);
            db.SelectAll("list_product", dataGridView1);
        }

        private void List_product_Load(object sender, EventArgs e)
        {
            db.ConnectMy();
            db.SelectAll("list_product", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbCost.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbProduct_weight.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbProduct_tupe.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnUptate_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " Name=" + tbName.Text + " Main_component=" + tbMain_component.Text +
                " Cost=" + tbCost.Text + " Product_weight=" + tbProduct_weight.Text + " Product_type=" + tbProduct_tupe.Text);
            MessageBox.Show(_Logger.getLog());
            String[] f = { "ID", "Name", "Main_component", "Cost", "Product_weight", "Product_type" };
            String[] v = { tbID.Text, "'" + tbName.Text.ToString() + "'", "'" + tbMain_component.Text.ToString() + "'", tbCost.Text, tbProduct_tupe.Text, tbProduct_weight.Text };
            db.Update("list_product", f, v, " ID=" + tbID.Text);
            db.SelectAll("list_product", dataGridView1);
        }

        private void List_product_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Logger.Logging("Close " + ((Form)sender).Name);
            MessageBox.Show(_Logger.getLog());
        }
    }
}
