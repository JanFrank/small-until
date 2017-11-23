namespace BatchOutPutSQL
{
    partial class SubStringHelperFrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RTB_Info = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBX_OneLength = new System.Windows.Forms.TextBox();
            this.RTB_Result = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_ForwardLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "分隔";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据：";
            // 
            // RTB_Info
            // 
            this.RTB_Info.Location = new System.Drawing.Point(59, 12);
            this.RTB_Info.Name = "RTB_Info";
            this.RTB_Info.Size = new System.Drawing.Size(500, 54);
            this.RTB_Info.TabIndex = 2;
            this.RTB_Info.Text = "";
            this.RTB_Info.TextChanged += new System.EventHandler(this.RTB_Info_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "每组数据长度：";
            // 
            // TBX_OneLength
            // 
            this.TBX_OneLength.Location = new System.Drawing.Point(131, 125);
            this.TBX_OneLength.Name = "TBX_OneLength";
            this.TBX_OneLength.Size = new System.Drawing.Size(100, 21);
            this.TBX_OneLength.TabIndex = 4;
            // 
            // RTB_Result
            // 
            this.RTB_Result.Location = new System.Drawing.Point(59, 167);
            this.RTB_Result.Name = "RTB_Result";
            this.RTB_Result.Size = new System.Drawing.Size(500, 352);
            this.RTB_Result.TabIndex = 5;
            this.RTB_Result.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "结果";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "去掉前面的长度：";
            // 
            // Txt_ForwardLength
            // 
            this.Txt_ForwardLength.Location = new System.Drawing.Point(131, 90);
            this.Txt_ForwardLength.Name = "Txt_ForwardLength";
            this.Txt_ForwardLength.Size = new System.Drawing.Size(100, 21);
            this.Txt_ForwardLength.TabIndex = 8;
            this.Txt_ForwardLength.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "总长度:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "0";
            // 
            // SubStringHelperFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 594);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_ForwardLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RTB_Result);
            this.Controls.Add(this.TBX_OneLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RTB_Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "SubStringHelperFrm";
            this.Text = "SplitHelperFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubStringHelperFrm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTB_Info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBX_OneLength;
        private System.Windows.Forms.RichTextBox RTB_Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_ForwardLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}