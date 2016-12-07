using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeaponCalcMS
{
    public partial class AdditionalAttackTable : Form
    {
        int[][][] table =
        {
            /*lv 150*/
            new int[][] 
            {
                new int[] { 86, 11, 16, 21, 28, 36},
                new int[] { 119, 15, 21, 29, 38, 49},
                new int[] { 125, 15, 22, 31, 40, 52},
                new int[] { 126, 16, 22, 31, 41, 52},
                new int[] { 128, 16, 23, 31, 41, 53},
                new int[] { 153, 19, 27, 38, 49, 63},
                new int[] { 160, 20, 29, 39, 52, 66},
                new int[] { 164, 20, 29, 40, 53, 68},
                new int[] { 171, 21, 31, 42, 55, 71},
                new int[] { 175, 22, 31, 43, 56, 72},
                new int[] { 201, 25, 36, 49, 65, 83},
                new int[] { 204, 25, 36, 50, 66, 84}
            },

            /*lv 160*/
            new int[][] 
            {
                new int[] { 103, 16, 23, 32, 42, 53},
                new int[] { 143, 22, 32, 44, 58, 74},
                new int[] { 150, 23, 33, 46, 60, 78},
                new int[] { 151, 23, 34, 46, 61, 78},
                new int[] { 154, 24, 34, 47, 62, 79},
                new int[] { 184, 28, 41, 56, 74, 95},
                new int[] { 192, 30, 43, 59, 77, 99},
                new int[] { 197, 30, 44, 60, 79, 101},
                new int[] { 205, 32, 46, 63, 82, 106},
                new int[] { 210, 32, 47, 64, 84, 109},
                new int[] { 241, 37, 54, 73, 97, 124},
                new int[] { 245, 38, 54, 75, 98, 126}
            }
        };

        string[] tableName = { "파프니르(150제)", "앱솔랩스(160제)" };

        public AdditionalAttackTable()
        {
            InitializeComponent();

            SetTreeView();
        }

        public void SetTreeView()
        {
            for (int i = 0; i < table.Length; i++)
            {
                int[][] level = table[i];

                TreeNode levelTree = new TreeNode(tableName[i]);
                foreach (int[] AttackTable in level)
                {
                    TreeNode tempNode = new TreeNode(string.Format("기본공격력 : {0}", AttackTable[0]));
                    for (int j = 1; j <= 5; j++)
                    {
                        tempNode.Nodes.Add(string.Format("{0}단계 : {1}", j, AttackTable[j]));
                    }
                    levelTree.Nodes.Add(tempNode);
                }

                treeView1.Nodes.Add(levelTree);
            }
        }

        // close
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
