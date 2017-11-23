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
    public partial class SubStringHelperFrm : Form
    {
        private static object _lock = new object();

        private static SubStringHelperFrm _instance;

        public static SubStringHelperFrm GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new SubStringHelperFrm();
                }
            }
            return _instance;
        }
        private SubStringHelperFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RTB_Info.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入原数据");
                return;
            }
            int OneLength=0;
            if (!int.TryParse(TBX_OneLength.Text, out OneLength))
            {
                MessageBox.Show("请输入数字!");
                return;
            }
            if(OneLength==0)
            {
                MessageBox.Show("请输入每组长度！");
                return;
            }

            int ForwardLength= Convert.ToInt32( Txt_ForwardLength.Text);
            string WaitSubStr = RTB_Info.Text.Trim().Substring(ForwardLength, RTB_Info.Text.Trim().Length - ForwardLength);



            double TotalSubCount = Math.Ceiling(((double)WaitSubStr.Length / (double)OneLength)); 

            int SubCount= Convert.ToInt32(TotalSubCount);

            List<string> ResList = new List<string>();
            for (int i = 0; i < SubCount; i++)
            {
                if ((WaitSubStr.Length - i * OneLength) < OneLength)
                {
                    RTB_Result.AppendText(string.Format("Temp.Substring({0},{1})={2}\n", (i * OneLength).ToString(), (WaitSubStr.Length - i * OneLength).ToString(), WaitSubStr.Substring((i * OneLength), (WaitSubStr.Length - i * OneLength))));
                }
                else
                {
                    RTB_Result.AppendText(string.Format("Temp.Substring({0},{1})={2}\n", (i * OneLength).ToString(), (OneLength).ToString(), WaitSubStr.Substring((i * OneLength),  OneLength)));
                }
            }

            
            
        }

        private void SubStringHelperFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _instance.Hide();
        }

        private void RTB_Info_TextChanged(object sender, EventArgs e)
        {
            label6.Text= RTB_Info.Text.Trim().Length.ToString();
        }
    }
}
