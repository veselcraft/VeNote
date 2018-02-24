using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VeNote
{
    public partial class FormFind : Form
    {
        public string lineword { get; set; }
        public int finduprodown { get; set; }

        public FormFind()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lineword = textBox1.Text;
            if (radioButton1.Checked == true)
            {
                finduprodown = 0; // up
            }
            else
            {
                finduprodown = 1; // down
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
