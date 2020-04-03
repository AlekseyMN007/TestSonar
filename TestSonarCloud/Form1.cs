using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSonarCloud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "Hello SonarCloud" + Creater.CreateName();
            MainLabel.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "Hello SonarCloud - Test_2" + Creater.CreateName();

            MainLabel.ForeColor = Color.Aqua;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "Hello SonarCloud - Test_3" + Creater.CreateName();

            MainLabel.ForeColor = Color.Beige;
        }
    }
}
