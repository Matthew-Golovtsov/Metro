using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;

namespace MetroFramework
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MetroStyleManager metroStyleManager = null;
            this.StyleManager = metroStyleManager;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(metroTextBox1.Text);
            b = Convert.ToInt32(metroTextBox2.Text);
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            a = a + b;
            metroTextBox3.Text = Convert.ToString(a);
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
          
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(metroTextBox1.Text);
            b = Convert.ToInt32(metroTextBox2.Text);
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            a = a - b;
            metroTextBox3.Text = Convert.ToString(a);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(metroTextBox1.Text);
            b = Convert.ToInt32(metroTextBox2.Text);
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            a = a * b;
            metroTextBox3.Text = Convert.ToString(a);
        }
    }
}
