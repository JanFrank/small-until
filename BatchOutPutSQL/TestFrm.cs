using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test2.Common;

namespace BatchOutPutSQL
{
    public partial class TestFrm : Form
    {
        public TestFrm()
        {
            InitializeComponent();
        }

        private void Btn_ChoseFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDia = new OpenFileDialog();
                //文本文件(*.txt)|*.txt|所有文件(*.*)||*.*
                openFileDia.Filter = "03以下EXCEL(*.xls)|*.xls|高版本Excle(*.xlsx)|*.xlsx";

                if (openFileDia.ShowDialog() == DialogResult.OK)
                {


                    /*
                     
id	name	token	typecode

                     */
                    string ExcelFilePath = openFileDia.FileName;

                    var ExHp = new ExcelHelper(ExcelFilePath);
                    var dt = ExHp.ExcelToDataTable("Sheet1", true);


                    string c_ProtocolName = "appollo";


                    string DefaultUrl = "http://test.insi.cn/AppServer/host/action?";

                    //app=appollo&token={0}&devID={1}&devTypeID={2}&operCode={3}&operValue={4}

                    string operCode = "101";
                    string operValue1 = "Open";
                    string operValue2 = "Close";
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var dr = dt.Rows[i];

                        //dr["id"].ToString();
                        //dr["name"].ToString();
                        //dr["token"].ToString();
                        //dr["typecode"].ToString();


                        if (dr["typecode"].ToString() == "2101")
                        {
                            sb.Append("名："+dr["name"].ToString()+"开 \n");
                            sb.AppendFormat("Url:"+DefaultUrl+"app=appollo&token={0}&devID={1}&devTypeID={2}&operCode={3}&operValue={4}\n", dr["token"].ToString(), dr["id"].ToString(),"2101",operCode,operValue1);
                            sb.Append("\n");

                            sb.Append("名：" + dr["name"].ToString() + "关 \n");
                            sb.AppendFormat("Url:" + DefaultUrl + "app=appollo&token={0}&devID={1}&devTypeID={2}&operCode={3}&operValue={4}\n", dr["token"].ToString(), dr["id"].ToString(), "2101", operCode, operValue2);
                            sb.Append("\n");
                        }
                    }

                    richTextBox1.AppendText(sb.ToString());
                    
                    MessageBox.Show("生成SQL完成");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
            }
        }
    }
}
