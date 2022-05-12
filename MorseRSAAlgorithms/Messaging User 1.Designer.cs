
namespace MorseRSAAlgorithms
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
            this.listBoxUser1 = new System.Windows.Forms.ListBox();
            this.richTextBoxUser1 = new System.Windows.Forms.RichTextBox();
            this.buttonAddFileUser1 = new System.Windows.Forms.Button();
            this.buttonSendUser1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUser1
            // 
            this.listBoxUser1.FormattingEnabled = true;
            this.listBoxUser1.Location = new System.Drawing.Point(12, 12);
            this.listBoxUser1.Name = "listBoxUser1";
            this.listBoxUser1.Size = new System.Drawing.Size(360, 628);
            this.listBoxUser1.TabIndex = 0;
            this.listBoxUser1.SelectedIndexChanged += new System.EventHandler(this.listBoxUser1_SelectedIndexChanged);
            // 
            // richTextBoxUser1
            // 
            this.richTextBoxUser1.Location = new System.Drawing.Point(12, 650);
            this.richTextBoxUser1.MaxLength = 128;
            this.richTextBoxUser1.Name = "richTextBoxUser1";
            this.richTextBoxUser1.Size = new System.Drawing.Size(360, 40);
            this.richTextBoxUser1.TabIndex = 1;
            this.richTextBoxUser1.Text = "";
            // 
            // buttonAddFileUser1
            // 
            this.buttonAddFileUser1.Location = new System.Drawing.Point(12, 696);
            this.buttonAddFileUser1.Name = "buttonAddFileUser1";
            this.buttonAddFileUser1.Size = new System.Drawing.Size(99, 53);
            this.buttonAddFileUser1.TabIndex = 2;
            this.buttonAddFileUser1.Text = "Add File";
            this.buttonAddFileUser1.UseVisualStyleBackColor = true;
            this.buttonAddFileUser1.Click += new System.EventHandler(this.buttonAddFileUser1_Click);
            // 
            // buttonSendUser1
            // 
            this.buttonSendUser1.Location = new System.Drawing.Point(117, 696);
            this.buttonSendUser1.Name = "buttonSendUser1";
            this.buttonSendUser1.Size = new System.Drawing.Size(255, 53);
            this.buttonSendUser1.TabIndex = 3;
            this.buttonSendUser1.Text = "Send";
            this.buttonSendUser1.UseVisualStyleBackColor = true;
            this.buttonSendUser1.Click += new System.EventHandler(this.buttonSendUser1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 761);
            this.Controls.Add(this.buttonSendUser1);
            this.Controls.Add(this.buttonAddFileUser1);
            this.Controls.Add(this.richTextBoxUser1);
            this.Controls.Add(this.listBoxUser1);
            this.MaximumSize = new System.Drawing.Size(400, 800);
            this.MinimumSize = new System.Drawing.Size(400, 800);
            this.Name = "Form1";
            this.Text = "User 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUser1;
        private System.Windows.Forms.RichTextBox richTextBoxUser1;
        private System.Windows.Forms.Button buttonAddFileUser1;
        private System.Windows.Forms.Button buttonSendUser1;
    }
}