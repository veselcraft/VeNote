﻿namespace VeNote
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBoxClient = new System.Windows.Forms.RichTextBox();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonPaste = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonCopy = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonCut = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonFont = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonFind = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonSelectAll = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonUndo = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonRedo = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItemNew = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemOpen = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemSave = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemSettings = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemExit = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonButtonNew = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonSave = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonOpen = new System.Windows.Forms.RibbonButton();
            this.ribbonOrbOptionButton1 = new System.Windows.Forms.RibbonOrbOptionButton();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            // 
            // richTextBoxClient
            // 
            this.richTextBoxClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxClient.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxClient.Location = new System.Drawing.Point(0, 140);
            this.richTextBoxClient.Name = "richTextBoxClient";
            this.richTextBoxClient.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxClient.Size = new System.Drawing.Size(531, 217);
            this.richTextBoxClient.TabIndex = 1;
            this.richTextBoxClient.Text = "";
            this.richTextBoxClient.TextChanged += new System.EventHandler(this.richTextBoxClient_TextChanged);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Text = "Главная";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.ribbonButtonPaste);
            this.ribbonPanel1.Items.Add(this.ribbonButtonCopy);
            this.ribbonPanel1.Items.Add(this.ribbonButtonCut);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Буфер обмена";
            // 
            // ribbonButtonPaste
            // 
            this.ribbonButtonPaste.AltKey = "Ctrl+V";
            this.ribbonButtonPaste.Image = global::VeNote.Properties.Resources.paste1;
            this.ribbonButtonPaste.LargeImage = global::VeNote.Properties.Resources.paste1;
            this.ribbonButtonPaste.Name = "ribbonButtonPaste";
            this.ribbonButtonPaste.SmallImage = global::VeNote.Properties.Resources.paste1;
            this.ribbonButtonPaste.Text = "Вставить";
            this.ribbonButtonPaste.Click += new System.EventHandler(this.ribbonButtonPaste_Click);
            // 
            // ribbonButtonCopy
            // 
            this.ribbonButtonCopy.AltKey = "Ctrl+C";
            this.ribbonButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonCopy.Image")));
            this.ribbonButtonCopy.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonCopy.LargeImage")));
            this.ribbonButtonCopy.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonCopy.Name = "ribbonButtonCopy";
            this.ribbonButtonCopy.SmallImage = global::VeNote.Properties.Resources.copy;
            this.ribbonButtonCopy.Text = "Копировать";
            this.ribbonButtonCopy.Click += new System.EventHandler(this.ribbonButtonCopy_Click);
            // 
            // ribbonButtonCut
            // 
            this.ribbonButtonCut.AltKey = "Ctrl+X";
            this.ribbonButtonCut.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonCut.Image")));
            this.ribbonButtonCut.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonCut.LargeImage")));
            this.ribbonButtonCut.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonCut.Name = "ribbonButtonCut";
            this.ribbonButtonCut.SmallImage = global::VeNote.Properties.Resources.cut;
            this.ribbonButtonCut.Text = "Вырезать";
            this.ribbonButtonCut.Click += new System.EventHandler(this.ribbonButtonCut_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ButtonMoreVisible = false;
            this.ribbonPanel2.Items.Add(this.ribbonButtonFont);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Форматирование";
            // 
            // ribbonButtonFont
            // 
            this.ribbonButtonFont.Image = global::VeNote.Properties.Resources.font;
            this.ribbonButtonFont.LargeImage = global::VeNote.Properties.Resources.font;
            this.ribbonButtonFont.Name = "ribbonButtonFont";
            this.ribbonButtonFont.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonFont.SmallImage")));
            this.ribbonButtonFont.Text = "Шрифт";
            this.ribbonButtonFont.Click += new System.EventHandler(this.ribbonButtonFont_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ButtonMoreVisible = false;
            this.ribbonPanel3.Items.Add(this.ribbonButtonFind);
            this.ribbonPanel3.Items.Add(this.ribbonButtonSelectAll);
            this.ribbonPanel3.Items.Add(this.ribbonSeparator2);
            this.ribbonPanel3.Items.Add(this.ribbonButtonUndo);
            this.ribbonPanel3.Items.Add(this.ribbonButtonRedo);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "Редактрование";
            // 
            // ribbonButtonFind
            // 
            this.ribbonButtonFind.Enabled = false;
            this.ribbonButtonFind.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonFind.Image")));
            this.ribbonButtonFind.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonFind.LargeImage")));
            this.ribbonButtonFind.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonFind.Name = "ribbonButtonFind";
            this.ribbonButtonFind.SmallImage = global::VeNote.Properties.Resources.system_search;
            this.ribbonButtonFind.Text = "Найти";
            // 
            // ribbonButtonSelectAll
            // 
            this.ribbonButtonSelectAll.AltKey = "Ctrl+A";
            this.ribbonButtonSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSelectAll.Image")));
            this.ribbonButtonSelectAll.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSelectAll.LargeImage")));
            this.ribbonButtonSelectAll.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonSelectAll.Name = "ribbonButtonSelectAll";
            this.ribbonButtonSelectAll.SmallImage = global::VeNote.Properties.Resources.cursor;
            this.ribbonButtonSelectAll.Text = "Выбрать всё";
            this.ribbonButtonSelectAll.Click += new System.EventHandler(this.ribbonButtonSelectAll_Click);
            // 
            // ribbonSeparator2
            // 
            this.ribbonSeparator2.DropDownWidth = System.Windows.Forms.RibbonSeparatorDropDownWidth.Partial;
            this.ribbonSeparator2.Name = "ribbonSeparator2";
            // 
            // ribbonButtonUndo
            // 
            this.ribbonButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonUndo.Image")));
            this.ribbonButtonUndo.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonUndo.LargeImage")));
            this.ribbonButtonUndo.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonUndo.Name = "ribbonButtonUndo";
            this.ribbonButtonUndo.SmallImage = global::VeNote.Properties.Resources.undo;
            this.ribbonButtonUndo.Text = "Отменить";
            this.ribbonButtonUndo.Click += new System.EventHandler(this.ribbonButtonUndo_Click);
            // 
            // ribbonButtonRedo
            // 
            this.ribbonButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRedo.Image")));
            this.ribbonButtonRedo.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRedo.LargeImage")));
            this.ribbonButtonRedo.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonRedo.Name = "ribbonButtonRedo";
            this.ribbonButtonRedo.SmallImage = global::VeNote.Properties.Resources.redo;
            this.ribbonButtonRedo.Text = "Вернуть";
            this.ribbonButtonRedo.Click += new System.EventHandler(this.ribbonButtonRedo_Click);
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.DropDownWidth = System.Windows.Forms.RibbonSeparatorDropDownWidth.Partial;
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemNew);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemOpen);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemSave);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemSettings);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemExit);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 295);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = global::VeNote.Properties.Resources.logo;
            this.ribbon1.OrbText = "Меню";
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.DropDownButtonVisible = false;
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButtonNew);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButtonSave);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButtonOpen);
            this.ribbon1.QuickAccessToolbar.Text = "";
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(531, 140);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonOrbMenuItemNew
            // 
            this.ribbonOrbMenuItemNew.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemNew.Image = global::VeNote.Properties.Resources.default_document3232;
            this.ribbonOrbMenuItemNew.LargeImage = global::VeNote.Properties.Resources.default_document3232;
            this.ribbonOrbMenuItemNew.Name = "ribbonOrbMenuItemNew";
            this.ribbonOrbMenuItemNew.SmallImage = global::VeNote.Properties.Resources.default_document3232;
            this.ribbonOrbMenuItemNew.Text = "Новый документ";
            this.ribbonOrbMenuItemNew.Click += new System.EventHandler(this.ribbonButtonNew_Click);
            // 
            // ribbonOrbMenuItemOpen
            // 
            this.ribbonOrbMenuItemOpen.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemOpen.Image = global::VeNote.Properties.Resources.folderopened_yellow;
            this.ribbonOrbMenuItemOpen.LargeImage = global::VeNote.Properties.Resources.folderopened_yellow;
            this.ribbonOrbMenuItemOpen.Name = "ribbonOrbMenuItemOpen";
            this.ribbonOrbMenuItemOpen.SmallImage = global::VeNote.Properties.Resources.folderopened_yellow;
            this.ribbonOrbMenuItemOpen.Text = "Открыть";
            this.ribbonOrbMenuItemOpen.Click += new System.EventHandler(this.ribbonButtonOpen_Click);
            // 
            // ribbonOrbMenuItemSave
            // 
            this.ribbonOrbMenuItemSave.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemSave.Image = global::VeNote.Properties.Resources.save;
            this.ribbonOrbMenuItemSave.LargeImage = global::VeNote.Properties.Resources.save;
            this.ribbonOrbMenuItemSave.Name = "ribbonOrbMenuItemSave";
            this.ribbonOrbMenuItemSave.SmallImage = global::VeNote.Properties.Resources.save;
            this.ribbonOrbMenuItemSave.Text = "Сохранить";
            this.ribbonOrbMenuItemSave.Click += new System.EventHandler(this.ribbonButtonSave_Click);
            // 
            // ribbonOrbMenuItemSettings
            // 
            this.ribbonOrbMenuItemSettings.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemSettings.Image = global::VeNote.Properties.Resources.advancedsettings;
            this.ribbonOrbMenuItemSettings.LargeImage = global::VeNote.Properties.Resources.advancedsettings;
            this.ribbonOrbMenuItemSettings.Name = "ribbonOrbMenuItemSettings";
            this.ribbonOrbMenuItemSettings.SmallImage = global::VeNote.Properties.Resources.advancedsettings;
            this.ribbonOrbMenuItemSettings.Text = "Настройки";
            this.ribbonOrbMenuItemSettings.Click += new System.EventHandler(this.ribbonOrbMenuItemSettings_Click);
            // 
            // ribbonOrbMenuItemExit
            // 
            this.ribbonOrbMenuItemExit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemExit.Image = global::VeNote.Properties.Resources.exit;
            this.ribbonOrbMenuItemExit.LargeImage = global::VeNote.Properties.Resources.exit;
            this.ribbonOrbMenuItemExit.Name = "ribbonOrbMenuItemExit";
            this.ribbonOrbMenuItemExit.SmallImage = global::VeNote.Properties.Resources.exit;
            this.ribbonOrbMenuItemExit.Text = "Выход";
            this.ribbonOrbMenuItemExit.Click += new System.EventHandler(this.ribbonOrbMenuItemExit_Click);
            // 
            // ribbonButtonNew
            // 
            this.ribbonButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNew.Image")));
            this.ribbonButtonNew.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNew.LargeImage")));
            this.ribbonButtonNew.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonNew.Name = "ribbonButtonNew";
            this.ribbonButtonNew.SmallImage = global::VeNote.Properties.Resources.default_document1;
            this.ribbonButtonNew.Text = "Новый документ";
            this.ribbonButtonNew.Click += new System.EventHandler(this.ribbonButtonNew_Click);
            // 
            // ribbonButtonSave
            // 
            this.ribbonButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSave.Image")));
            this.ribbonButtonSave.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSave.LargeImage")));
            this.ribbonButtonSave.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonSave.Name = "ribbonButtonSave";
            this.ribbonButtonSave.SmallImage = global::VeNote.Properties.Resources.save16;
            this.ribbonButtonSave.Text = "Открыть";
            this.ribbonButtonSave.Click += new System.EventHandler(this.ribbonButtonSave_Click);
            // 
            // ribbonButtonOpen
            // 
            this.ribbonButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonOpen.Image")));
            this.ribbonButtonOpen.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonOpen.LargeImage")));
            this.ribbonButtonOpen.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonOpen.Name = "ribbonButtonOpen";
            this.ribbonButtonOpen.SmallImage = global::VeNote.Properties.Resources.folderopened_yellow1;
            this.ribbonButtonOpen.Text = "Открыть";
            this.ribbonButtonOpen.Click += new System.EventHandler(this.ribbonButtonOpen_Click);
            // 
            // ribbonOrbOptionButton1
            // 
            this.ribbonOrbOptionButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.Image")));
            this.ribbonOrbOptionButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.LargeImage")));
            this.ribbonOrbOptionButton1.Name = "ribbonOrbOptionButton1";
            this.ribbonOrbOptionButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.SmallImage")));
            this.ribbonOrbOptionButton1.Text = "О программе";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 357);
            this.Controls.Add(this.richTextBoxClient);
            this.Controls.Add(this.ribbon1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VeNote";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RichTextBox richTextBoxClient;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton ribbonButtonPaste;
        private System.Windows.Forms.RibbonButton ribbonButtonCopy;
        private System.Windows.Forms.RibbonButton ribbonButtonCut;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton ribbonButtonFont;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton ribbonButtonFind;
        private System.Windows.Forms.RibbonButton ribbonButtonSelectAll;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemNew;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemOpen;
        private System.Windows.Forms.RibbonOrbRecentItem ribbonOrbRecentItem1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemSave;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemSettings;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemExit;
        private System.Windows.Forms.RibbonButton ribbonButtonNew;
        private System.Windows.Forms.RibbonButton ribbonButtonSave;
        private System.Windows.Forms.RibbonButton ribbonButtonOpen;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator2;
        private System.Windows.Forms.RibbonButton ribbonButtonUndo;
        private System.Windows.Forms.RibbonButton ribbonButtonRedo;
        private System.Windows.Forms.RibbonOrbOptionButton ribbonOrbOptionButton1;
    }
}
