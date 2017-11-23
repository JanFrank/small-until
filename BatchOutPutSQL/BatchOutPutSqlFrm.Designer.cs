namespace BatchOutPutSQL
{
    partial class BatchOutPutSqlFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Btn_ChoseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RicTxtBox_DeviceFUncDetail = new System.Windows.Forms.RichTextBox();
            this.RicTxtBox_DeviceTypeFunAttr = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // Btn_ChoseFile
            // 
            this.Btn_ChoseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ChoseFile.Location = new System.Drawing.Point(36, 103);
            this.Btn_ChoseFile.Name = "Btn_ChoseFile";
            this.Btn_ChoseFile.Size = new System.Drawing.Size(75, 23);
            this.Btn_ChoseFile.TabIndex = 0;
            this.Btn_ChoseFile.Text = "选择并上传";
            this.Btn_ChoseFile.UseVisualStyleBackColor = true;
            this.Btn_ChoseFile.Click += new System.EventHandler(this.Btn_ChoseFile_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "DeviceFuncDeatil的SQL";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "DeviceTypeFunAttr的SQL";
            // 
            // RicTxtBox_DeviceFUncDetail
            // 
            this.RicTxtBox_DeviceFUncDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RicTxtBox_DeviceFUncDetail.Location = new System.Drawing.Point(164, 71);
            this.RicTxtBox_DeviceFUncDetail.Name = "RicTxtBox_DeviceFUncDetail";
            this.RicTxtBox_DeviceFUncDetail.Size = new System.Drawing.Size(894, 275);
            this.RicTxtBox_DeviceFUncDetail.TabIndex = 3;
            this.RicTxtBox_DeviceFUncDetail.Text = "";
            // 
            // RicTxtBox_DeviceTypeFunAttr
            // 
            this.RicTxtBox_DeviceTypeFunAttr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RicTxtBox_DeviceTypeFunAttr.Location = new System.Drawing.Point(164, 374);
            this.RicTxtBox_DeviceTypeFunAttr.Name = "RicTxtBox_DeviceTypeFunAttr";
            this.RicTxtBox_DeviceTypeFunAttr.Size = new System.Drawing.Size(894, 267);
            this.RicTxtBox_DeviceTypeFunAttr.TabIndex = 4;
            this.RicTxtBox_DeviceTypeFunAttr.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1031, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Excel表头：c_DeviceTypeCode|c_DeviceTypeName|c_DeviceProCode|c_ProtocolName|c_FunOpe" +
    "rCode|c_FunOperName|c_FunOperAddr|c_FunValueCode|c_FunValueName|c_FunValueAddr|c" +
    "_Remark";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(36, 143);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 6;
            this.skinButton1.Text = "选择并上传";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 648);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RicTxtBox_DeviceTypeFunAttr);
            this.Controls.Add(this.RicTxtBox_DeviceFUncDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_ChoseFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ChoseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RicTxtBox_DeviceFUncDetail;
        private System.Windows.Forms.RichTextBox RicTxtBox_DeviceTypeFunAttr;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinButton skinButton1;
    }
}

