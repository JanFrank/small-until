namespace BatchOutPutSQL
{
    partial class GetFileMD5
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
            this.components = new System.ComponentModel.Container();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.txt_MD5 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(15, 12);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 0;
            this.skinButton1.Text = "上传文件";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // txt_MD5
            // 
            this.txt_MD5.BackColor = System.Drawing.Color.Transparent;
            this.txt_MD5.DownBack = null;
            this.txt_MD5.Icon = null;
            this.txt_MD5.IconIsButton = false;
            this.txt_MD5.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_MD5.IsPasswordChat = '\0';
            this.txt_MD5.IsSystemPasswordChar = false;
            this.txt_MD5.Lines = new string[0];
            this.txt_MD5.Location = new System.Drawing.Point(78, 53);
            this.txt_MD5.Margin = new System.Windows.Forms.Padding(0);
            this.txt_MD5.MaxLength = 32767;
            this.txt_MD5.MinimumSize = new System.Drawing.Size(28, 28);
            this.txt_MD5.MouseBack = null;
            this.txt_MD5.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_MD5.Multiline = false;
            this.txt_MD5.Name = "txt_MD5";
            this.txt_MD5.NormlBack = null;
            this.txt_MD5.Padding = new System.Windows.Forms.Padding(5);
            this.txt_MD5.ReadOnly = false;
            this.txt_MD5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_MD5.Size = new System.Drawing.Size(300, 28);
            // 
            // 
            // 
            this.txt_MD5.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MD5.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_MD5.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txt_MD5.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txt_MD5.SkinTxt.Name = "BaseText";
            this.txt_MD5.SkinTxt.Size = new System.Drawing.Size(290, 18);
            this.txt_MD5.SkinTxt.TabIndex = 0;
            this.txt_MD5.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_MD5.SkinTxt.WaterText = "";
            this.txt_MD5.TabIndex = 1;
            this.txt_MD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_MD5.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_MD5.WaterText = "";
            this.txt_MD5.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(12, 53);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(39, 17);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "MD5:";
            // 
            // GetFileMD5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 101);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.txt_MD5);
            this.Controls.Add(this.skinButton1);
            this.Name = "GetFileMD5";
            this.Text = "r";
            this.Load += new System.EventHandler(this.GetFileMD5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinTextBox txt_MD5;
        private CCWin.SkinControl.SkinLabel skinLabel1;
    }
}