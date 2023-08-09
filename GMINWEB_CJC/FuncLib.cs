using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GMINWEB_Rebuild
{
    public static class FuncLib
    {
        public static DataTable GetStateAddToDataTable(this DataTable dt)
        {
            DataTable dtNew = dt.Clone();
            dtNew.Columns.Add("ROWSTATE");

            if (!dtNew.Columns.Contains("R_CRUD"))
            {
                dtNew.Columns.Add("R_CRUD");
            }

            foreach (DataRow row in dt.AsEnumerable().Where(row => row.RowState == DataRowState.Added
                || row.RowState == DataRowState.Modified
                || row.RowState == DataRowState.Deleted).ToList())
            {
                if (row.RowState == DataRowState.Deleted)
                {
                    DataRow newRow = dtNew.NewRow();
                    foreach (DataColumn column in dt.Columns)
                    {
                        newRow[column.ColumnName] = row[column.ColumnName, DataRowVersion.Original];
                    }
                    newRow["ROWSTATE"] = "DELETE";
                    newRow["R_CRUD"] = "D10";
                    dtNew.Rows.Add(newRow);
                }
                else
                {
                    DataRow newRow = dtNew.NewRow();
                    newRow.ItemArray = row.ItemArray;
                    newRow["ROWSTATE"] = (row.RowState == DataRowState.Modified) ? "UPDATE" : "INSERT";
                    newRow["R_CRUD"] = (row.RowState == DataRowState.Modified) ? "U10" : "I10";
                    dtNew.Rows.Add(newRow);

                }
            }

            dtNew = dtNew.ConvertTypeDateToString();

            return dtNew;
        }

        public static DataTable ConvertTypeDateToString(this DataTable dt)
        {
            foreach (DataColumn col in dt.Columns)
            {
                if (col.ColumnName != "RegUserId")
                {
                    if (col.DataType == typeof(DateTime))
                    {
                        dt = dt.GetDataTableColumnConvert(col.ColumnName, typeof(string));
                    }
                }
            }

            return dt;
        }

        public static DataTable GetDataTableColumnConvert(this DataTable dt, string columnName, Type type)
        {
            try
            {
                DataTable dtNew = dt.Clone();
                dtNew.Columns[columnName].DataType = type;

                foreach (DataRow row in dt.Rows)
                {
                    dtNew.ImportRow(row);
                }

                return dtNew;
            }
            catch
            {
                return dt;
            }
        }


        public static DataTable ConvertToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];

                table.Columns.Add(prop.Name, prop.PropertyType);
            }

            object[] values = new object[props.Count];

            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }

                table.Rows.Add(values);
            }
            return table;
        }

        public static string GetNullToEmpty(this object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return string.Empty;
            }
            else
            {
                return obj.ToString();
            }
        }

        public static int GetIntNullToZero(this object obj)
        {
            if (obj == null || obj == DBNull.Value || obj.ToString() == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        public static decimal GetDecimalNullToZero(this object obj)
        {
            if (obj == null || obj == DBNull.Value || obj.ToString() == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(obj);
            }
        }


        public static bool IsError(this List<ResultModel> list)
        {
            if (list.FirstOrDefault().ERR_NO != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetErrorMessages(this List<ResultModel> list)
        {
            return list.FirstOrDefault().ERR_MSG.GetNullToEmpty();
        }
    }
}
