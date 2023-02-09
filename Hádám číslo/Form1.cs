using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hádám_číslo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cislo;

        private void btn_mysli_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            cislo = rnd.Next(1, 21);

        }



        private void btn_hadam_Click(object sender, EventArgs e)
        {

            if (nmr_cislo.Value > cislo)
            {

                win.Text = "myšlené číslo je Menší";

            }
            if(nmr_cislo.Value < cislo)
            {
                win.Text = "myšlené číslo je Větší";
            }
            if(nmr_cislo.Value == cislo)
            {
                win.Text = "Správně!";
            }
            
        }
    }
}
