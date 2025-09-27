using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AFactory;

namespace lr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ABarChair abch;
        AGardenСhair agch;
        AKitchenChair akch;
        AChair ach;
        AChairFactory achf;

        private void Create_Click(object sender, EventArgs e)
        {
            if (achf != null)
            {
                abch = achf.createABarChair();
                agch = achf.createAGardenChair();
                akch = achf.createAKitchenChair();

                MessageBox.Show(abch.getInfo());
            }
        }

        private void Baroque_CheckedChanged(object sender, EventArgs e)
        {
            achf = new ABaroqueFactory();
        }
    }
}