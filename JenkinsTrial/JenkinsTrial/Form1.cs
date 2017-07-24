using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace JenkinsTrial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtStatus.Text = ConfigurationManager.AppSettings[cmbSelectConfigKey.Text];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MathematicsOperation maths = new MathematicsOperation();
            int result = maths.Add(int.Parse(txtA.Text), int.Parse(txtB.Text));
            txtStatus.Text = result.ToString();
        }
    }
}
