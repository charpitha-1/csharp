using Microsoft.Data.SqlClient;
using System.Data;
using System.Transactions;
using System.Windows.Forms;
namespace AdoTransactionDemoWin
{
    public partial class Form1 : Form
    {
        string ConnectionString = "Data Source=WKSCHE03TRNG078\\SQLEXPRESS;Initial Catalog=PayRollDB;Integrated Security=SSPI;Trust Server Certificate=True";
        DataSet ds;
        SqlDataAdapter adapter=null;
        public Form1()
        {
            InitializeComponent();
            ds = new DataSet();
            adapter = new SqlDataAdapter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //ShowEmployeeGrid();
            //ShowHistoryGrid();

        }
        private void ShowEmployeeGrid()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from EmployeeData", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            empDataGrid.DataSource = dt;
            rdr.Close();
            con.Close();
        }
        private void ShowHistoryGrid()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from LeaveHistory", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            histDataGrid.DataSource = dt;
            rdr.Close();
            con.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SqlTransaction trans = null;
            try
            {
                /*using (TransactionScope scope=new TransactionScope())
                {
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();

                    int LeaveDaysApplied = (int)leaveCount.Value;
                    SqlCommand cmd = new SqlCommand($"Insert into LeaveHistory (EmpID,ApprovedLeaves) values(1,{LeaveDaysApplied})", con);
                    cmd.Transaction = trans;
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand($"Update EmployeeData set AvailableLeaves=AvailableLeaves-{LeaveDaysApplied}where EmpID=3", con);
                    cmd2.Transaction = trans;
                    cmd2.ExecuteNonQuery();
                    scope.Complete();
                }
                */
                /*SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                trans=con.BeginTransaction();
                int LeaveDaysApplied = (int)leaveCount.Value;
                SqlCommand cmd = new SqlCommand($"Insert into LeaveHistory (EmpID,ApprovedLeaves) values(1,{LeaveDaysApplied})", con);
                cmd.Transaction = trans;
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand($"Update EmployeeData set AvailableLeaves=AvailableLeaves-{LeaveDaysApplied}where EmpID=2", con);
                cmd2.Transaction = trans;
                cmd2.ExecuteNonQuery();
                trans.Commit();
                con.Close();*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //if (trans != null)
                //{
                //    trans.Rollback();
                //}
            }
            ShowEmployeeGrid();
            ShowHistoryGrid();
        }

        private void BtnDisconnected_Click(object sender, EventArgs e)
        {

            adapter = new SqlDataAdapter("Select * from EmployeeData", ConnectionString);
            adapter.Fill(ds, "EmpData");
            if (ds.Tables["EmpData"] != null)
            {
                empDataGrid.DataSource = ds.Tables["EmpData"];
            }
        }

        private void btnChange1_Click(object sender, EventArgs e)
        {
            DataTable empTable = ds.Tables["EmpData"];
            if (empTable != null)
            {
                empTable.Rows[0][2] = 10;
            }
        }

        private void UpdateChange1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "EmpData");
        }
    }
}
