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
        public string styleribbon { get; set; }

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
            if (checkBox2.Checked == true)
            {
                inimanager.WritePrivateString("main", "CheckUpdates", "1");
            }
            else if (checkBox2.Checked == false)
            {
                inimanager.WritePrivateString("main", "CheckUpdates", "0");
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
            else if (comboBox1.SelectedIndex == 3)
            {
                if (inimanager.GetPrivateString("main", "language") != "be-BY")
                {
                    inimanager.WritePrivateString("main", "language", "be-BY");
                    MessageBox.Show("Для прымянення змяненняў перазапусціце праграму.", "VeNote");
                }
            }
            if (comboBox2.SelectedIndex == 0)
            {
                inimanager.WritePrivateString("main", "style", "office2007");
                styleribbon = "office2007";
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                inimanager.WritePrivateString("main", "style", "office2010");
                styleribbon = "office2010";
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                inimanager.WritePrivateString("main", "style", "office2013");
                styleribbon = "office2013";
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VeNote 3.0.3 alpha\nRibbon панель создана с помощью библиотеки: https://github.com/RibbonWinForms/RibbonWinForms\nVeselcraft.ru 2018",
                "VeNote",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            if (inimanager.GetPrivateString("main", "wordwrap") == "0") // WORD WRAP - ПЕРЕНОС СЛОВ
            {
                checkBox1.Checked = false;
            }
            else if (inimanager.GetPrivateString("main", "wordwrap") == "1")
            {
                checkBox1.Checked = true;
            }
            else if (inimanager.GetPrivateString("main", "wordwrap") == "")
            {
                checkBox1.Checked = true;
            }
            if (inimanager.GetPrivateString("main", "CheckUpdates") == "0") // CHECK UPDATES - ПРОВЕРКА ОБНОВЛЕНИЙ
            {
                checkBox2.Checked = false;
            }
            else if (inimanager.GetPrivateString("main", "CheckUpdates") == "1")
            {
                checkBox2.Checked = true;
            }
            else if (inimanager.GetPrivateString("main", "CheckUpdates") == "")
            {
                checkBox2.Checked = true;
            }
            if (inimanager.GetPrivateString("main", "language") == "en-US") // LANGUAGES - ЯЗЫКИ
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
            else if (inimanager.GetPrivateString("main", "language") == "be-BY")
            {
                comboBox1.SelectedIndex = 3;
            }
            if (inimanager.GetPrivateString("main", "style") == "office2013") // STYLES - СТИЛИ
            {
                comboBox2.SelectedIndex = 2;
            }
            else if (inimanager.GetPrivateString("main", "style") == "office2010")
            {
                comboBox2.SelectedIndex = 1;
            }
            else if (inimanager.GetPrivateString("main", "style") == "office2007")
            {
                comboBox2.SelectedIndex = 0;
            }
            else
            {
                comboBox2.SelectedIndex = 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
