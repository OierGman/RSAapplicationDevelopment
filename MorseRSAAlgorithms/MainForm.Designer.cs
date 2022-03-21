
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
        private void InitializeComponent()
        {
            this.mainTab = new System.Windows.Forms.TabControl();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonHardReset = new System.Windows.Forms.Button();
            this.buttonSoftReset = new System.Windows.Forms.Button();
            this.buttonEncryptDec = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncryptSym = new System.Windows.Forms.Button();
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.labelDecrypt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.labelEncrypt = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.tabPageUser1 = new System.Windows.Forms.TabPage();
            this.tabPageVoid = new System.Windows.Forms.TabPage();
            this.tabPageUser2 = new System.Windows.Forms.TabPage();
            this.labelAddKey = new System.Windows.Forms.Label();
            this.mainTab.SuspendLayout();
            this.tabPageIntro.SuspendLayout();
            this.tabControlIntroduction.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTab.Controls.Add(this.tabPageIntro);
            this.mainTab.Controls.Add(this.tabPageUser1);
            this.mainTab.Controls.Add(this.tabPageVoid);
            this.mainTab.Controls.Add(this.tabPageUser2);
            this.mainTab.Location = new System.Drawing.Point(2, 3);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(1203, 704);
            this.mainTab.TabIndex = 0;
            // 
            // tabPageIntro
            // 
            this.tabPageIntro.Controls.Add(this.tabControlIntroduction);
            this.tabPageIntro.Location = new System.Drawing.Point(4, 22);
            this.tabPageIntro.Name = "tabPageIntro";
            this.tabPageIntro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIntro.Size = new System.Drawing.Size(1195, 678);
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
            this.tabControlIntroduction.Size = new System.Drawing.Size(1186, 679);
            this.tabControlIntroduction.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelKeySelect);
            this.tabPage1.Controls.Add(this.labelexample);
            this.tabPage1.Controls.Add(this.buttonAccept);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxQ);
            this.tabPage1.Controls.Add(this.textBoxP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1178, 653);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RSA and Morse Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelKeySelect
            // 
            this.labelKeySelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKeySelect.AutoSize = true;
            this.labelKeySelect.Location = new System.Drawing.Point(17, 621);
            this.labelKeySelect.Name = "labelKeySelect";
            this.labelKeySelect.Size = new System.Drawing.Size(0, 13);
            this.labelKeySelect.TabIndex = 13;
            // 
            // labelexample
            // 
            this.labelexample.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelexample.AutoSize = true;
            this.labelexample.Location = new System.Drawing.Point(17, 545);
            this.labelexample.Name = "labelexample";
            this.labelexample.Size = new System.Drawing.Size(519, 13);
            this.labelexample.TabIndex = 12;
            this.labelexample.Text = "Some prime numbers you can select are: 11, 13, 17, 19, 23, 29, 31, 37 . . . up to" +
    " . . . 181, 191, 193, 197, 199";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAccept.Location = new System.Drawing.Point(431, 574);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(105, 23);
            this.buttonAccept.TabIndex = 11;
            this.buttonAccept.Text = "Accept Integers";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Q";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select P";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxQ.Location = new System.Drawing.Point(260, 577);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(64, 20);
            this.textBoxQ.TabIndex = 1;
            // 
            // textBoxP
            // 
            this.textBoxP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxP.Location = new System.Drawing.Point(70, 577);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(64, 20);
            this.textBoxP.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelAddKey);
            this.tabPage2.Controls.Add(this.buttonSaveFile);
            this.tabPage2.Controls.Add(this.buttonHardReset);
            this.tabPage2.Controls.Add(this.buttonSoftReset);
            this.tabPage2.Controls.Add(this.buttonEncryptDec);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.buttonDecrypt);
            this.tabPage2.Controls.Add(this.buttonEncryptSym);
            this.tabPage2.Controls.Add(this.textBoxDecrypted);
            this.tabPage2.Controls.Add(this.labelDecrypt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBoxEncrypted);
            this.tabPage2.Controls.Add(this.labelEncrypt);
            this.tabPage2.Controls.Add(this.buttonBrowse);
            this.tabPage2.Controls.Add(this.textBoxMessage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1178, 653);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Implementation of RSA and Morse Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSaveFile.Location = new System.Drawing.Point(1062, 465);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(105, 23);
            this.buttonSaveFile.TabIndex = 34;
            this.buttonSaveFile.Text = "Save File";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonHardReset
            // 
            this.buttonHardReset.Location = new System.Drawing.Point(1066, 596);
            this.buttonHardReset.Name = "buttonHardReset";
            this.buttonHardReset.Size = new System.Drawing.Size(105, 23);
            this.buttonHardReset.TabIndex = 32;
            this.buttonHardReset.Text = "Reset All";
            this.buttonHardReset.UseVisualStyleBackColor = true;
            this.buttonHardReset.Click += new System.EventHandler(this.buttonHardReset_Click);
            // 
            // buttonSoftReset
            // 
            this.buttonSoftReset.Location = new System.Drawing.Point(1066, 567);
            this.buttonSoftReset.Name = "buttonSoftReset";
            this.buttonSoftReset.Size = new System.Drawing.Size(105, 23);
            this.buttonSoftReset.TabIndex = 31;
            this.buttonSoftReset.Text = "Reset Text Box";
            this.buttonSoftReset.UseVisualStyleBackColor = true;
            this.buttonSoftReset.Click += new System.EventHandler(this.buttonSoftReset_Click);
            // 
            // buttonEncryptDec
            // 
            this.buttonEncryptDec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEncryptDec.Location = new System.Drawing.Point(1066, 151);
            this.buttonEncryptDec.Name = "buttonEncryptDec";
            this.buttonEncryptDec.Size = new System.Drawing.Size(105, 23);
            this.buttonEncryptDec.TabIndex = 30;
            this.buttonEncryptDec.Text = "Decimal Encrypt";
            this.buttonEncryptDec.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(1066, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Text To Morse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(1066, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Morse To Text";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDecrypt.Location = new System.Drawing.Point(1066, 392);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(105, 23);
            this.buttonDecrypt.TabIndex = 27;
            this.buttonDecrypt.Text = "Decrypt Text";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            // 
            // buttonEncryptSym
            // 
            this.buttonEncryptSym.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEncryptSym.Location = new System.Drawing.Point(1066, 180);
            this.buttonEncryptSym.Name = "buttonEncryptSym";
            this.buttonEncryptSym.Size = new System.Drawing.Size(105, 23);
            this.buttonEncryptSym.TabIndex = 26;
            this.buttonEncryptSym.Text = "Symbol Encrypt";
            this.buttonEncryptSym.UseVisualStyleBackColor = true;
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDecrypted.Location = new System.Drawing.Point(33, 465);
            this.textBoxDecrypted.Multiline = true;
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.Size = new System.Drawing.Size(1023, 159);
            this.textBoxDecrypted.TabIndex = 25;
            // 
            // labelDecrypt
            // 
            this.labelDecrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDecrypt.AutoSize = true;
            this.labelDecrypt.Location = new System.Drawing.Point(30, 439);
            this.labelDecrypt.Name = "labelDecrypt";
            this.labelDecrypt.Size = new System.Drawing.Size(83, 13);
            this.labelDecrypt.TabIndex = 24;
            this.labelDecrypt.Text = "Decrypted Text:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Text:";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(118, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Browse File";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEncrypted.Location = new System.Drawing.Point(33, 256);
            this.textBoxEncrypted.Multiline = true;
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.Size = new System.Drawing.Size(1023, 159);
            this.textBoxEncrypted.TabIndex = 21;
            // 
            // labelEncrypt
            // 
            this.labelEncrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEncrypt.AutoSize = true;
            this.labelEncrypt.Location = new System.Drawing.Point(30, 232);
            this.labelEncrypt.Name = "labelEncrypt";
            this.labelEncrypt.Size = new System.Drawing.Size(82, 13);
            this.labelEncrypt.TabIndex = 20;
            this.labelEncrypt.Text = "Encrypted Text:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBrowse.Location = new System.Drawing.Point(118, 15);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 17;
            this.buttonBrowse.Text = "Browse File";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMessage.Location = new System.Drawing.Point(33, 44);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(1023, 159);
            this.textBoxMessage.TabIndex = 3;
            // 
            // tabPageUser1
            // 
            this.tabPageUser1.Location = new System.Drawing.Point(4, 22);
            this.tabPageUser1.Name = "tabPageUser1";
            this.tabPageUser1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser1.Size = new System.Drawing.Size(1195, 678);
            this.tabPageUser1.TabIndex = 1;
            this.tabPageUser1.Text = "User 1";
            this.tabPageUser1.UseVisualStyleBackColor = true;
            // 
            // tabPageVoid
            // 
            this.tabPageVoid.Location = new System.Drawing.Point(4, 22);
            this.tabPageVoid.Name = "tabPageVoid";
            this.tabPageVoid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVoid.Size = new System.Drawing.Size(1195, 678);
            this.tabPageVoid.TabIndex = 2;
            this.tabPageVoid.Text = "The Void";
            this.tabPageVoid.UseVisualStyleBackColor = true;
            // 
            // tabPageUser2
            // 
            this.tabPageUser2.Location = new System.Drawing.Point(4, 22);
            this.tabPageUser2.Name = "tabPageUser2";
            this.tabPageUser2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser2.Size = new System.Drawing.Size(1195, 678);
            this.tabPageUser2.TabIndex = 3;
            this.tabPageUser2.Text = "User 2";
            this.tabPageUser2.UseVisualStyleBackColor = true;
            // 
            // labelAddKey
            // 
            this.labelAddKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddKey.AutoSize = true;
            this.labelAddKey.Location = new System.Drawing.Point(209, 20);
            this.labelAddKey.Name = "labelAddKey";
            this.labelAddKey.Size = new System.Drawing.Size(0, 13);
            this.labelAddKey.TabIndex = 35;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 711);
            this.Controls.Add(this.mainTab);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1225, 750);
            this.Name = "MainForm";
            this.Text = "Morse and RSA Algorithm TestBench";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.mainTab.ResumeLayout(false);
            this.tabPageIntro.ResumeLayout(false);
            this.tabControlIntroduction.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage tabPageIntro;
        private System.Windows.Forms.TabControl tabControlIntroduction;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPageUser1;
        private System.Windows.Forms.TabPage tabPageVoid;
        private System.Windows.Forms.TabPage tabPageUser2;
        private System.Windows.Forms.Label labelexample;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label labelKeySelect;
        private System.Windows.Forms.Button buttonEncryptDec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncryptSym;
        private System.Windows.Forms.TextBox textBoxDecrypted;
        private System.Windows.Forms.Label labelDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.Label labelEncrypt;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonHardReset;
        private System.Windows.Forms.Button buttonSoftReset;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Label labelAddKey;
    }
}

