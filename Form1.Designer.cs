
namespace FileIOAssignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            rTxtBxUnEncryptedInput = new RichTextBox();
            rTxtBxEncryptedOutput = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            btnEncrypt = new Button();
            rTxtBxEncryptedInput = new RichTextBox();
            rTxtBxDecryptOutput = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            btnDecrypt = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, saveFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(201, 34);
            openFileToolStripMenuItem.Text = "Open File...";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(201, 34);
            saveFileToolStripMenuItem.Text = "Save File...";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // rTxtBxUnEncryptedInput
            // 
            rTxtBxUnEncryptedInput.Location = new Point(18, 200);
            rTxtBxUnEncryptedInput.Name = "rTxtBxUnEncryptedInput";
            rTxtBxUnEncryptedInput.Size = new Size(408, 153);
            rTxtBxUnEncryptedInput.TabIndex = 1;
            rTxtBxUnEncryptedInput.Text = "";
            // 
            // rTxtBxEncryptedOutput
            // 
            rTxtBxEncryptedOutput.Location = new Point(501, 200);
            rTxtBxEncryptedOutput.Name = "rTxtBxEncryptedOutput";
            rTxtBxEncryptedOutput.Size = new Size(408, 153);
            rTxtBxEncryptedOutput.TabIndex = 2;
            rTxtBxEncryptedOutput.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 169);
            label1.Name = "label1";
            label1.Size = new Size(287, 25);
            label1.TabIndex = 3;
            label1.Text = "File Content (UNENCRYPTED input)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(520, 167);
            label2.Name = "label2";
            label2.Size = new Size(275, 25);
            label2.TabIndex = 4;
            label2.Text = "File Content (ENCRYPTED output)";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(416, 389);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(127, 69);
            btnEncrypt.TabIndex = 5;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += BtnEncrypt_Click;
            // 
            // rTxtBxEncryptedInput
            // 
            rTxtBxEncryptedInput.Location = new Point(18, 507);
            rTxtBxEncryptedInput.Name = "rTxtBxEncryptedInput";
            rTxtBxEncryptedInput.Size = new Size(408, 153);
            rTxtBxEncryptedInput.TabIndex = 6;
            rTxtBxEncryptedInput.Text = "";
            // 
            // rTxtBxDecryptOutput
            // 
            rTxtBxDecryptOutput.Location = new Point(501, 507);
            rTxtBxDecryptOutput.Name = "rTxtBxDecryptOutput";
            rTxtBxDecryptOutput.Size = new Size(408, 153);
            rTxtBxDecryptOutput.TabIndex = 7;
            rTxtBxDecryptOutput.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 473);
            label3.Name = "label3";
            label3.Size = new Size(262, 25);
            label3.TabIndex = 8;
            label3.Text = "File Content (ENCRYPTED input)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(524, 478);
            label4.Name = "label4";
            label4.Size = new Size(275, 25);
            label4.TabIndex = 9;
            label4.Text = "File Content (DECRYPTED output)";
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(416, 698);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(127, 69);
            btnDecrypt.TabIndex = 10;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += BtnDecrypt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 837);
            Controls.Add(btnDecrypt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rTxtBxDecryptOutput);
            Controls.Add(rTxtBxEncryptedInput);
            Controls.Add(btnEncrypt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rTxtBxEncryptedOutput);
            Controls.Add(rTxtBxUnEncryptedInput);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        public RichTextBox rTxtBxUnEncryptedInput;
        public RichTextBox rTxtBxEncryptedOutput;
        private Label label1;
        private Label label2;
        private Button btnEncrypt;
        public RichTextBox rTxtBxEncryptedInput;
        public RichTextBox rTxtBxDecryptOutput;
        private Label label3;
        private Label label4;
        private Button btnDecrypt;
    }
}
