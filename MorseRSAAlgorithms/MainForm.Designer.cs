
namespace MorseRSAAlgorithms
{
    partial class MainForm
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlLogs = new System.Windows.Forms.TabPage();
            this.groupBoxRSA = new System.Windows.Forms.GroupBox();
            this.listBoxRSA = new System.Windows.Forms.ListBox();
            this.groupBoxMorse = new System.Windows.Forms.GroupBox();
            this.listBoxMorse = new System.Windows.Forms.ListBox();
            this.tabPageIntro = new System.Windows.Forms.TabPage();
            this.tabControlIntroduction = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelKeySelect = new System.Windows.Forms.Label();
            this.labelexample = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxEncrypt = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMain = new System.Windows.Forms.RichTextBox();
            this.buttonOpenApp = new System.Windows.Forms.Button();
            this.labelAddKey = new System.Windows.Forms.Label();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonHardReset = new System.Windows.Forms.Button();
            this.buttonSoftReset = new System.Windows.Forms.Button();
            this.buttonEncryptDec = new System.Windows.Forms.Button();
            this.buttonToMorse = new System.Windows.Forms.Button();
            this.buttonToText = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncryptSym = new System.Windows.Forms.Button();
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.labelDecrypt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.labelEncrypt = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControlLogs.SuspendLayout();
            this.groupBoxRSA.SuspendLayout();
            this.groupBoxMorse.SuspendLayout();
            this.tabPageIntro.SuspendLayout();
            this.tabControlIntroduction.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlLogs
            // 
            this.tabControlLogs.Controls.Add(this.groupBoxRSA);
            this.tabControlLogs.Controls.Add(this.groupBoxMorse);
            this.tabControlLogs.Location = new System.Drawing.Point(4, 22);
            this.tabControlLogs.Name = "tabControlLogs";
            this.tabControlLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabControlLogs.Size = new System.Drawing.Size(1195, 683);
            this.tabControlLogs.TabIndex = 2;
            this.tabControlLogs.Text = "Messaging Logs";
            this.tabControlLogs.UseVisualStyleBackColor = true;
            // 
            // groupBoxRSA
            // 
            this.groupBoxRSA.Controls.Add(this.listBoxRSA);
            this.groupBoxRSA.Location = new System.Drawing.Point(603, 6);
            this.groupBoxRSA.Name = "groupBoxRSA";
            this.groupBoxRSA.Size = new System.Drawing.Size(589, 666);
            this.groupBoxRSA.TabIndex = 1;
            this.groupBoxRSA.TabStop = false;
            this.groupBoxRSA.Text = "RSA Message";
            // 
            // listBoxRSA
            // 
            this.listBoxRSA.FormattingEnabled = true;
            this.listBoxRSA.HorizontalScrollbar = true;
            this.listBoxRSA.Location = new System.Drawing.Point(6, 19);
            this.listBoxRSA.Name = "listBoxRSA";
            this.listBoxRSA.Size = new System.Drawing.Size(577, 641);
            this.listBoxRSA.TabIndex = 1;
            // 
            // groupBoxMorse
            // 
            this.groupBoxMorse.Controls.Add(this.listBoxMorse);
            this.groupBoxMorse.Location = new System.Drawing.Point(6, 6);
            this.groupBoxMorse.Name = "groupBoxMorse";
            this.groupBoxMorse.Size = new System.Drawing.Size(589, 666);
            this.groupBoxMorse.TabIndex = 0;
            this.groupBoxMorse.TabStop = false;
            this.groupBoxMorse.Text = "Morse Code Message";
            // 
            // listBoxMorse
            // 
            this.listBoxMorse.FormattingEnabled = true;
            this.listBoxMorse.HorizontalScrollbar = true;
            this.listBoxMorse.Location = new System.Drawing.Point(6, 19);
            this.listBoxMorse.Name = "listBoxMorse";
            this.listBoxMorse.Size = new System.Drawing.Size(577, 641);
            this.listBoxMorse.TabIndex = 0;
            // 
            // tabPageIntro
            // 
            this.tabPageIntro.Controls.Add(this.tabControlIntroduction);
            this.tabPageIntro.Location = new System.Drawing.Point(4, 22);
            this.tabPageIntro.Name = "tabPageIntro";
            this.tabPageIntro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIntro.Size = new System.Drawing.Size(1195, 683);
            this.tabPageIntro.TabIndex = 0;
            this.tabPageIntro.Text = "Introduction";
            this.tabPageIntro.UseVisualStyleBackColor = true;
            // 
            // tabControlIntroduction
            // 
            this.tabControlIntroduction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlIntroduction.Controls.Add(this.tabPage1);
            this.tabControlIntroduction.Controls.Add(this.tabPage2);
            this.tabControlIntroduction.Location = new System.Drawing.Point(3, 3);
            this.tabControlIntroduction.Name = "tabControlIntroduction";
            this.tabControlIntroduction.SelectedIndex = 0;
            this.tabControlIntroduction.Size = new System.Drawing.Size(1186, 684);
            this.tabControlIntroduction.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.labelKeySelect);
            this.tabPage1.Controls.Add(this.labelexample);
            this.tabPage1.Controls.Add(this.buttonAccept);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxQ);
            this.tabPage1.Controls.Add(this.textBoxP);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1178, 658);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RSA and Morse Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelKeySelect
            // 
            this.labelKeySelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKeySelect.AutoSize = true;
            this.labelKeySelect.Location = new System.Drawing.Point(17, 626);
            this.labelKeySelect.Name = "labelKeySelect";
            this.labelKeySelect.Size = new System.Drawing.Size(0, 13);
            this.labelKeySelect.TabIndex = 13;
            // 
            // labelexample
            // 
            this.labelexample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelexample.AutoSize = true;
            this.labelexample.Location = new System.Drawing.Point(17, 550);
            this.labelexample.Name = "labelexample";
            this.labelexample.Size = new System.Drawing.Size(519, 13);
            this.labelexample.TabIndex = 12;
            this.labelexample.Text = "Some prime numbers you can select are: 11, 13, 17, 19, 23, 29, 31, 37 . . . up to" +
    " . . . 181, 191, 193, 197, 199";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAccept.Location = new System.Drawing.Point(431, 579);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(105, 23);
            this.buttonAccept.TabIndex = 11;
            this.buttonAccept.Text = "Accept Integers";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Q";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select P";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxQ.Location = new System.Drawing.Point(260, 582);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(64, 20);
            this.textBoxQ.TabIndex = 1;
            // 
            // textBoxP
            // 
            this.textBoxP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxP.Location = new System.Drawing.Point(70, 582);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(64, 20);
            this.textBoxP.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 523);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1172, 132);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSA Setup";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBoxEncrypt);
            this.tabPage2.Controls.Add(this.richTextBoxMain);
            this.tabPage2.Controls.Add(this.buttonOpenApp);
            this.tabPage2.Controls.Add(this.labelAddKey);
            this.tabPage2.Controls.Add(this.buttonSaveFile);
            this.tabPage2.Controls.Add(this.buttonHardReset);
            this.tabPage2.Controls.Add(this.buttonSoftReset);
            this.tabPage2.Controls.Add(this.buttonEncryptDec);
            this.tabPage2.Controls.Add(this.buttonToMorse);
            this.tabPage2.Controls.Add(this.buttonToText);
            this.tabPage2.Controls.Add(this.buttonDecrypt);
            this.tabPage2.Controls.Add(this.buttonEncryptSym);
            this.tabPage2.Controls.Add(this.textBoxDecrypted);
            this.tabPage2.Controls.Add(this.labelDecrypt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.labelEncrypt);
            this.tabPage2.Controls.Add(this.buttonBrowse);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1178, 658);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Implementation of RSA and Morse Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxEncrypt
            // 
            this.richTextBoxEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxEncrypt.Location = new System.Drawing.Point(33, 259);
            this.richTextBoxEncrypt.Name = "richTextBoxEncrypt";
            this.richTextBoxEncrypt.Size = new System.Drawing.Size(1023, 159);
            this.richTextBoxEncrypt.TabIndex = 38;
            this.richTextBoxEncrypt.Text = "";
            // 
            // richTextBoxMain
            // 
            this.richTextBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxMain.Location = new System.Drawing.Point(33, 47);
            this.richTextBoxMain.Name = "richTextBoxMain";
            this.richTextBoxMain.Size = new System.Drawing.Size(1023, 159);
            this.richTextBoxMain.TabIndex = 37;
            this.richTextBoxMain.Text = "";
            // 
            // buttonOpenApp
            // 
            this.buttonOpenApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOpenApp.Location = new System.Drawing.Point(3, 630);
            this.buttonOpenApp.Name = "buttonOpenApp";
            this.buttonOpenApp.Size = new System.Drawing.Size(1172, 25);
            this.buttonOpenApp.TabIndex = 36;
            this.buttonOpenApp.Text = "Open Messaging Application";
            this.buttonOpenApp.UseVisualStyleBackColor = true;
            this.buttonOpenApp.Click += new System.EventHandler(this.buttonOpenApp_Click);
            // 
            // labelAddKey
            // 
            this.labelAddKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAddKey.AutoSize = true;
            this.labelAddKey.Location = new System.Drawing.Point(209, 23);
            this.labelAddKey.Name = "labelAddKey";
            this.labelAddKey.Size = new System.Drawing.Size(0, 13);
            this.labelAddKey.TabIndex = 35;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSaveFile.Location = new System.Drawing.Point(1062, 468);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(105, 23);
            this.buttonSaveFile.TabIndex = 34;
            this.buttonSaveFile.Text = "Save File";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonHardReset
            // 
            this.buttonHardReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonHardReset.Location = new System.Drawing.Point(1066, 599);
            this.buttonHardReset.Name = "buttonHardReset";
            this.buttonHardReset.Size = new System.Drawing.Size(105, 23);
            this.buttonHardReset.TabIndex = 32;
            this.buttonHardReset.Text = "Reset All";
            this.buttonHardReset.UseVisualStyleBackColor = true;
            this.buttonHardReset.Click += new System.EventHandler(this.buttonHardReset_Click);
            // 
            // buttonSoftReset
            // 
            this.buttonSoftReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSoftReset.Location = new System.Drawing.Point(1066, 570);
            this.buttonSoftReset.Name = "buttonSoftReset";
            this.buttonSoftReset.Size = new System.Drawing.Size(105, 23);
            this.buttonSoftReset.TabIndex = 31;
            this.buttonSoftReset.Text = "Reset Text Box";
            this.buttonSoftReset.UseVisualStyleBackColor = true;
            this.buttonSoftReset.Click += new System.EventHandler(this.buttonSoftReset_Click);
            // 
            // buttonEncryptDec
            // 
            this.buttonEncryptDec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEncryptDec.Location = new System.Drawing.Point(1066, 154);
            this.buttonEncryptDec.Name = "buttonEncryptDec";
            this.buttonEncryptDec.Size = new System.Drawing.Size(105, 23);
            this.buttonEncryptDec.TabIndex = 30;
            this.buttonEncryptDec.Text = "Decimal Encrypt";
            this.buttonEncryptDec.UseVisualStyleBackColor = true;
            this.buttonEncryptDec.Click += new System.EventHandler(this.buttonEncryptDec_Click);
            // 
            // buttonToMorse
            // 
            this.buttonToMorse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonToMorse.Location = new System.Drawing.Point(1066, 125);
            this.buttonToMorse.Name = "buttonToMorse";
            this.buttonToMorse.Size = new System.Drawing.Size(105, 23);
            this.buttonToMorse.TabIndex = 29;
            this.buttonToMorse.Text = "Text To Morse";
            this.buttonToMorse.UseVisualStyleBackColor = true;
            this.buttonToMorse.Click += new System.EventHandler(this.buttonToMorse_Click);
            // 
            // buttonToText
            // 
            this.buttonToText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonToText.Location = new System.Drawing.Point(1066, 366);
            this.buttonToText.Name = "buttonToText";
            this.buttonToText.Size = new System.Drawing.Size(105, 23);
            this.buttonToText.TabIndex = 28;
            this.buttonToText.Text = "Morse To Text";
            this.buttonToText.UseVisualStyleBackColor = true;
            this.buttonToText.Click += new System.EventHandler(this.buttonToText_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDecrypt.Location = new System.Drawing.Point(1066, 395);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(105, 23);
            this.buttonDecrypt.TabIndex = 27;
            this.buttonDecrypt.Text = "Decrypt Text";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncryptSym
            // 
            this.buttonEncryptSym.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEncryptSym.Location = new System.Drawing.Point(1066, 183);
            this.buttonEncryptSym.Name = "buttonEncryptSym";
            this.buttonEncryptSym.Size = new System.Drawing.Size(105, 23);
            this.buttonEncryptSym.TabIndex = 26;
            this.buttonEncryptSym.Text = "Symbol Encrypt";
            this.buttonEncryptSym.UseVisualStyleBackColor = true;
            this.buttonEncryptSym.Click += new System.EventHandler(this.buttonEncryptSym_Click);
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDecrypted.Location = new System.Drawing.Point(33, 468);
            this.textBoxDecrypted.Multiline = true;
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.ReadOnly = true;
            this.textBoxDecrypted.Size = new System.Drawing.Size(1023, 159);
            this.textBoxDecrypted.TabIndex = 25;
            // 
            // labelDecrypt
            // 
            this.labelDecrypt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDecrypt.AutoSize = true;
            this.labelDecrypt.Location = new System.Drawing.Point(30, 442);
            this.labelDecrypt.Name = "labelDecrypt";
            this.labelDecrypt.Size = new System.Drawing.Size(83, 13);
            this.labelDecrypt.TabIndex = 24;
            this.labelDecrypt.Text = "Decrypted Text:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Text:";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Location = new System.Drawing.Point(118, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Browse File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelEncrypt
            // 
            this.labelEncrypt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEncrypt.AutoSize = true;
            this.labelEncrypt.Location = new System.Drawing.Point(30, 235);
            this.labelEncrypt.Name = "labelEncrypt";
            this.labelEncrypt.Size = new System.Drawing.Size(82, 13);
            this.labelEncrypt.TabIndex = 20;
            this.labelEncrypt.Text = "Encrypted Text:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBrowse.Location = new System.Drawing.Point(118, 18);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 17;
            this.buttonBrowse.Text = "Browse File";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // mainTab
            // 
            this.mainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTab.Controls.Add(this.tabPageIntro);
            this.mainTab.Controls.Add(this.tabControlLogs);
            this.mainTab.Location = new System.Drawing.Point(2, 3);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(1203, 709);
            this.mainTab.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1172, 520);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "What is RSA";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(549, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(584, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "The Image is a visual example of how RSA implementation will handle the large num" +
    "bers, this application does not use any \r\nbig integer libraries.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(604, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(520, 347);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 716);
            this.Controls.Add(this.mainTab);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1225, 755);
            this.Name = "MainForm";
            this.Text = "Morse and RSA Algorithm TestBench";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlLogs.ResumeLayout(false);
            this.groupBoxRSA.ResumeLayout(false);
            this.groupBoxMorse.ResumeLayout(false);
            this.tabPageIntro.ResumeLayout(false);
            this.tabControlIntroduction.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.mainTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabControlLogs;
        private System.Windows.Forms.TabPage tabPageIntro;
        private System.Windows.Forms.TabControl tabControlIntroduction;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelKeySelect;
        private System.Windows.Forms.Label labelexample;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelAddKey;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonHardReset;
        private System.Windows.Forms.Button buttonSoftReset;
        private System.Windows.Forms.Button buttonEncryptDec;
        private System.Windows.Forms.Button buttonToMorse;
        private System.Windows.Forms.Button buttonToText;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncryptSym;
        private System.Windows.Forms.TextBox textBoxDecrypted;
        private System.Windows.Forms.Label labelDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelEncrypt;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.Button buttonOpenApp;
        private System.Windows.Forms.RichTextBox richTextBoxMain;
        private System.Windows.Forms.RichTextBox richTextBoxEncrypt;
        private System.Windows.Forms.GroupBox groupBoxRSA;
        public System.Windows.Forms.ListBox listBoxRSA;
        private System.Windows.Forms.GroupBox groupBoxMorse;
        public System.Windows.Forms.ListBox listBoxMorse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

