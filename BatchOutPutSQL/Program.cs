using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BatchOutPutSQL
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //处理UI线程异常
            Application.ThreadException += Application_ThreadException;
            //处理未捕获的异常 
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.Automatic);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
        }


        /// <summary>
        /// 处理应用程序域内的未处理异常（非UI线程异常）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = e.ExceptionObject as Exception;

            }
            catch
            {

            }
        }

        /// <summary>
        /// 处理应用程序的未处理异常（UI线程异常）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                MessageBox.Show("我遇到了个问题，想不通，要奔溃了!");
                ////MessageBox.Show(e.Exception.Message);
                //if (e.Exception.Message.Contains("登录失败") || e.Exception.Message.Contains("error: 40"))
                //{
                //    MessageBox.Show(@"数据库远程登录失败,请检查网络链接");
                //}
                //else
                //{
                //    MessageBox.Show(@"请检查输入或文件中是否有特殊字符如：，'< > * ( ) """);
                //}

            }
            catch { }
        }
    }
}
