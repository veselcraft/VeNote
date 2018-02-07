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
        INIManager inimanager = new INIManager(Directory.GetCurrentDirectory() + "\\settings.ini");
        public Boolean ww { get; set; }

        public FormSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
            if (comboBox1.SelectedIndex == 1)
            {
                if (inimanager.GetPrivateString("main", "language") != "ru-RU")
                {
                    inimanager.WritePrivateString("main", "language", "ru-RU");
                    MessageBox.Show("Для применения изменений перезапустите программу.", "VeNote");
                }
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                if (inimanager.GetPrivateString("main", "language") != "en-US")
                {
                    inimanager.WritePrivateString("main", "language", "en-US");
                    MessageBox.Show("To apply the changes, restart the program.", "VeNote");
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (inimanager.GetPrivateString("main", "language") != "uk-UA")
                {
                    inimanager.WritePrivateString("main", "language", "uk-UA");
                    MessageBox.Show("Для застосування змін перезапустіть програму.", "VeNote");
                }
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VeNote 3.0.1 alpha\nRibbon панель создана с помощью библиотеки: https://github.com/RibbonWinForms/RibbonWinForms\nVeselcraft.ru 2018",
                "VeNote",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            if (inimanager.GetPrivateString("main", "wordwrap") == "1")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            if (inimanager.GetPrivateString("main", "language") == "en-US")
            {
                comboBox1.SelectedIndex = 0;
            }
            else if (inimanager.GetPrivateString("main", "language") == "ru-RU")
            {
                comboBox1.SelectedIndex = 1;
            }
            else if (inimanager.GetPrivateString("main", "language") == "uk-UA")
            {
                comboBox1.SelectedIndex = 2;
            }
            
        }
    }
}
