using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace BatchOutPutSQL
{
    public partial class JsonFormatFrm : Skin_DevExpress
    {
        private static object _lock = new object();

        private static JsonFormatFrm _instance;

        public static JsonFormatFrm GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new JsonFormatFrm();
                }
            }
            return _instance;
        }

        private JsonFormatFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text=ConvertJsonString(richTextBox1.Text);
        }


        public static string ConvertJsonString(string str)
        {
            //格式化json字符串
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }
        }

        private void JsonFormatFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _instance.Hide();
        }
    }
}
