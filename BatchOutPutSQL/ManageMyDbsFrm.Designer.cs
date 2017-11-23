namespace BatchOutPutSQL
{
    partial class ManageMyDbsFrm
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_All = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Value = new System.Windows.Forms.RichTextBox();
            this.Btn_Del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(586, 272);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "添加/修改";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Key
            // 
            this.txt_Key.Location = new System.Drawing.Point(658, 53);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(289, 21);
            this.txt_Key.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "KEY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "VALUE";
            // 
            // dgv_All
            // 
            this.dgv_All.AllowUserToAddRows = false;
            this.dgv_All.AllowUserToDeleteRows = false;
            this.dgv_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.dgv_All.Location = new System.Drawing.Point(7, 37);
            this.dgv_All.Name = "dgv_All";
            this.dgv_All.ReadOnly = true;
            this.dgv_All.RowTemplate.Height = 23;
            this.dgv_All.Size = new System.Drawing.Size(545, 586);
            this.dgv_All.TabIndex = 9999;
            // 
            // Key
            // 
            this.Key.DataPropertyName = "Key";
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Width = 200;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 300;
            // 
            // txt_Value
            // 
            this.txt_Value.Location = new System.Drawing.Point(658, 107);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(289, 133);
            this.txt_Value.TabIndex = 2;
            this.txt_Value.Text = "";
            // 
            // Btn_Del
            // 
            this.Btn_Del.Location = new System.Drawing.Point(688, 272);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(75, 23);
            this.Btn_Del.TabIndex = 5;
            this.Btn_Del.Text = "删除";
            this.Btn_Del.UseVisualStyleBackColor = true;
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // ManageMyDbsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 630);
            this.Controls.Add(this.Btn_Del);
            this.Controls.Add(this.txt_Value);
            this.Controls.Add(this.dgv_All);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.btn_Add);
            this.Name = "ManageMyDbsFrm";
            this.Text = "ManageMyDbsFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_All;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.RichTextBox txt_Value;
        private System.Windows.Forms.Button Btn_Del;
    }
}