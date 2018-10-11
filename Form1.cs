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
using System.Net;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Resources;
using System.Reflection;

namespace VeNote
{
    public partial class Form1 : RibbonForm
    {
        static string exeasmb = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        INIManager inimanager = new INIManager(exeasmb + "\\settings.ini");
        string[] arg;
        string SaveDocumentQuestionString;
        string UpdateMessageString;
        string WordNotFoundString;
        string[] originaltextstr;
        public Form1(string[] args)
        {
            switch (inimanager.GetPrivateString("main", "language"))
            {
                case "en-US":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    break;
                case "ru-RU":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
                    break;
                case "uk-UA":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("uk-UA");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");
                    break;
                case "be-BY":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("be-BY");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("be-BY");
                    break;
                case "ja-JP":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("ja-JP");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-JP");
                    break;

            }
            Assembly a = Assembly.Load("VeNote");
            ResourceManager rm = new ResourceManager("VeNote.Form1", a);
            SaveDocumentQuestionString = rm.GetString("SaveDocumentQuestionString");
            UpdateMessageString = rm.GetString("UpdateMessageString");
            WordNotFoundString = rm.GetString("WordNotFoundString");
            InitializeComponent();
            arg = args;
        }

        public static string GetUpdate()
        {
            string version = Application.ProductVersion;
            string url = "http://veselcraft.ru/checkUpdates.php?product=" + Application.ProductName;
            string versionActually;

            using (var webCheckUpdate = new WebClient())
            {
                webCheckUpdate.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 6.0; VeNote " + Application.ProductVersion + ")");
                Stream data = webCheckUpdate.OpenRead(url);
                StreamReader reader = new StreamReader(data);
                versionActually = reader.ReadToEnd();
            }
                return versionActually;
        }

        private void OriginalText()  // Костыль, чтобы можно было выйти из программы, если только что открытый текст никак не изменялся
        {
            originaltextstr = richTextBoxClient.Lines;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switch (inimanager.GetPrivateString("main", "style"))
            {
                case "office2007":
                    ribbon1.OrbStyle = RibbonOrbStyle.Office_2007;
                    ribbon1.OrbImage = VeNote.Properties.Resources.logo;
                    break;
                case "office2010":
                    ribbon1.OrbStyle = RibbonOrbStyle.Office_2010;
                    ribbon1.OrbImage = null;
                    break;
                case "office2013":
                    ribbon1.OrbStyle = RibbonOrbStyle.Office_2013;
                    ribbon1.OrbImage = null;
                    break;
            }
            if (inimanager.GetPrivateString("main", "font") != null)
            {

                var cvt = new FontConverter();
                Font f = cvt.ConvertFromString(inimanager.GetPrivateString("main", "font")) as Font;
                richTextBoxClient.Font = f;
            }
            if (arg.Length != 0)
            {
                richTextBoxClient.LoadFile(arg[0], RichTextBoxStreamType.PlainText);
                this.Text = arg[0] + "  -  VeNote";
                OriginalText();

            }
            if (inimanager.GetPrivateString("main", "wordwrap") == "0")
            {
                richTextBoxClient.WordWrap = false;
                richTextBoxClient.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            }
            else if (inimanager.GetPrivateString("main", "wordwrap") == "1")
            {
                richTextBoxClient.WordWrap = true;
                richTextBoxClient.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            }
            else
            {
                richTextBoxClient.WordWrap = false;
                richTextBoxClient.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            }
            if (inimanager.GetPrivateString("window", "locationx") != "")
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
            
            if (inimanager.GetPrivateString("main", "CheckUpdates") == "1")
            {

                string updateStr = GetUpdate();
                UpdateJson updj = JsonConvert.DeserializeObject<UpdateJson>(updateStr);
                if (updj.version != Application.ProductVersion)
                {
                    if (MessageBox.Show(UpdateMessageString + " (" + updj.version + ")", "VeNote", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start(updj.link);
                    }
                }
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
                OriginalText();
            }
        }

        private void richTextBoxClient_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.StartsWith("*") == false)
            {
                this.Text = "*" + this.Text;
            }
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
            if (richTextBoxClient.Text != "" || richTextBoxClient.Lines != originaltextstr)
            {
                DialogResult SaveDocumentQuestion = MessageBox.Show(SaveDocumentQuestionString,
                "VeNote",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
                if (SaveDocumentQuestion == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBoxClient.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
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
                OriginalText();
            }
        }

        private void ribbonButtonSave_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBoxClient.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
                this.Text = saveFileDialog1.FileName + "  -  VeNote";
                OriginalText();
            }
        }

        private void ribbonButtonFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) 
            {
                richTextBoxClient.Font = fontDialog1.Font;
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
            if (richTextBoxClient.Text != "" || richTextBoxClient.Lines == originaltextstr)
            {
                DialogResult SaveDocumentQuestion = MessageBox.Show(SaveDocumentQuestionString,
                "VeNote",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
                if (SaveDocumentQuestion == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBoxClient.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
                        Application.Exit();
                    }
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

                    if (fs.styleribbon == "office2007")
                    {
                        ribbon1.OrbStyle = RibbonOrbStyle.Office_2007;
                        ribbon1.OrbImage = VeNote.Properties.Resources.logo;
                    }
                    else if (fs.styleribbon == "office2010")
                    {
                        ribbon1.OrbStyle = RibbonOrbStyle.Office_2010;
                        ribbon1.OrbImage = null;
                    }
                    else if (fs.styleribbon == "office2013")
                    {
                        ribbon1.OrbStyle = RibbonOrbStyle.Office_2013;
                        ribbon1.OrbImage = null;
                    }
                }
                this.Activate();
            }
        }

        private void ribbonOrbMenuItemExit_Click(object sender, EventArgs e)
        {
            inimanager.WritePrivateString("window", "locationx", Convert.ToString(this.Location.X));
            inimanager.WritePrivateString("window", "locationy", Convert.ToString(this.Location.Y));
            inimanager.WritePrivateString("window", "sizeh", Convert.ToString(this.Size.Height));
            inimanager.WritePrivateString("window", "sizew", Convert.ToString(this.Size.Width));
            if (richTextBoxClient.Text != "" || richTextBoxClient.Lines != originaltextstr)
            {
                DialogResult SaveDocumentQuestion = MessageBox.Show(SaveDocumentQuestionString,
                "VeNote",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
                if (SaveDocumentQuestion == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBoxClient.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
                        Application.Exit();
                    }
                }
                else if (SaveDocumentQuestion == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void ribbonOrbOptionButton2_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }
        int findResult;
        private void ribbonButtonFind_Click(object sender, EventArgs e)
        {
            using (FormFind ff = new FormFind())
            {
                if (ff.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(ff.lineword))
                    {
                        

                        switch (ff.finduprodown)
                        {
                            case 0:
                                findResult = richTextBoxClient.Find(ff.lineword);
                                break;
                            case 1:
                                findResult = richTextBoxClient.Find(ff.lineword);
                                break;
                        }
                        if (findResult == -1)
                        {
                            MessageBox.Show(WordNotFoundString, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
        }
    }

    class UpdateJson
    {
        public string version { get; set; }
        public string link { get; set; }
    }
}

