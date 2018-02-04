using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Form1 = VeNote.Form1;

namespace VeNote
{
    public partial class FormSettings : Form
    {

        public Boolean ww { get; set; }

        public FormSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INIManager inimanager = new INIManager(Directory.GetCurrentDirectory() + "\\settings.ini");
            if (checkBox1.Checked == true)
            {
                inimanager.WritePrivateString("main", "wordwrap", "1");
                ww = true;
            }
            else
            {
                inimanager.WritePrivateString("main", "wordwrap", "0");
                ww = false;
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VeNote 3.0 alpha\nRibbon панель создана с помощью библиотеки: https://github.com/RibbonWinForms/RibbonWinForms\nVeselcraft.ru 2018",
                "VeNote",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
