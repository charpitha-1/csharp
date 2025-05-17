using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string SrvTypeName=ServiceTypeName.Text;
            MessageBox.Show(SrvTypeName); //get
            ServiceTypeName.Text = ""; //set
            string SelVal=comboBox1.SelectedItem.ToString();
            MessageBox.Show(SelVal);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelVal = comboBox1.SelectedItem.ToString();
            DropLoc.Items.Clear();
            switch (SelVal)
            {
                case "Kurnool":
                    DropLoc.Items.Add("Dhone");
                    DropLoc.Items.Add("kodur");
                    break;
                case "Banglore":
                    DropLoc.Items.Add("Marthalli");
                    break;

            }
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taskManagementDataSet.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.taskManagementDataSet.Roles);
            // TODO: This line of code loads data into the 'visitorManagementDataSet1.Location' table. You can move, or remove it, as needed.
           
            dateTimePicker1.MinDate= DateTime.Now;
            List<Customer> list = new List<Customer>();
            //3 customer objects
            list.Add(new Customer()
            {
                Id = 101,
                Name = "John"
            });
            list.Add(new Customer()
            {
                Id = 102,
                Name = "mary"
            });
            list.Add(new Customer()
            {
                Id = 103,
                Name = "alex"
            });
            cmbCust.DataSource = list;
            //cmbCust.DisplayMember = "Name";
            List<Order> orders = new List<Order>();
            orders.Add(new Order()
                {
                Id=101,
                ItemName="briyani",
                Qty=3,
                Price=577
            }
            );
            orders.Add(new Order()
            {
                Id = 102,
                ItemName = "Idly",
                Qty = 2,
                Price = 57
            }
            );
            GridOrder.DataSource = orders;
            //GridOrder.Width=this.Width; //window width
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            DataCollection dig = new DataCollection();
            DialogResult userAction = dig.ShowDialog();
            if (userAction == DialogResult.OK)
            {
                MessageBox.Show("UserSelected Ok");
            }
            else
            {
                MessageBox.Show("UserSelected Cancel");
            }
        }

        private void cmbCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer cust = cmbCust.SelectedItem as Customer;
            if(cust != null)
            {
                MessageBox.Show("Thanks For visiting Again  "  +cust.Name);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            DialogResult res= saveFileDialog.ShowDialog();
            if(res == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog.FileName);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
