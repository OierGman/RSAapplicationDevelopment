
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
            this.tabPageUser1 = new System.Windows.Forms.TabPage();
            this.tabPageVoid = new System.Windows.Forms.TabPage();
            this.tabPageUser2 = new System.Windows.Forms.TabPage();
            this.tabControlIntroduction = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mainTab.SuspendLayout();
            this.tabPageIntro.SuspendLayout();
            this.tabControlIntroduction.SuspendLayout();
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
            this.mainTab.Size = new System.Drawing.Size(830, 527);
            this.mainTab.TabIndex = 0;
            // 
            // tabPageIntro
            // 
            this.tabPageIntro.Controls.Add(this.tabControlIntroduction);
            this.tabPageIntro.Location = new System.Drawing.Point(4, 22);
            this.tabPageIntro.Name = "tabPageIntro";
            this.tabPageIntro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIntro.Size = new System.Drawing.Size(822, 501);
            this.tabPageIntro.TabIndex = 0;
            this.tabPageIntro.Text = "Introduction";
            this.tabPageIntro.UseVisualStyleBackColor = true;
            // 
            // tabPageUser1
            // 
            this.tabPageUser1.Location = new System.Drawing.Point(4, 22);
            this.tabPageUser1.Name = "tabPageUser1";
            this.tabPageUser1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser1.Size = new System.Drawing.Size(1200, 726);
            this.tabPageUser1.TabIndex = 1;
            this.tabPageUser1.Text = "User 1";
            this.tabPageUser1.UseVisualStyleBackColor = true;
            // 
            // tabPageVoid
            // 
            this.tabPageVoid.Location = new System.Drawing.Point(4, 22);
            this.tabPageVoid.Name = "tabPageVoid";
            this.tabPageVoid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVoid.Size = new System.Drawing.Size(1200, 726);
            this.tabPageVoid.TabIndex = 2;
            this.tabPageVoid.Text = "The Void";
            this.tabPageVoid.UseVisualStyleBackColor = true;
            // 
            // tabPageUser2
            // 
            this.tabPageUser2.Location = new System.Drawing.Point(4, 22);
            this.tabPageUser2.Name = "tabPageUser2";
            this.tabPageUser2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser2.Size = new System.Drawing.Size(1200, 726);
            this.tabPageUser2.TabIndex = 3;
            this.tabPageUser2.Text = "User 2";
            this.tabPageUser2.UseVisualStyleBackColor = true;
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
            this.tabControlIntroduction.Size = new System.Drawing.Size(813, 492);
            this.tabControlIntroduction.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(805, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RSA and Morse Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1183, 691);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Implementation of RSA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 534);
            this.Controls.Add(this.mainTab);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "MainForm";
            this.Text = "Morse and RSA Algorithm TestBench";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.mainTab.ResumeLayout(false);
            this.tabPageIntro.ResumeLayout(false);
            this.tabControlIntroduction.ResumeLayout(false);
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
    }
}

