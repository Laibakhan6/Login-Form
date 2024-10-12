using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            string correctEmail = "laibakhan12@gmail.com";
            string correctPassword = "12345";

            if (email == correctEmail && password== correctPassword)
            {
                MessageBox.Show("Login Successfull", "success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invaild emailor password. please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
