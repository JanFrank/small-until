using Newtonsoft.Json;
/*
 1: 静态函数工具类
 * 
 
 
 
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace BatchOutPutSQL.Helper
{
    class FunHelper
    {

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


        static public string GetPostString(string url, string data)
        {
            // OK 
            try
            {

                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
                myRequest.Method = "POST";
                myRequest.ContentType = "application/json";
                byte[] postBytes = Encoding.UTF8.GetBytes(data);
                myRequest.ContentLength = postBytes.Length;
                //  myRequest.Proxy = null;

                myRequest.Timeout = 1000 * 15; //30 分钟
                myRequest.KeepAlive = false;

                Stream newStream = myRequest.GetRequestStream();
                newStream.Write(postBytes, 0, postBytes.Length);
                newStream.Close();

                // Get response
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();

                using ( StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8) )
                {
                    string content = reader.ReadToEnd();
                    return content; //.Replace("\\", "");
                }

            }
            catch ( System.Exception ex )
            {
                return ex.Message;
            }
        }






        static public string HttpGet(string url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            //request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "*/*";
            request.Timeout = 1000 * 15;
            request.AllowAutoRedirect = false;

            WebResponse response = null;
            string responseStr = null;

            try
            {
                response = request.GetResponse();

                if ( response != null )
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch ( Exception ex )
            {
                return ex.Message.ToString();
            }
            finally
            {
                request = null;
                response = null;
            }

            return responseStr;
        }





        static private string GetPostStream(string url, string data)
        {
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
                myRequest.Method = "POST";
                myRequest.ContentType = "application/json";
                byte[] postBytes = Encoding.UTF8.GetBytes(data);
                myRequest.ContentLength = postBytes.Length;

                myRequest.Timeout = 1000 * 60 * 60; //30 分钟
                myRequest.KeepAlive = false;

                Stream newStream = myRequest.GetRequestStream();
                newStream.Write(postBytes, 0, postBytes.Length);
                newStream.Close();

                // Get response
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();

                using ( StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8) )
                {

                    string content = reader.ReadToEnd();
                    return content.Replace("\\", "");
                }

            }
            catch ( System.Exception ex )
            {
                return ex.Message;
            }

        }






        public static string GetDateTimeCodeLongString()
        {
            Random rd = new Random(unchecked((int)DateTime.Now.Ticks));
            int rdvalue = rd.Next(10000, 99999);
            return DateTime.Now.ToString("yyyyMMddHHmmssfff") + rdvalue.ToString();
        }





        public static string GetFileMD5(string filepath)
        {
            try
            {
                FileStream file = new FileStream(filepath, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("GetMD5HashFromFile() fail,error:" + ex.Message);
            }
        }
        




    }
}
