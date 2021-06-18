using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ID3_DuBaoThoiTiet
{
    public static class MainHandler
    {
        public static DataTable Data { get; set; }
        public static string Result { get; set; } = "";
        public static TreeNode CreateTree()
        {
            return Tree.Learn(Data, "");
        }
    }
}
