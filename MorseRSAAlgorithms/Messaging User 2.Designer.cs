
namespace MorseRSAAlgorithms
{
    partial class Form2
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
            this.buttonSendUser2 = new System.Windows.Forms.Button();
            this.buttonAddFileUser2 = new System.Windows.Forms.Button();
            this.richTextBoxUser2 = new System.Windows.Forms.RichTextBox();
            this.listBoxUser2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonSendUser2
            // 
            this.buttonSendUser2.Location = new System.Drawing.Point(117, 696);
            this.buttonSendUser2.Name = "buttonSendUser2";
            this.buttonSendUser2.Size = new System.Drawing.Size(255, 53);
            this.buttonSendUser2.TabIndex = 7;
            this.buttonSendUser2.Text = "Send";
            this.buttonSendUser2.UseVisualStyleBackColor = true;
            this.buttonSendUser2.Click += new System.EventHandler(this.buttonSendUser2_Click);
            // 
            // buttonAddFileUser2
            // 
            this.buttonAddFileUser2.Location = new System.Drawing.Point(12, 696);
            this.buttonAddFileUser2.Name = "buttonAddFileUser2";
            this.buttonAddFileUser2.Size = new System.Drawing.Size(99, 53);
            this.buttonAddFileUser2.TabIndex = 6;
            this.buttonAddFileUser2.Text = "Add File";
            this.buttonAddFileUser2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxUser2
            // 
            this.richTextBoxUser2.Location = new System.Drawing.Point(12, 650);
            this.richTextBoxUser2.Name = "richTextBoxUser2";
            this.richTextBoxUser2.Size = new System.Drawing.Size(360, 40);
            this.richTextBoxUser2.TabIndex = 5;
            this.richTextBoxUser2.Text = "";
            // 
            // listBoxUser2
            // 
            this.listBoxUser2.FormattingEnabled = true;
            this.listBoxUser2.Location = new System.Drawing.Point(12, 12);
            this.listBoxUser2.Name = "listBoxUser2";
            this.listBoxUser2.Size = new System.Drawing.Size(360, 628);
            this.listBoxUser2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 761);
            this.Controls.Add(this.buttonSendUser2);
            this.Controls.Add(this.buttonAddFileUser2);
            this.Controls.Add(this.richTextBoxUser2);
            this.Controls.Add(this.listBoxUser2);
            this.MaximumSize = new System.Drawing.Size(400, 800);
            this.MinimumSize = new System.Drawing.Size(400, 800);
            this.Name = "Form2";
            this.Text = "User 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSendUser2;
        private System.Windows.Forms.Button buttonAddFileUser2;
        private System.Windows.Forms.RichTextBox richTextBoxUser2;
        private System.Windows.Forms.ListBox listBoxUser2;
    }
}