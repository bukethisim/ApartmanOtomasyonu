using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyonu
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Incomes_Click(object sender, EventArgs e)
        {
            Operations form = new Operations();
            this.Visible = false;
            form.Show();

        }

        private void btn_Expenses_Click(object sender, EventArgs e)
        {
            Operations form = new Operations();
            form.SelectedTab();
            this.Visible = false;
            form.Show();
        }
    }
}
