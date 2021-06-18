using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace ID3_DuBaoThoiTiet
{
    public static class FileHandler
    {
        private static DataTable GetDataTable(string sql, string connectionString)
        {

            DataTable dt = new DataTable();
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    using (OleDbDataReader rdr = cmd.ExecuteReader())
                    {
                        dt.Load(rdr);
                        return dt;
                    }
                }
            }
        }

        private static DataTable GetExcel(string pPath)
        {
            string fullPathToExcel = pPath;
            string connString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=yes'", fullPathToExcel);
            var dt = GetDataTable("SELECT * from [Data$]", connString);
            return dt;
        }

        public static DataTable ImportFromCsvFile(string filePath)
        {
            var rows = 0;
            var data = GetExcel(filePath);
            return data?.Rows.Count > 0 ? data : null;
        }
    }
}
