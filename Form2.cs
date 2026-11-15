using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLAVIOMICA_INVENTORY
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = textBox1.Text.Trim();
            string username = textBox3.Text.Trim();
            string password = textBox4.Text;
            string confirmPassword = textBox2.Text;

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Complete all registration fields.", "Registration required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.Equals(password, confirmPassword, StringComparison.Ordinal))
            {
                MessageBox.Show("The passwords do not match.", "Registration error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Clear();
                textBox2.Focus();
                return;
            }

            AccountStore.Register(username, password);
            MessageBox.Show("Your account was created. You can now sign in.", "Registration complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
