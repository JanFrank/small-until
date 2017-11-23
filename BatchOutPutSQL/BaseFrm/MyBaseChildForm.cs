using CCWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BatchOutPutSQL.BaseFrm
{
    public class MyBaseChildForm : Skin_DevExpress
    {
        //private static object _lock = new object();

        //private static MyBaseChildForm _instance=null;

        //public static MyBaseChildForm GetInstance()
        //{
        //    lock (_lock)
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new MyBaseChildForm();
        //        }
        //    }
        //    return _instance;
        //}


        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
