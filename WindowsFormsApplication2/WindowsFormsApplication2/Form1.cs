using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string str = " ";

            //Checkbox1 = Japan
            if (checkBox1.Checked == true) {
                str = str + checkBox1.Text;
                str += " ";
            }

            //Checkbox2 = Philippines
            if (checkBox2.Checked == true)
            {
                str = str + checkBox1.Text;
                str += " ";
            }

            //Checkbox3 = Thailand
            if (checkBox3.Checked == true)
            {
                str = str + checkBox1.Text;
                str += " ";
            }

            //Checkbox4 = Australia
            if (checkBox4.Checked == true)
            {
                str = str + checkBox1.Text;
                str += " ";
            }

            //Checkbox5 = Others
            if (checkBox5.Checked == true)
            {
                str = str + othersTextBox.Text;
                str += " ";
            }


            if (str != null) {
                MessageBox.Show("You Selected: \n" + str + "\nThank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //others checkbox
            if (checkBox5.Checked == true) {
                othersLabel.Visible = true;
                othersTextBox.Visible = true;
            }

            else
            {
                othersLabel.Visible = false;
                othersTextBox.Visible = false;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
