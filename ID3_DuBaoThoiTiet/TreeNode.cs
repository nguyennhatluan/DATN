using System;
using System.Collections.Generic;
using System.Text;

namespace ID3_DuBaoThoiTiet
{
    public class TreeNode
    {
        public TreeNode(string name, int tableIndex, MyAttribute nodeAttribute, string edge)
        {
            Name = name;
            TableIndex = tableIndex;
            NodeAttribute = nodeAttribute;
            ChildNodes = new List<TreeNode>();
            Edge = edge;
        }

        public TreeNode(bool isleaf, string name, string edge)
        {
            IsLeaf = isleaf;
            Name = name;
            Edge = edge;
        }

        public TreeNode(bool isleaf, string name, string edge, TreeNode parentNode)
        {
            IsLeaf = isleaf;
            Name = name;
            Edge = edge;
            ParentNode = parentNode;
        }

        public string Name { get; }

        public string Edge { get; }

        public MyAttribute NodeAttribute { get; }

        public TreeNode ParentNode { get; set; }
        public List<TreeNode> ChildNodes { get; }

        public int TableIndex { get; }

        public bool IsLeaf { get; set; }

        public string Result { get; set; }
    }
}
