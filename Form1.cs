using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace searchStr
{
    public partial class searchStr_home : Form
    {
        public searchStr_home()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtQuery.Text))
            {
                System.Windows.Forms.MessageBox.Show("Invalid Query");
                return;
            }
            Regex rgxExtensions = new Regex(@"[a-zA-Z0-9,]*");
            if (String.IsNullOrEmpty(txtExtensions.Text) && rgxExtensions.IsMatch(txtExtensions.Text))
            {
                System.Windows.Forms.MessageBox.Show("Invalid Extensions");
                return;
            }
            if (!Directory.Exists(txtDirectory.Text))
            {
                System.Windows.Forms.MessageBox.Show("Invalid Directory");
                return;
            }
            string strQuery = "\"" + Regex.Replace(txtQuery.Text, @"(\\+)$", @"$1$1") + "\"";
            string[] arrExtensions = txtExtensions.Text.Split(',');
            searchStr_result form2 = new searchStr_result(strQuery, arrExtensions, txtDirectory.Text, chkRegex.Checked, chkCase.Checked, chkExact.Checked);
            form2.Tag = this;
            form2.Show();
            Hide();
        }
    }
}
