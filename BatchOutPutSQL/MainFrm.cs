using BatchOutPutSQL.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace BatchOutPutSQL
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;//设置父窗体是容器
            //Son mySon = new Son();//实例化子窗体
            //mySon.MdiParent = this;//设置窗体的父子关系
            //mySon.Parent = pnl1;//设置子窗体的容器为父窗体中的Panel
            //mySon.Show();//显示子窗体，此句很重要，否则子窗体不会显示


        



        }

     
        private void 批量生成SQLDeviceFunDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatchOutPutSqlFrm frm = BatchOutPutSqlFrm.GetInstance();
            frm.MdiParent = this;
            frm.Parent = Pnl;
            frm.Show();
        }

        private void 格式化JSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JsonFormatFrm frm = JsonFormatFrm.GetInstance();
            frm.MdiParent = this;
            frm.Parent = Pnl;
            frm.Show();
        }

        private void 截取工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubStringHelperFrm frm = SubStringHelperFrm.GetInstance();
            frm.MdiParent = this;
            frm.Parent = Pnl;
            frm.Show();
        }

        private void pOSTGET文档工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostGetHelperFrm frm = PostGetHelperFrm.GetInstance();
            frm.MdiParent = this;
            frm.Parent = Pnl;
            frm.Show();
        }

        private void 取文件MD5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetFileMD5 frm = GetFileMD5.GetInstance();
            frm.MdiParent = this;
            frm.Parent = Pnl;
            frm.Show();
        }

        private void 操作自用数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMyDbsFrm frm = ManageMyDbsFrm.GetInstance();
            frm.MdiParent = this;
            frm.Parent = Pnl;
            frm.Show();
        }

        private void 生成测试用的数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestFrm frm = new TestFrm();
            frm.MdiParent = this;
            frm.Parent = Pnl;
            frm.Show();

        }

    }
}
