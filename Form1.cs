using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using INIManager = VeNote.INIManager;
using System.IO;
using System.Globalization;
using System.Threading;

namespace VeNote
{
    public partial class Form1 : RibbonForm
    {
        INIManager inimanager = new INIManager(Directory.GetCurrentDirectory() + "\\settings.ini");
        string[] arg;
        string SaveDocumentQuestionString;
        public Form1(string[] args)
        {
            if (inimanager.GetPrivateString("main", "language") == "en-US")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            }
            else if (inimanager.GetPrivateString("main", "language") == "ru-RU")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru-RU");
            }
            else if (inimanager.GetPrivateString("main", "language") == "uk-UA")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("uk-UA");
            }
            else if (inimanager.GetPrivateString("main", "language") == "be-BY")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("be-BY");
            }

            InitializeComponent();
            arg = args;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (inimanager.GetPrivateString("main", "font") != null)
            {
                var cvt = new FontConverter();
                Font f = cvt.ConvertFromString(inimanager.GetPrivateString("main", "font")) as Font;
                richTextBoxClient.Font = f;
                //this.richTextBoxClient.Font = new Font(f, float.Parse(inimanager.GetPrivateString("main", "fontsize"), CultureInfo.InvariantCulture.NumberFormat), this.richTextBoxClient.Font.Style);
            }
            if (arg.Length != 0)
            {
                richTextBoxClient.LoadFile(arg[0], RichTextBoxStreamType.PlainText);
                this.Text = arg[0] + "  -  VeNote";

            }
            if (inimanager.GetPrivateString("main", "wordwrap") != "0")
            {
                richTextBoxClient.WordWrap = false;
                richTextBoxClient.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            }
            if (inimanager.GetPrivateString("window", "locationx") != null)
            {
                this.Location = new Point(
                        Convert.ToInt32(inimanager.GetPrivateString("window", "locationx")),
                        Convert.ToInt32(inimanager.GetPrivateString("window", "locationy"))
                    );
                this.Size = new Size(
                        Convert.ToInt32(inimanager.GetPrivateString("window", "sizew")),
                        Convert.ToInt32(inimanager.GetPrivateString("window", "sizeh"))
                );

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBoxClient.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = openFileDialog1.FileName;
            }
        }

        private void richTextBoxClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void ribbonButtonPaste_Click(object sender, EventArgs e)
        {
            richTextBoxClient.Paste();
        }

        private void ribbonButtonCopy_Click(object sender, EventArgs e)
        {
            richTextBoxClient.Copy();
        }

        private void ribbonButtonCut_Click(object sender, EventArgs e)
        {
            richTextBoxClient.Cut();
        }

        private void ribbonButtonSelectAll_Click(object sender, EventArgs e)
        {
            richTextBoxClient.SelectAll();
        }

        private void ribbonButtonNew_Click(object sender, EventArgs e)
        {
            if (richTextBoxClient.Text != "")
            {
                
                switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
                {
                    case "en-US":
                        SaveDocumentQuestionString = "Do you have to save this document?";
                        break;
                    case "uk-UA":
                        SaveDocumentQuestionString = "Ви хочете зберегти документ?";
                        break;
                    case "ru-RU":
                        SaveDocumentQuestionString = "Вы хотите сохранить документ?";
                        break;
                    case "be-BY":
                        SaveDocumentQuestionString = "Вы хочаце захаваць дакумент?";
                        break;
                }
                DialogResult SaveDocumentQuestion = MessageBox.Show(SaveDocumentQuestionString,
                "VeNote",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
                if (SaveDocumentQuestion == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBoxClient.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        this.Text = "VeNote";
                        richTextBoxClient.Text = "";
                    }
                }
                else if (SaveDocumentQuestion == DialogResult.No)
                {
                    richTextBoxClient.Text = "";
                    this.Text = "VeNote";
                }
            }
        }

        private void ribbonButtonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBoxClient.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = openFileDialog1.FileName + "  -  VeNote";
            }
        }

        private void ribbonButtonSave_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBoxClient.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = saveFileDialog1.FileName + "  -  VeNote";
            }
        }

        private void ribbonButtonFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) 
            {
                richTextBoxClient.SelectionFont = fontDialog1.Font;
                var cvt = new FontConverter();
                string fontSetting = cvt.ConvertToString(fontDialog1.Font);
                inimanager.WritePrivateString("main", "font", fontSetting);

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            inimanager.WritePrivateString("window", "locationx", Convert.ToString(this.Location.X));
            inimanager.WritePrivateString("window", "locationy", Convert.ToString(this.Location.Y));
            inimanager.WritePrivateString("window", "sizeh", Convert.ToString(this.Size.Height));
            inimanager.WritePrivateString("window", "sizew", Convert.ToString(this.Size.Width));
            if (richTextBoxClient.Text != "")
            {
                switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
                {
                    case "en-US":
                        SaveDocumentQuestionString = "Do you have to save this document?";
                        break;
                    case "uk-UA":
                        SaveDocumentQuestionString = "Ви хочете зберегти документ?";
                        break;
                    case "ru-RU":
                        SaveDocumentQuestionString = "Вы хотите сохранить документ?";
                        break;
                    case "be-BY":
                        SaveDocumentQuestionString = "Вы хочаце захаваць дакумент?";
                        break;
                }
                


                DialogResult SaveDocumentQuestion = MessageBox.Show(SaveDocumentQuestionString,
                "VeNote",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
                if (SaveDocumentQuestion == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBoxClient.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        
                    }
                }
                else if (SaveDocumentQuestion == DialogResult.No)
                {
                    
                }
                else if (SaveDocumentQuestion == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
        }

        private void ribbonButtonUndo_Click(object sender, EventArgs e)
        {
            richTextBoxClient.Undo();
        }

        private void ribbonButtonRedo_Click(object sender, EventArgs e)
        {
            richTextBoxClient.Redo();
        }

        private void ribbonOrbMenuItemSettings_Click(object sender, EventArgs e)
        {
            using (FormSettings fs = new FormSettings())
            {
                if (fs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (fs.ww == true)
                    {
                        richTextBoxClient.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
                        richTextBoxClient.WordWrap = true;
                    }
                    else
                    {
                        richTextBoxClient.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
                        richTextBoxClient.WordWrap = false;
                    }
                }
            }
        }

        private void ribbonOrbMenuItemExit_Click(object sender, EventArgs e)
        {
            inimanager.WritePrivateString("window", "locationx", Convert.ToString(this.Location.X));
            inimanager.WritePrivateString("window", "locationy", Convert.ToString(this.Location.Y));
            inimanager.WritePrivateString("window", "sizeh", Convert.ToString(this.Size.Height));
            inimanager.WritePrivateString("window", "sizew", Convert.ToString(this.Size.Width));
            if (richTextBoxClient.Text != "")
            {
                switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
                {
                    case "en-US":
                        SaveDocumentQuestionString = "Do you have to save this document?";
                        break;
                    case "uk-UA":
                        SaveDocumentQuestionString = "Ви хочете зберегти документ?";
                        break;
                    case "ru-RU":
                        SaveDocumentQuestionString = "Вы хотите сохранить документ?";
                        break;
                    case "be-BY":
                        SaveDocumentQuestionString = "Вы хочаце захаваць дакумент?";
                        break;
                }
                DialogResult SaveDocumentQuestion = MessageBox.Show(SaveDocumentQuestionString,
                "VeNote",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
                if (SaveDocumentQuestion == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBoxClient.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        Application.Exit();
                    }
                }
                else if (SaveDocumentQuestion == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void ribbonOrbOptionButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VeNote 3.0.2 alpha\nRibbon панель создана с помощью библиотеки: https://github.com/RibbonWinForms/RibbonWinForms\nПеракладзена на беларускую мову Даніілам Мысливицом\nVeselcraft.ru 2018",
                            "VeNote",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
