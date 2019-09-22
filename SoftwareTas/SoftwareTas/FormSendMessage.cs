using SoftwareTas.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTas
{
    public partial class FormSendMessage : Form
    {
        public FormSendMessage()
        {
            InitializeComponent();
            loadData();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void loadData()
        {
            Departement departements = DataProvider.GiveCollegeData();
            treeView1.Nodes.Clear();
            TreeNode root = treeView1.Nodes.Add(departements.Name);
            root.Tag = departements;
            foreach(Departement sub in departements.SubDepartements)
            {
                TreeNode subNode = root.Nodes.Add(sub.Name);
                subNode.Tag = sub;
                foreach(Departement dpt in sub.SubDepartements){
                    TreeNode dptNode = subNode.Nodes.Add(dpt.Name);
                    dptNode.Tag = dpt;
                }
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           if(e.Node.Tag!= null)
            {
                Departement departement =(Departement) e.Node.Tag;
                treeView2.Nodes.Clear();
                foreach(Eleve eleve in departement.Eleves)
                {
                   TreeNode node= treeView2.Nodes.Add($"{eleve.Name} ");
                    if(e.Node.Checked)
                    node.Checked = true;
                    node.Tag = eleve;
                }
            }
        }

        private void btnAddElevesSelection_Click(object sender, EventArgs e)
        {
            List<TreeNode> checkedNodes = new List<TreeNode>();
            FindCheckedNodes(ref checkedNodes, treeView2.Nodes);
            //MessageBox.Show($"Coches {checkedNodes.Count} ");
            foreach(TreeNode node in checkedNodes)
            {
                Eleve eleve =(Eleve) node.Tag;
                
                treeView3.Nodes.Add(eleve.Name);
                dataGridView1.Rows.Add(eleve.Name, eleve.Surname);
            }
        }


        private void FindCheckedNodes(ref List<TreeNode> checked_nodes, TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                // Add this node.
                if (node.Checked) checked_nodes.Add(node);

                // Check the node's descendants.
                FindCheckedNodes(ref checked_nodes, node.Nodes);
            }
        }

        private List<TreeNode> CheckedNodes(TreeView trv)
        {
            List<TreeNode> checked_nodes = new List<TreeNode>();
           // FindCheckedNodes(checked_nodes, trvMeals.Nodes);
            return checked_nodes;
        }

        
        private void btnAddDptSelection_Click(object sender, EventArgs e)
        {
            List<TreeNode> checkedNodes = new List<TreeNode>();
            FindCheckedNodes(ref checkedNodes, treeView1.Nodes);
            MessageBox.Show($"Ajout departements ({checkedNodes.Count}) a la selection actuelle");
        }
    }
}
