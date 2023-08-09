using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    public static class FuncLib
    {
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
    }
}
