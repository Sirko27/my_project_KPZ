using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factory_Method;

namespace lr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        House H;
        Construction C;


        private void Baroque_CheckedChanged(object sender, EventArgs e)
        {
            C = new Building_House_Baroque();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (C != null)
            {
                H = C.buildingHouse();
                MessageBox.Show(H.getInfo());
            }

        }

        private void rbClassic_CheckedChanged(object sender, EventArgs e)
        {
            C = new Building_House_Classic();
        }

        private void rbRomanesque_CheckedChanged(object sender, EventArgs e)
        {
            C = new Building_House_Romanesque();
        }
    }
}
