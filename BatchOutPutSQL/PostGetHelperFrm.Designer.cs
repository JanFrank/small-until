namespace BatchOutPutSQL
{
    partial class PostGetHelperFrm
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lb_url = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richPostData = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelbtn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panetop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Dgv_Desc = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rtb_Response = new System.Windows.Forms.RichTextBox();
            this.rtb_Desc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Txt_Title = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbx_Type = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelbtn.SuspendLayout();
            this.panetop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Desc)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(4, 799);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1474, 27);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // lb_url
            // 
            this.lb_url.AutoSize = true;
            this.lb_url.Location = new System.Drawing.Point(21, 9);
            this.lb_url.Name = "lb_url";
            this.lb_url.Size = new System.Drawing.Size(59, 12);
            this.lb_url.TabIndex = 11;
            this.lb_url.Text = "请求 URL:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(16, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1231, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "http://192.168.2.201:8001/";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(1264, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 32);
            this.button4.TabIndex = 13;
            this.button4.Text = "清除数据";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "PostData:";
            // 
            // richPostData
            // 
            this.richPostData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richPostData.Location = new System.Drawing.Point(397, 128);
            this.richPostData.Name = "richPostData";
            this.richPostData.Size = new System.Drawing.Size(850, 248);
            this.richPostData.TabIndex = 12;
            this.richPostData.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1474, 330);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            // 
            // panelbtn
            // 
            this.panelbtn.Controls.Add(this.richTextBox1);
            this.panelbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbtn.Location = new System.Drawing.Point(4, 469);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(1474, 330);
            this.panelbtn.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Response Text:";
            // 
            // panetop
            // 
            this.panetop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panetop.Controls.Add(this.label1);
            this.panetop.Controls.Add(this.label4);
            this.panetop.Controls.Add(this.Dgv_Desc);
            this.panetop.Controls.Add(this.Rtb_Response);
            this.panetop.Controls.Add(this.rtb_Desc);
            this.panetop.Controls.Add(this.label2);
            this.panetop.Controls.Add(this.Lb_Name);
            this.panetop.Controls.Add(this.Txt_Title);
            this.panetop.Controls.Add(this.button3);
            this.panetop.Controls.Add(this.cbx_Type);
            this.panetop.Controls.Add(this.button1);
            this.panetop.Controls.Add(this.button4);
            this.panetop.Controls.Add(this.label3);
            this.panetop.Controls.Add(this.richPostData);
            this.panetop.Controls.Add(this.lb_url);
            this.panetop.Controls.Add(this.textBox1);
            this.panetop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panetop.Location = new System.Drawing.Point(4, 34);
            this.panetop.Name = "panetop";
            this.panetop.Size = new System.Drawing.Size(1474, 765);
            this.panetop.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "对应的数据解释";
            // 
            // Dgv_Desc
            // 
            this.Dgv_Desc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Desc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.Dgv_Desc.Location = new System.Drawing.Point(14, 128);
            this.Dgv_Desc.Name = "Dgv_Desc";
            this.Dgv_Desc.RowTemplate.Height = 23;
            this.Dgv_Desc.Size = new System.Drawing.Size(342, 273);
            this.Dgv_Desc.TabIndex = 23;
            this.Dgv_Desc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_Desc_KeyDown);
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            this.Key.Width = 150;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 150;
            // 
            // Rtb_Response
            // 
            this.Rtb_Response.Location = new System.Drawing.Point(1334, 230);
            this.Rtb_Response.Name = "Rtb_Response";
            this.Rtb_Response.Size = new System.Drawing.Size(100, 96);
            this.Rtb_Response.TabIndex = 22;
            this.Rtb_Response.Text = "";
            // 
            // rtb_Desc
            // 
            this.rtb_Desc.Location = new System.Drawing.Point(329, 73);
            this.rtb_Desc.Name = "rtb_Desc";
            this.rtb_Desc.Size = new System.Drawing.Size(918, 21);
            this.rtb_Desc.TabIndex = 21;
            this.rtb_Desc.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "接口描述";
            // 
            // Lb_Name
            // 
            this.Lb_Name.AutoSize = true;
            this.Lb_Name.Location = new System.Drawing.Point(12, 75);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(53, 12);
            this.Lb_Name.TabIndex = 19;
            this.Lb_Name.Text = "接口名称";
            // 
            // Txt_Title
            // 
            this.Txt_Title.Location = new System.Drawing.Point(71, 72);
            this.Txt_Title.Name = "Txt_Title";
            this.Txt_Title.Size = new System.Drawing.Size(180, 21);
            this.Txt_Title.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1377, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 30);
            this.button3.TabIndex = 17;
            this.button3.Text = "请求";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbx_Type
            // 
            this.cbx_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Type.FormattingEnabled = true;
            this.cbx_Type.Items.AddRange(new object[] {
            "Post",
            "Get"});
            this.cbx_Type.Location = new System.Drawing.Point(1264, 24);
            this.cbx_Type.Name = "cbx_Type";
            this.cbx_Type.Size = new System.Drawing.Size(93, 20);
            this.cbx_Type.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1377, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "生成文档";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PostGetHelperFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 830);
            this.Controls.Add(this.panelbtn);
            this.Controls.Add(this.panetop);
            this.Controls.Add(this.splitter1);
            this.Name = "PostGetHelperFrm";
            this.Text = "PostGetHelperFrm";
            this.panelbtn.ResumeLayout(false);
            this.panetop.ResumeLayout(false);
            this.panetop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Desc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lb_url;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richPostData;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panetop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbx_Type;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Txt_Title;
        private System.Windows.Forms.RichTextBox rtb_Desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.RichTextBox Rtb_Response;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Dgv_Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}