using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BatchOutPutSQL.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using CCWin;

using BatchOutPutSQL.BaseFrm;
using System.Threading.Tasks;
using System.Threading;
using BatchOutPutSQL.Common;

namespace BatchOutPutSQL
{
    public partial class PostGetHelperFrm : MyBaseChildForm
    {
        private static object _lock = new object();

        private static PostGetHelperFrm _instance;

        public static PostGetHelperFrm GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new PostGetHelperFrm();
                }
            }
            return _instance;
        }

        

        private PostGetHelperFrm()
        {
            InitializeComponent();
            cbx_Type.SelectedIndex = 0;


            SQLiteHelper.SetConnectionString(System.Environment.CurrentDirectory + "/DBS/MyDicDb.db");

            var Param = new System.Data.SQLite.SQLiteParameter[0];
            var dt = SQLiteHelper.ExecuteQuery("select * from ListTable", Param);

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (dt.Columns[i].ColumnName == "DicKey")
                {
                    dt.Columns[i].ColumnName = "Key";
                }
                else
                {
                    dt.Columns[i].ColumnName = "Value";
                }
            }

            foreach (DataRow dr in dt.Rows)
            {
                if (!dic.ContainsKey(dr["Key"].ToString()))
                {
                    dic.Add(dr["Key"].ToString(), dr["Value"].ToString());
                }

            }

        }



        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //dic.Clear();

            if (Dgv_Desc.Rows.Count > 0)
            {
                for (int i = 0; i < Dgv_Desc.Rows.Count; i++)
                {
                    if (i == Dgv_Desc.Rows.Count - 1)
                    {
                        break;
                    }
                    var dr = Dgv_Desc.Rows[i];
                    if (dr.Cells.Count > 0)
                    {
                        if (dr.Cells[0].Value != null && dr.Cells[1].Value != null)
                        {
                            if (!dic.ContainsKey(dr.Cells[0].Value.ToString().Trim()))
                            {
                                dic.Add(dr.Cells[0].Value.ToString().Trim(), dr.Cells[1].Value.ToString().Trim());
                            }
                            else
                            {
                                dic[dr.Cells[0].Value.ToString().Trim()] = dr.Cells[1].Value.ToString().Trim();
                            }
                        }
                    }
                }
            }
            else
            {
                //dic.Clear();
            }

            List<string> htmlFormatList = new List<string>();
            string Url = textBox1.Text;//$htmlformat[1]

            StringBuilder PostJsonDescHtmlSb = new StringBuilder();
            string PostJson = "";
            if (!string.IsNullOrEmpty(richPostData.Text.Trim()))
            {
                PostJson = richPostData.Text.Trim();

                var obj = JsonConvert.DeserializeObject<JObject>(PostJson);
                PostJson = FunHelper.ConvertJsonString(PostJson);
                string html = "";
                PostJsonDescHtmlSb.Append(GetJObjHtml(html, obj));
            }
            //else
            //{
            //}
            int QuestionIndex = textBox1.Text.IndexOf('?');
            if (QuestionIndex > 0)
            {
                var ParamLss = GetUrlParam(Url);
                Url = textBox1.Text.Substring(0, QuestionIndex);
                PostJsonDescHtmlSb.Append(GetParamHtml(ParamLss));
            }


            htmlFormatList.Add(Txt_Title.Text);//接口名称//$htmlformat[0]
            htmlFormatList.Add(Url);//$htmlformat[1]
            htmlFormatList.Add(cbx_Type.SelectedItem.ToString()); //$htmlformat[2]
            htmlFormatList.Add(rtb_Desc.Text.Trim());//$htmlformat[3]

            htmlFormatList.Add(PostJson);//$htmlformat[4]

            htmlFormatList.Add(PostJsonDescHtmlSb.ToString()); //$htmlformat[5]

            htmlFormatList.Add(FunHelper.ConvertJsonString(Rtb_Response.Text.Trim())); //返回的JSON//$htmlformat[6]

            string TempHtml = Rtb_Response.Text.Trim();
            var TempObj = JsonConvert.DeserializeObject<JObject>(TempHtml);
            if (TempObj == null)
            {
                htmlFormatList.Add(""); //返回的JSON描述$htmlformat[7]
            }
            else
            {
                TempHtml = "";
                htmlFormatList.Add(GetJObjHtml(TempHtml, TempObj, true)); //返回的JSON描述$htmlformat[7]
            }


            WriteFile(htmlFormatList);

        }




        public void WriteFile(List<string> lss)
        {
            //---------------------读html模板页面到stringbuilder对象里---- 
            var format = lss.ToArray();

            string Path = AppDomain.CurrentDomain.BaseDirectory;
            StringBuilder htmltext = new StringBuilder();
            try
            {
                using (StreamReader sr = new StreamReader(Path + "/HtmlTemplate/template.html")) //模板页路径
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        htmltext.Append(line);
                    }
                    sr.Close();
                }
            }
            catch
            {
                MessageBox.Show("读取文件失败");
                return;
            }


            for (int i = 0; i < format.Length; i++)
            {
                htmltext.Replace("$htmlformat[" + i + "]", format[i]);
            }



            //----------生成htm文件------------------―― 
            try
            {
                if (format.Length > 0)
                {
                    using (StreamWriter sw = new StreamWriter(Path + "/HtmlTemplate/" + format[0] + ".htm", false, System.Text.Encoding.GetEncoding("GB2312"))) //保存地址
                    {
                        sw.WriteLine(htmltext);
                        sw.Flush();
                        sw.Close();

                    }
                }

            }
            catch
            {
                MessageBox.Show("输出失败");
            }
        }


        private List<string> GetUrlParam(string url)
        {
            List<string> lss = new List<string>();
            int QuestionIndex = url.IndexOf('?');
            string TempGetJson = url.Substring(QuestionIndex, url.Length - QuestionIndex).Trim('?');

            var TempParamSplits = TempGetJson.Split(new char[1] { '&' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in TempParamSplits)
            {
                var SplitEquit = item.Split(new char[1] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                lss.Add(SplitEquit[0]);
            }
            return lss;
        }


        private string GetParamHtml(List<string> paramlss)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in paramlss)
            {
                var dicItem = dic.FirstOrDefault(c => c.Key == item);
                string Desc = "";
                if (dicItem.Key != null)
                {
                    Desc = dicItem.Value;
                }
                sb.Append("<tr>");
                sb.Append("<td>" + item + "</td>");
                sb.Append("<td>" + Desc + "</td>");
                sb.Append("<td>string</td>");
                sb.Append("<td>Y</td>");
                sb.Append("<td><input type='text' /></td>");
                sb.Append("</tr>");

            }
            return sb.ToString();
        }



        

        private static Dictionary<string, string> dic = new Dictionary<string, string>();



        private string GetJTokenHtml(string _html, JToken tk, bool isReceiveJson = false)
        {
            string Desc = "";
            if (tk.Values().Count() > 0)
            {

                foreach (JProperty item in tk[0])
                {
                    var dicItem = dic.FirstOrDefault(c => c.Key == item.Name);
                    Desc = "";
                    if (dicItem.Key != null)
                    {
                        Desc = dicItem.Value;
                    }

                    _html += "<tr>" + "<td>" + item.Name + "</td>"
                         + "<td>" + Desc + "</td>"
                         + "<td>string</td>";
                    if (!isReceiveJson)
                    {
                        _html += "<td>" + "Y" + "</td>";
                    }

                    _html += "<td>" + "<input type='text' />" + "</td>"
                      + "</tr>";
                }
            }

            return _html;
        }



        private string GetJObjHtml(string _html, JObject obj, bool isReceiveJson = false)
        {

            foreach (var item in obj)
            {
                var dicItem = dic.FirstOrDefault(c => c.Key == item.Key);
                string Desc = "";
                if (item.Value.Children().Count() > 0)
                {
                    Desc = "";
                    if (dicItem.Key != null)
                    {
                        Desc = dicItem.Value;
                    }

                    _html += "<tr>" + "<td>" + item.Key + "</td>"
                      + "<td>" + Desc + "</td>"
                      + "<td>Array</td>";
                    if (!isReceiveJson)
                    {
                        _html += "<td>" + "Y" + "</td>";
                    }

                    _html += "<td>" + "<input type='text' />" + "</td>"
                      + "</tr>";
                    string TempHtml = "";
                    if (item.Value.HasValues)
                    {

                        if (item.Value.GetType() == typeof(Newtonsoft.Json.Linq.JArray))
                        {
                            foreach (JProperty jprop in item.Value[0])
                            {
                                TempHtml = "";
                                TempHtml = NoEndLessFunc(TempHtml, jprop, isReceiveJson);
                                _html += TempHtml;
                            }
                        }
                        else
                        {
                            string TempHtml2 = "";
                            _html+=GetJObjHtml(TempHtml2,item.Value as JObject,isReceiveJson);
                        }

                       
                    }
                    //_html += TempHtml;
                }
                else
                {
                    if (dicItem.Key != null)
                    {
                        Desc = dicItem.Value;
                    }
                    _html += "<tr>" + "<td>" + item.Key + "</td>"
                         + "<td>" + Desc + "</td>"
                         + "<td>" + item.Value.Type.ToString() + "</td>";
                    if (!isReceiveJson)
                    {
                        _html += "<td>" + "Y" + "</td>";
                    }


                    _html += "<td>" + "<input type='text' />" + "</td>"
                         + "</tr>";
                }
            }
            return _html;
        }




        /// <summary>
        /// 取得子节点下的所有的描述 html返回为<tr><td></td><td></td><td></td><td></td></tr>这样的
        /// </summary>
        /// <param name="_html"></param>
        /// <param name="jpr"></param>
        /// <returns></returns>
        private string NoEndLessFunc(string _html, JProperty jpr, bool IsReceiveJson = false)
        {
            var dicItem = dic.FirstOrDefault(c => c.Key == jpr.Name);
            string Desc = "";
            if (dicItem.Key != null)
            {
                Desc = dicItem.Value;
            }
            if (jpr.Children().Count() > 0)
            {
                if (jpr.HasValues)
                {
                    _html += "<tr>" + "<td>" + jpr.Name + "</td>"
                           + "<td>" + Desc + "</td>"
                           + "<td>string</td>";
                    if (!IsReceiveJson)
                    {
                        _html += "<td>" + "Y" + "</td>";
                    }

                    _html += "<td>" + "<input type='text' />" + "</td>"
                           + "</tr>";
                    if (jpr.Value is JProperty)
                    {
                        foreach (JProperty jprop in jpr.Value)
                        {
                            _html += NoEndLessFunc(_html, jprop, IsReceiveJson);
                        }
                    }
                    else
                    {
                        string TempHtml = "";
                        _html += GetJTokenHtml(TempHtml, jpr.Value, IsReceiveJson);
                    }


                }
            }
            else
            {
                _html += "<tr>" + "<td>" + jpr.Name + "</td>"
                              + "<td>" + Desc + "</td>"
                              + "<td>" + jpr.Type.ToString() + "</td>";
                if (!IsReceiveJson)
                {
                    _html += "<td>" + "Y" + "</td>";
                }


                _html += "<td>" + "<input type='text' />" + "</td>"
                          + "</tr>";
            }
            return _html;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            string httpType = cbx_Type.SelectedItem.ToString();
            if (httpType.ToLower() == "get")
            {
                string Url = textBox1.Text.ToString();
                var result = FunHelper.HttpGet(Url);
                richTextBox1.AppendText(" Request " + Url);
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText("Response " + result);
                richTextBox1.AppendText("\n");
                Rtb_Response.Text = result;
            }
            else
            {
                //post
                string Url = textBox1.Text.ToString();

                string postdata = richPostData.Text;

                System.Net.ServicePointManager.DefaultConnectionLimit = 200;

                var result = FunHelper.GetPostString(Url, postdata);

                richTextBox1.AppendText(" Request " + postdata);
                richTextBox1.AppendText("\n");

                richTextBox1.AppendText("Response " + result);
                richTextBox1.AppendText("\n");
                Rtb_Response.Text = result;
            }
        }


       




        private string GetKeyName(string Key)
        {
            string KeyName = "";
            switch (Key.ToLower())
            {
                case "sessionid":
                    {
                        KeyName = "用户sessionID";
                        break;
                    }
                case "errcode":
                    {
                        KeyName = "错误编号(为0时，则为正常请求)";
                        break;
                    }
                case "errmsg":
                    {
                        KeyName = "错误描述";
                        break;
                    }
                case "error":
                    {
                        KeyName = "错误";
                        break;
                    }
                case "content":
                    {
                        KeyName = "集合";
                        break;
                    }
                case "hostid":
                    {
                        KeyName = "主机ID";
                        break;
                    }
                case "lss":
                    {
                        KeyName = "数据集";
                        break;
                    }

                case "sceneid":
                case "scenecode":
                    {
                        KeyName = "情景ID";
                        break;
                    }
                case "name":
                    {
                        KeyName = "名称";
                        break;
                    }
                case "devname":
                case "devicename":
                    {
                        KeyName = "设备名称";
                        break;
                    }
                case "deviceid":
                case "devid":
                    {
                        KeyName = "设备ID";
                        break;
                    }

                case "taskid":
                case "taskcode":
                    {
                        KeyName = "联动ID";
                        break;
                    }
                case "taskname":
                    {
                        KeyName = "联动名称";
                        break;
                    }
                case "settype":
                    {
                        KeyName = "设置类型";
                        break;
                    }
                case "piccode":
                case "imgcode":
                    {
                        KeyName = "图片编号";
                        break;
                    }
                case "loccode":
                case "locationcode":
                case "parentareacode":
                    {
                        KeyName = "主区域编号";
                        break;
                    }
                case "locname":
                case "locationname":
                case "parentareaname":
                    {
                        KeyName = "主区域名称";
                        break;
                    }
                case "childareacode":
                case "areacode":
                    {
                        KeyName = "子区域编号";
                        break;
                    }
                case "childareaname":
                case "areaname":
                    {
                        KeyName = "子区域名称";
                        break;
                    }
                case "newname":
                    {
                        KeyName = "新名称";
                        break;
                    }
                case "token":
                    {
                        KeyName = "设备TOKEN";
                        break;
                    }
                case "typecode":
                case "devtype":
                    {
                        KeyName = "类型";
                        break;
                    }
                case "state":
                    {
                        KeyName = "状态";
                        break;
                    }
                case "scenelist":
                    {
                        KeyName = "情景列表";
                        break;
                    }
                case "tasklist":
                    {
                        KeyName = "操作集合";
                        break;
                    }
                default:
                    break;
            }
            return KeyName;
        }


        private void Dgv_Desc_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyValue == Convert.ToInt32(Keys.V))
            {
                string pastTest = Clipboard.GetText();
                if (string.IsNullOrEmpty(pastTest)) return;
                string[] row = pastTest.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < row.Length; i++)
                {
                    string[] key_value = row[i].Split('\t');
                    this.Dgv_Desc.Rows.Add(key_value);
                }
            }

        }

      

    }
}
