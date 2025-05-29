// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using SqlDemo;

Console.WriteLine("Hello, World!");
string ConnectionString = "Data Source=WKSCHE03TRNG078\\SQLEXPRESS;Initial Catalog=TaskManagement;Integrated Security=SSPI;Trust Server Certificate=True";
SqlConnection connection=new SqlConnection(ConnectionString);
connection.Open();
Console.WriteLine("Connection requested");
//string sql = "Select count(*) from UserInfo";
//SqlCommand cmd = new SqlCommand();
//cmd.CommandText = sql;
//cmd.Connection= connection;
//var res=cmd.ExecuteScalar();
//Console.WriteLine($"NO OF ROWS--{res}");
//-------------------->Dql-------------------
//string str = "select * from UserInfo";
//SqlCommand cmd = new SqlCommand();
//cmd.CommandText = str;
//cmd.Connection = connection;
//SqlDataReader read=cmd.ExecuteReader(); //Result set
//navigate the result
/*while (read.Read()) //takes one by one record
{
    //int UserId = read.GetInt32(0);
    //string UserName=read.GetString(1);
    //int RoleId=read.GetInt32(2);
    //string Email=read.GetString(3);
    //string Password = read.GetString(4);
    //int UserId = Convert.ToInt32(read["UserId"]);
    //string UserName = read["Username"].ToString();
    //Console.WriteLine($"{ UserId}----{UserName}");

    //Console.WriteLine($"{UserId}------{UserName}----{RoleId}----{Email}----{Password}");
read.Close();
}
*/
//---------------->Dml-------------
//string sq = "Update UserInfo set Password=1234 where UserName='charpitha'";
//SqlCommand cmd2 = new SqlCommand();
//cmd2.CommandText = sq;
//cmd2.Connection = connection;
//int Numofrows=cmd2.ExecuteNonQuery();
//Console.WriteLine($"Updated Rows--{Numofrows}");
//----------------->Add------------------
//string sql = "Insert into UserInfo values('thavishala',3,'char@hma.com','21334','906432211')";
//string sql2 = "delete UserInfo where UserId=3";
//Console.WriteLine("enter the id to remove");
//var Id=Console.ReadLine();
//string sql3 = "delete from EmpDetails where empid="+Id;
//string sql4 = "delete from EmpDetails where empid=@id";
//SqlCommand s = new SqlCommand(sql3,connection);
//s.Parameters.AddWithValue("@id", Id);
//int rowsadd=s.ExecuteNonQuery();
//Console.WriteLine($"norows effected:{rowsadd}");
//string d = "select * from UserInfo where RoleId=4;select * from UserInfo where UserName='charpitha' ";
//SqlCommand cmd = new SqlCommand(d,connection);
//SqlDataReader read = cmd.ExecuteReader();
//Console.WriteLine("Reading the first result-----------------1");
//while (read.Read())
//{
//    Console.WriteLine(read.GetString(1));
//}
//if (read.NextResult())
//{
//    Console.WriteLine("Reading second result---------------------2");
//    while (read.Read())
//    {
//        Console.WriteLine(read.GetString(1));
//    }
//}
//read.Close();
List<UserInfo> list = null;
list = new List<UserInfo>();

string d = "select * from UserInfo";
SqlCommand cmd = new SqlCommand(d, connection);
SqlDataReader read = cmd.ExecuteReader();

while (read.Read())
{
    Console.WriteLine("Reading the Result");
    list.Add(new UserInfo()
    {
        UserId = read.GetInt32(0),
        UserName = read.GetString(1),
        RoleId = read.GetInt32(2),
        Email = read.GetString(3),
        Password = read.GetString(4),
        Phone=read.GetString(5)
    });
}
    read.Close();
connection.Close();