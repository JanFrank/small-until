using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Common
{
    public class ChangeToModel<T> where T : new()
    {
        public static IList<T> DataSetChangeToModel(DataTable dt)
        {

            IList<T> lss = new List<T>();


            string tempName = string.Empty;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                T view = new T();
                PropertyInfo[] pros = view.GetType().GetProperties();

                #region 用反射，将DataTable转换成Model
                foreach (PropertyInfo pi in pros)
                {
                    Type k = pi.PropertyType;

                    tempName = pi.Name;
                    ////检查DataSet里面的Table是否包含 名为TempName 的列。
                    if (dt.Columns.Contains(tempName))
                    {
                        ////判断此字段是否可写
                        if (!pi.CanWrite)
                        {
                            continue;
                        }
                        object obj_value = dr[tempName].ToString();
                        if (obj_value != DBNull.Value)
                        {
                            if (k.FullName.IndexOf("DateTime") > 0)
                            {
                                if (obj_value.ToString() != string.Empty)
                                {
                                    obj_value = Convert.ToDateTime(obj_value);
                                }
                                else
                                {
                                    obj_value = null;
                                }

                            }
                            else if (k.FullName.IndexOf("Decimal") > 0)
                            {
                                if (obj_value.ToString() != string.Empty)
                                    obj_value = Convert.ToDecimal(obj_value);
                                else
                                    obj_value = Convert.ToDecimal(0);
                            }
                            else if (k.FullName.IndexOf("Guid") > 0)
                            {
                                if (obj_value.ToString() != string.Empty)
                                    obj_value = Guid.Parse(obj_value.ToString());
                                else
                                    obj_value = null;
                            }
                            else if (k.FullName.IndexOf("Int") > 0)
                            {
                                if (obj_value.ToString() != string.Empty)
                                    obj_value = Convert.ToInt32(obj_value);
                                else
                                    obj_value = 0;
                            }
                            pi.SetValue(view, obj_value, null);

                        }
                    }
                }

                #endregion
                lss.Add(view);
            }



            return lss;
        }

        public static DataTable ToDataTable<T>(IEnumerable<T> collection)
        {
            var props = typeof(T).GetProperties();
            var dt = new DataTable();
            dt.Columns.AddRange(props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray());
            if (collection.Count() > 0)
            {
                for (int i = 0; i < collection.Count(); i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in props)
                    {
                        object obj = pi.GetValue(collection.ElementAt(i), null);
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    dt.LoadDataRow(array, true);
                }
            }
            return dt;
        }
    }


}
