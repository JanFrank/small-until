using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Test2.Common;
using CCWin;

namespace BatchOutPutSQL
{
    public partial class BatchOutPutSqlFrm : Skin_DevExpress
    {

        private static object _lock = new object();

        public static BatchOutPutSqlFrm _instance = null;

        public static BatchOutPutSqlFrm GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new BatchOutPutSqlFrm();
                }
            }
            return _instance;
        }
        
        private BatchOutPutSqlFrm()
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
                    string ExcelFilePath = openFileDia.FileName;

                    var ExHp = new ExcelHelper(ExcelFilePath);
                    var dt = ExHp.ExcelToDataTable("Sheet1", true);

                    string c_DeviceTypeCode = "";
                    string c_DeviceTypeName = "";
                    string c_DeviceProCode = "";
                    string c_ProtocolName = "appollo";
                    string i_Disable = "0";
                    string i_visible = "1";

                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var dr = dt.Rows[i];
                        if (string.IsNullOrEmpty(dr["c_FunOperAddr"].ToString()) && string.IsNullOrEmpty(dr["c_FunValueCode"].ToString()) && string.IsNullOrEmpty(dr["c_FunValueAddr"].ToString()))
                        {
                            continue;
                        }

                        c_DeviceTypeName = dr["c_DeviceTypeName"].ToString();
                        c_DeviceTypeCode = dr["c_DeviceTypeCode"].ToString();
                        c_DeviceProCode = dr["c_DeviceTypeCode"].ToString();

                        sb.Append(" INSERT INTO dbo.DeviceFuncDeatil VALUES  ( ");
                        sb.AppendFormat(" '{0}','{1}','{2}','{3}','{4}',", c_DeviceTypeCode, c_DeviceTypeName, c_DeviceProCode, c_ProtocolName, dr["c_FunOperCode"].ToString());
                        sb.AppendFormat("'{0}','{1}','{2}','{3}','{4}',",
                            dr["c_FunOperName"].ToString(), dr["c_FunOperAddr"].ToString(), dr["c_FunValueCode"].ToString(), dr["c_FunValueName"].ToString(), dr["c_FunValueAddr"].ToString());
                        sb.AppendFormat("{0},{1},'{2}')  \n", i_Disable, i_visible, dr["c_Remark"].ToString());

                    }

                    var dv = dt.DefaultView;
                    var DistinctDt = dv.ToTable(true, new string[] { "c_FunOperCode", "c_FunOperName", "c_FunOperAddr" });


                    StringBuilder sb2 = new StringBuilder();
                    for (int i = 0; i < DistinctDt.Rows.Count; i++)
                    {
                        var dr = DistinctDt.Rows[i];

                        if (string.IsNullOrEmpty(dr["c_FunOperCode"].ToString()) && string.IsNullOrEmpty(dr["c_FunOperName"].ToString()) && string.IsNullOrEmpty(dr["c_FunOperAddr"].ToString()))
                        {
                            continue;
                        }

                        sb2.Append(" INSERT INTO dbo.DeviceTypeFunAttr VALUES  ( ");
                        sb2.AppendFormat(" '{0}','{1}','{2}','{3}',0,{4},'') \n",
                            c_DeviceTypeCode, dr["c_FunOperCode"].ToString(), dr["c_FunOperName"].ToString(), dr["c_FunOperAddr"].ToString(), (i + 1));
                        string TempStr2 = sb2.ToString();
                    }

                    RicTxtBox_DeviceFUncDetail.Text = sb.ToString();
                    sb.Clear();

                    RicTxtBox_DeviceTypeFunAttr.Text = sb2.ToString();
                    sb2.Clear();
                    MessageBox.Show("生成SQL完成");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //构造JSON数据
            string JsonStr = "{\"Body\":[{\"Info\":\"TestInfo\"}]}";

            string url = "http://test.insi.cn/AppServer/session/zegBeePushMsg";
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
            myRequest.Method = "POST";
            myRequest.ContentType = "application/json";
            byte[] postBytes = Encoding.UTF8.GetBytes(JsonStr);
            myRequest.ContentLength = postBytes.Length;


            myRequest.Timeout = 1000 * 10; //10秒
            myRequest.KeepAlive = true;
            Stream newStream = myRequest.GetRequestStream();
            newStream.Write(postBytes, 0, postBytes.Length);
            newStream.Close();


            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();

            using (StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8))
            {
                string content = reader.ReadToEnd();
                MessageBox.Show(content.ToString());
            }

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _instance.Hide();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDia = new OpenFileDialog();
                //文本文件(*.txt)|*.txt|所有文件(*.*)||*.*
                openFileDia.Filter = "03以下EXCEL(*.xls)|*.xls|高版本Excle(*.xlsx)|*.xlsx";

                if (openFileDia.ShowDialog() == DialogResult.OK)
                {
                    string ExcelFilePath = openFileDia.FileName;

                    var ExHp = new ExcelHelper(ExcelFilePath);
                    var dt = ExHp.ExcelToDataTable("Sheet1", true);

                    string c_DeviceTypeCode = "";
                    string c_DeviceTypeName = "";
                    string c_DeviceProCode = "";
                    string c_ProtocolName = "appollo";
                    string i_Disable = "0";
                    string i_visible = "1";

                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var dr = dt.Rows[i];
                        if (string.IsNullOrEmpty(dr["c_FunOperAddr"].ToString()) && string.IsNullOrEmpty(dr["c_FunValueCode"].ToString()) && string.IsNullOrEmpty(dr["c_FunValueAddr"].ToString()))
                        {
                            continue;
                        }

                        c_DeviceTypeName = dr["c_DeviceTypeName"].ToString();
                        c_DeviceTypeCode = dr["c_DeviceTypeCode"].ToString();
                        c_DeviceProCode = dr["c_DeviceProCode"].ToString();

                        sb.Append(" INSERT INTO dbo.DeviceFuncDeatil VALUES  ( ");
                        sb.AppendFormat(" '{0}','{1}','{2}','{3}','{4}',", c_DeviceTypeCode, c_DeviceTypeName, c_DeviceProCode, c_ProtocolName, dr["c_FunOperCode"].ToString());
                        sb.AppendFormat("'{0}','{1}','{2}','{3}','{4}',",
                            dr["c_FunOperName"].ToString(), dr["c_FunOperAddr"].ToString(), dr["c_FunValueCode"].ToString(), dr["c_FunValueName"].ToString(), dr["c_FunValueAddr"].ToString());
                        sb.AppendFormat("{0},{1},'{2}')  \n", i_Disable, i_visible, dr["c_Remark"].ToString());

                    }

                    var dv = dt.DefaultView;
                    var DistinctDt = dv.ToTable(true, new string[] { "c_FunOperCode", "c_FunOperName", "c_FunOperAddr" });


                    StringBuilder sb2 = new StringBuilder();
                    for (int i = 0; i < DistinctDt.Rows.Count; i++)
                    {
                        var dr = DistinctDt.Rows[i];

                        if (string.IsNullOrEmpty(dr["c_FunOperCode"].ToString()) && string.IsNullOrEmpty(dr["c_FunOperName"].ToString()) && string.IsNullOrEmpty(dr["c_FunOperAddr"].ToString()))
                        {
                            continue;
                        }

                        sb2.Append(" INSERT INTO dbo.DeviceTypeFunAttr VALUES  ( ");
                        sb2.AppendFormat(" '{0}','{1}','{2}','{3}',0,{4},'') \n",
                            c_DeviceTypeCode, dr["c_FunOperCode"].ToString(), dr["c_FunOperName"].ToString(), dr["c_FunOperAddr"].ToString(), (i + 1));
                        string TempStr2 = sb2.ToString();
                    }

                    RicTxtBox_DeviceFUncDetail.Text = sb.ToString();
                    sb.Clear();

                    RicTxtBox_DeviceTypeFunAttr.Text = sb2.ToString();
                    sb2.Clear();
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
