using BatchOutPutSQL.BaseFrm;
using BatchOutPutSQL.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Data.SQLite;

namespace BatchOutPutSQL
{
    public partial class ManageMyDbsFrm : MyBaseChildForm
    {

        private static object _lock = new object();

        private static ManageMyDbsFrm _instance;

        public static ManageMyDbsFrm GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ManageMyDbsFrm();
                }
            }
            return _instance;
        }




        private ManageMyDbsFrm()
        {
            InitializeComponent();

            ReLoadDtb();

        }


        private void ReLoadDtb()
        {
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
            dgv_All.DataSource = dt;
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Key.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入Key之后再添加");
                return;
            }
            SQLiteParameter[] parameters = new SQLiteParameter[]{ 
                                           new SQLiteParameter("@key",txt_Key.Text), 
                                           new SQLiteParameter("@value",txt_Value.Text)
                                         };
            SQLiteHelper.ExecuteNonQuery("delete from  ListTable where DicKey=@key",parameters);
            int intRes = SQLiteHelper.ExecuteNonQuery("INSERT INTO ListTable (DicKey,DicValue)Values(@key,@value) ", parameters);
            if (intRes > 0)
            {
                MessageBox.Show("添加成功");
                txt_Key.Text = "";
                txt_Value.Text = "";
                ReLoadDtb();
            }
            else
            {
                MessageBox.Show("失败");
            }
            
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            SQLiteParameter[] parameters = new SQLiteParameter[]{ 
                                           new SQLiteParameter("@key",txt_Key.Text)
                                         };
            int intRes = SQLiteHelper.ExecuteNonQuery("delete from  ListTable where DicKey=@key ", parameters);
            if (intRes > 0)
            {
                MessageBox.Show("删除成功");
                ReLoadDtb();
            }
            else
            {
                MessageBox.Show("删除失败");
            }

        }
    }
}
