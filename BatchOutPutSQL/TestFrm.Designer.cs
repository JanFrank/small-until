namespace BatchOutPutSQL
{
    partial class TestFrm
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
            this.Btn_ChoseFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Btn_ChoseFile
            // 
            this.Btn_ChoseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ChoseFile.Location = new System.Drawing.Point(39, 29);
            this.Btn_ChoseFile.Name = "Btn_ChoseFile";
            this.Btn_ChoseFile.Size = new System.Drawing.Size(75, 23);
            this.Btn_ChoseFile.TabIndex = 1;
            this.Btn_ChoseFile.Text = "选择并上传";
            this.Btn_ChoseFile.UseVisualStyleBackColor = true;
            this.Btn_ChoseFile.Click += new System.EventHandler(this.Btn_ChoseFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(851, 360);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // TestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Btn_ChoseFile);
            this.Name = "TestFrm";
            this.Text = "TestFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ChoseFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}