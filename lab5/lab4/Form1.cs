using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Builder;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Burger Bur;
        Burger Bur1;
        IBuilder Bui;
        Director Dir = new Director();

        private void rbBurger1_CheckedChanged(object sender, EventArgs e)
        {
            Bui = new builderBurger1();
            Dir.Builder = Bui;
            //Dir.builderBurger();
        }

        private void rbBurger2_CheckedChanged(object sender, EventArgs e)
        {
            Bui = new builderBurger2();
            Dir.Builder = Bui;
            //Dir.builderBurger();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (Dir != null && Bui != null)
            {
                Dir.builderBurger();
                Bur = Bui.getResult(); 
                Bur1 = Bur.Clone();
                Bur1.Meat = "Риба";
                MessageBox.Show(Bur.getInfo()+ "\nКлон: " + Bur1.getInfo());
                //Bur1 = Bur.Clone();
                //MessageBox.Show("Клон: " + Bur1.getInfo());
            }
        }
    }
}
