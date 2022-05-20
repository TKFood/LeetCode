using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region

        public void LongestCommonPrefix()
        {
            string[] str = new string[] { "my", "myname", "mys" };
            string res = GetLongestCommonPrefix(str);

            MessageBox.Show(res);
        }

        private static string GetLongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            if (strs.Length == 1) return strs[0];
            var min = int.MaxValue;
            foreach (var item in strs)
            {
                if (item.Length < min)
                {
                    min = item.Length;
                }
            }
            var index = -1;
            for (int i = 0; i < min; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != strs[0][i])
                    {
                        return strs[0].Substring(0, i);
                    }
                    else
                    {
                        index = i;
                    }
                }
            }
            return strs[0].Substring(0, index + 1);
        }

        #endregion

        #region
        private void button1_Click(object sender, EventArgs e)
        {
            LongestCommonPrefix();
        }


        #endregion

    }
}
