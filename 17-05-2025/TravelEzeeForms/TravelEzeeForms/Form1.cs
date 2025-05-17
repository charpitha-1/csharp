using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEzeeForms
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string email = EmailId.Text;
            string Password=Password1.Text;
            if(string.IsNullOrEmpty(email)||string.IsNullOrEmpty(Password )) {
                MessageBox.Show("Please enter the credentials");
                return;
            }
            this.Visible = false;
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Visible=true;  
        }
    }
}
