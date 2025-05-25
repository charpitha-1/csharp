
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodDelForms.Lists;

namespace FoodDelForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataProvider.Instance.LoadData();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string email = EmailId.Text;
            string password = Password.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter the credentials");
                return;
            }
            this.Visible = false;
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Visible = true;
        }
    }
}
