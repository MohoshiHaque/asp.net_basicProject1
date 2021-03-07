using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            MessageBox.Show(name);
        }

        private void IdBtn_Click(object sender, EventArgs e)
        {
            string id1 = textBox2.Text;
            MessageBox.Show(id1);
        }
    }
}
