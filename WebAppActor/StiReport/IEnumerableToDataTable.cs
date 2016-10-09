using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebAppActor.StiReport
{
    public class IEnumerableToDataTable<T>
    {
        public static DataTable LINQToDataTable(IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();
            PropertyInfo[] props = null;
            if (varlist == null) return dtReturn;
            foreach (T rec in varlist)
            {
                if (props == null)
                {
                    props = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in props)
                    {
                        Type colType = pi.PropertyType;
                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }
                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }
                DataRow dr = dtReturn.NewRow();
                foreach (PropertyInfo pi in props)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? null : pi.GetValue(rec, null);
                }
                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }
    }
}