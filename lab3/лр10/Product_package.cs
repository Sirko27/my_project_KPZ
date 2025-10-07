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
    public partial class Product_package : Form
    {
        public Product_package()
        {
            InitializeComponent();
            db = new DBmanager();
        }

        DBmanager db;
        Logger _Logger = Logger.getInstance();
        private void Product_package_Load(object sender, EventArgs e)
        {
            db.ConnectMy();
            db.SelectAll("product_package", dataGridView1);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " List_product=" + tbList_product.Text + " Picker=" + tbPicker.Text +
                " Target_user=" + tbTarget_user.Text + " Date_=" + tbDate_.Text + " Cost=" + tbCost.Text + " Product_weight=" +
                tbProduct_weight.Text + " Description_product=" + tbDescription_product.Text);
            MessageBox.Show(_Logger.getLog());
            String[] f = { "ID", "List_product", "Picker", "Target_user", "Date_", "Cost", "Product_weight", "Description_product" };
            String[] v = { tbID.Text, tbList_product.Text, "'" + tbPicker.Text.ToString() + "'", tbTarget_user.Text, tbDate_.Text, tbCost.Text, tbProduct_weight.Text, "'" + tbDescription_product + "'" };
            db.Insert("product_package", f, v);
            db.SelectAll("product_package", dataGridView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " List_product=" + tbList_product.Text + " Picker=" + tbPicker.Text +
                " Target_user=" + tbTarget_user.Text + " Date_=" + tbDate_.Text + " Cost=" + tbCost.Text + " Product_weight=" +
                tbProduct_weight.Text + " Description_product=" + tbDescription_product.Text);
            MessageBox.Show(_Logger.getLog());
            db.Delete("product_package", "ID=" + tbID.Text);
            db.SelectAll("product_package", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbList_product.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbPicker.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbTarget_user.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbDate_.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbCost.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbProduct_weight.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbDescription_product.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch { }
        }

        private void btnUptate_Click(object sender, EventArgs e)
        {
            _Logger.Logging(((Button)sender).Text + "ID=" + tbID.Text + " List_product=" + tbList_product.Text + " Picker=" + tbPicker.Text +
                " Target_user=" + tbTarget_user.Text + " Date_=" + tbDate_.Text + " Cost=" + tbCost.Text + " Product_weight=" +
                tbProduct_weight.Text + " Description_product=" + tbDescription_product.Text);
            MessageBox.Show(_Logger.getLog());
            String[] f = { "ID", "List_product", "Picker", "Target_user", "Date_", "Cost", "Product_weight", "Description_product" };
            String[] v = { tbID.Text, tbList_product.Text, "'" + tbPicker.Text.ToString() + "'", tbTarget_user.Text, tbDate_.Text, tbCost.Text, tbProduct_weight.Text, "'" + tbDescription_product + "'" };
            db.Update("product_package", f, v, " ID=" + tbID.Text);
            db.SelectAll("product_package", dataGridView1);
        }

        private void Product_package_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Logger.Logging("Close " + ((Form)sender).Name);
            MessageBox.Show(_Logger.getLog());
        }
    }
}
