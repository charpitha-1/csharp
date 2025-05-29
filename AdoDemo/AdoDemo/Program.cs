using AdoDemo;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection.PortableExecutable;
Console.WriteLine("Hello, World!");
DataSet ds=new DataSet();
DataTable dt = new DataTable("Task");
ds.Tables.Add(dt);
Console.WriteLine(ds.Tables.Count);

DataTable dt2 = new DataTable("comment");
ds.Tables.Add(dt2);
Console.WriteLine(ds.Tables.Count);
//Add Columns
dt.Columns.Add("TaskId",typeof(System.Int64));
dt.Columns.Add("TaskTitle",typeof(string));

Console.WriteLine("table1 col:--->"+dt.Columns.Count);
Console.WriteLine("Table2 col--->"+dt2.Columns.Count);
Console.WriteLine("Table1:col from dataset--->"+ds.Tables["Task"].Columns.Count);
DataTable dtcur = ds.Tables["Task"];
DataRow drcur = dtcur.NewRow();
drcur["TaskId"] = 19;
drcur["TaskTitle"] = "Manager";
dtcur.Rows.Add(drcur);
dt.Rows.Add(12, "dev");
Console.WriteLine("Rows count in task table--->"+ds.Tables["Task"].Rows.Count);
Console.WriteLine("Access the row tasktitle--->"+ds.Tables[0].Rows[0][1]);



/*string ConnectionString = "Data Source=WKSCHE03TRNG078\\SQLEXPRESS;Initial Catalog=BlogAppDel;Integrated Security=SSPI;Trust Server Certificate=True";
SqlConnection connection=new SqlConnection(ConnectionString);
connection.Open();
try
{
    List<BlogPost> posts = new List<BlogPost>();
    string sqlQuery = "GetAllPosts";
    SqlCommand cmds = new SqlCommand();
    cmds.CommandText = sqlQuery;
    cmds.CommandType = CommandType.StoredProcedure;
    cmds.Connection = connection;
    SqlDataReader reader = cmds.ExecuteReader();
    if (reader.HasRows)
    {
        while (reader.Read())
        {
            long BlogID = reader.GetInt64(0);
            string BlogTitle = reader.GetString(1);
            string BlogPostText = reader.GetString(2);            //reader["PostText"].ToString(); 
            string BlogPostedBy = reader.GetString(3);            //reader[3].Tostring()
                                                                  // Console.WriteLine($"{BlogID}--{BlogTitle}-{BlogPostText}-{BlogPostedBy}");
            BlogPost b = new BlogPost();
            b.PostID = BlogID;
            b.Title = BlogTitle;
            b.PostText = BlogPostText;
            b.PostedBy = BlogPostedBy;
            posts.Add(b);

        }
    }
    else
    {
        Console.WriteLine("No records");
    }
    reader.Close();

    if (posts != null)
    {
        foreach (var bp in posts)
        {
            Console.WriteLine($"Post : {bp.Title}");
        }
    }

    BlogPost selpos = posts.FirstOrDefault(p => p.PostID == 1);
    if (selpos != null)
    {
        Console.WriteLine("Title :" + selpos.Title);
    }
    else
    {
        Console.WriteLine("No post with the id");
    }
}
catch (SqlException ex)
{
    Console.WriteLine(ex.ErrorCode);
}*/

/*string sql = "GetPostCount";
SqlCommand cmd = new SqlCommand();
cmd.CommandText = sql;
cmd.CommandType = CommandType.StoredProcedure;
cmd.Connection = connection;
//add Params
SqlParameter sqlParameter = new SqlParameter("@PostedBy", "bunny");
cmd.Parameters.Add(sqlParameter);

SqlParameter cparam = new SqlParameter();
cparam.ParameterName = "@PostCount";
cparam.DbType = DbType.Int32; 
cparam.Direction = ParameterDirection.Output;
cmd.Parameters.Add(cparam);

cmd.ExecuteNonQuery();
int count=Convert.ToInt32(cparam.Value);
Console.WriteLine($"count: {count}");*/



/*string sql = "GetPostById";
SqlCommand cmd = new SqlCommand();
cmd.CommandText = sql;
cmd.CommandType = CommandType.StoredProcedure;
cmd.Connection = connection;

//Add Params
SqlParameter IDParam = new SqlParameter("@PostId", 2);
cmd.Parameters.Add(IDParam);
SqlDataReader reader = cmd.ExecuteReader();
if (reader.HasRows)
{
    while (reader.Read())
    {
        long BlogID = reader.GetInt64(0);
        string BlogTitle = reader.GetString(1);
        string BlogPostText = reader.GetString(2);            //reader["PostText"].ToString(); 
        string BlogPostedBy = reader.GetString(3);            //reader[3].Tostring()
        Console.WriteLine($"{BlogID}--{BlogTitle}-{BlogPostText}-{BlogPostedBy}");
    }
}
else
{
    Console.WriteLine("No records");
}
reader.Close(); */

/*string sqlQuery = "GetAllPosts";
SqlCommand cmds = new SqlCommand();
cmds.CommandText = sqlQuery;
cmds.CommandType=System.Data.CommandType.StoredProcedure;
cmds.Connection = connection;
SqlDataReader reader = cmds.ExecuteReader();
if (reader.HasRows)
{
    while (reader.Read())
    {
        long BlogID = reader.GetInt64(0);
        string BlogTitle = reader.GetString(1);
        string BlogPostText = reader.GetString(2);            //reader["PostText"].ToString(); 
        string BlogPostedBy = reader.GetString(3);            //reader[3].Tostring()
        Console.WriteLine($"{BlogID}--{BlogTitle}-{BlogPostText}-{BlogPostedBy}");
    }
}
else
{
    Console.WriteLine("No records");
}
reader.Close();*/

/*string sqlQuery = "Select * from BlogPost";
SqlCommand cmd = new SqlCommand(); 
cmd.CommandText = sqlQuery;
cmd.Connection = connection;
SqlDataReader reader = cmd.ExecuteReader();
if (reader.HasRows) {
    while (reader.Read())
    {
        long BlogID = reader.GetInt64(0);
        string BlogTitle = reader.GetString(1);
        string BlogPostText = reader.GetString(2);            //reader["PostText"].ToString(); 
        string BlogPostedBy = reader.GetString(3);            //reader[3].Tostring()
        Console.WriteLine($"{BlogID}--{BlogTitle}-{BlogPostText}-{BlogPostedBy}");
    }
}
else
{
    Console.WriteLine("No records");
}
reader.Close();*/
//connection.Close();


