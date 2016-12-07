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
    public partial class Form1 : Form
    {
        int[][] UpgradeTable =
        { 
            /*lv 128*/new int[] { 6, 7, 7, 8, 9 }, 
            /*lv 138*/new int[] { 7, 8, 8, 9, 10, 11, 12},
            /*lv 148*/new int[] { 8, 9, 9, 10, 11, 12, 13},
            /*lv 158*/new int[] { 9, 9, 10, 11, 12, 13, 14}
        };

        int[][] StarforceMax =
        {
            /*lv 0*/new int[] { 0, 5 },
            /*lv 95*/new int[] { 95, 8 },
            /*lv 108*/new int[] { 108, 10 },
            /*lv 118*/new int[] { 118, 15 },
            /*lv 128*/new int[] { 128, 20 },
            /*lv 138*/new int[] { 138, 25 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Level;
            int UpgradeCount;
            int BaseAttack;
            int Star;
            int AdditionalAttack;

            if (Int32.TryParse(textLevel.Text, out Level) &&
                (Int32.TryParse(textUpgrade.Text, out UpgradeCount) || radioReboot.Checked) &&
                Int32.TryParse(textBasepower.Text, out BaseAttack) &&
                Int32.TryParse(textStarforce.Text, out Star) &&
                Int32.TryParse(textAdditionalPower.Text, out AdditionalAttack))
            {
                if (radio15.Checked)
                {
                    BaseAttack += 9 * UpgradeCount;
                }
                else if (radio30.Checked)
                {
                    BaseAttack += 7 * UpgradeCount;
                }
                else if (radio70.Checked)
                {
                    BaseAttack += 5 * UpgradeCount;
                }
                else if (radio100.Checked)
                {
                    BaseAttack += 3 * UpgradeCount;
                }
                else if (radioReboot.Checked)
                {
                    //do nothing
                }
                else
                {
                    return;
                }

                if (Level < 0)
                    return;

                int sfSaver = 0;
                foreach(int[] sfMax in StarforceMax)
                {
                    if (Level < sfMax[0])
                        break;
                    sfSaver = sfMax[1];
                }

                if(Star > sfSaver)
                    Star = sfSaver;
                
                int utIndex = ((Level - 8) / 10) - 12;
                if (utIndex >= UpgradeTable.Length)
                    utIndex = UpgradeTable.Length - 1;

                for (int i = 0; i < Star; i++)
                {
                    if (i < 15)
                    {
                        BaseAttack += 1 + (BaseAttack / 50);
                    }
                    else if (i < 22)
                    {
                        BaseAttack += UpgradeTable[utIndex][i - 15];
                    }
                    else if (i < 25)
                    {
                        BaseAttack += 31;
                    }
                    else
                    {
                        return;
                    }
                }

                labelResult.Text = string.Format("{0} + {1} = {2}", BaseAttack, AdditionalAttack, BaseAttack + AdditionalAttack);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdditionalAttackTable tableForm = new AdditionalAttackTable();
            tableForm.Show();
        }
    }
}
