using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTas
{
    public partial class TreeDepartement : UserControl
    {
        TreeNode root;
        public TreeDepartement()
        {
            InitializeComponent();
            root = treeView1.Nodes.Add("College charles de gaulles");
            for(int i =0; i< 4; i++)
            {
                TreeNode item = root.Nodes.Add($"Section numero {i}");
                for(int j =0; i<4; i++)
                {
                    TreeNode subItem = item.Nodes.Add("Sous-section " + j);
                }
            }
        }
    }
}
