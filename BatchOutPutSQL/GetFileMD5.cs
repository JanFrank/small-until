using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using BatchOutPutSQL.BaseFrm;

namespace BatchOutPutSQL
{
    public partial class GetFileMD5 : MyBaseChildForm
    {

        private static object _lock = new object();

        public static GetFileMD5 _instance = null;

        public static GetFileMD5 GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new GetFileMD5();
                }
            }
            return _instance;
        }

        private GetFileMD5()
        {
            InitializeComponent();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog openFileDia = new OpenFileDialog();
                
                openFileDia.Filter = "所有文件(*.*)|*.*";

                if (openFileDia.ShowDialog() == DialogResult.OK)
                {
                    string Temp= BatchOutPutSQL.Helper.FunHelper.GetFileMD5(openFileDia.FileName);
                    txt_MD5.Text = Temp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
            }

        }

        private void GetFileMD5_Load(object sender, EventArgs e)
        {

        }

        //private void GetFileMD5_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    e.Cancel = true;
        //    _instance.Hide();
        //}



    }
}
