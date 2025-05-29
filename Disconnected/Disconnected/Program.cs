// See https://aka.ms/new-console-template for more information
using System.Data;
using Microsoft.Data.SqlClient;
Console.WriteLine("Hello, World!");
string ConnectionString = "Data Source=WKSCHE03TRNG078\\SQLEXPRESS;Initial Catalog=BlogAppDel;Integrated Security=SSPI;Trust Server Certificate=True";
SqlDataAdapter adapter = new SqlDataAdapter("select * from BlogPost",ConnectionString);
DataSet dataSet = new DataSet();
adapter.Fill(dataSet,"BlogPost"); //Blogpost is optional it can take the index default
if (dataSet.Tables.Count > 0)
{
    DataTable dtPosts=dataSet.Tables[0];
    if(dtPosts.Rows.Count > 0)
    {
        Console.WriteLine("Access Rows:");
        foreach (DataRow dr in dtPosts.Rows)
        {
            
            Console.WriteLine("Postid is-->"+dr["PostID"]);
        }   
    }
    /*
    //Add Row
    DataRow myrow=dtPosts.NewRow();
    myrow[1] = "Title4";
    myrow[2] = "design problem ";
    myrow[3] = "Mary";

    myrow = dtPosts.NewRow();
    myrow[1] = "Title5";
    myrow[2] = "bug problem ";
    myrow[3] = "ram";
    dtPosts.Rows.Add(myrow);*/
    //SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
    //adapter.Update(dataSet, "BlogPost");

    //update row (normally)
    /*int row =int.Parse(Console.ReadLine());
    foreach(DataRow dr in dtPosts.Rows)
    {
        if (Convert.ToInt64(dr[0])==row) //compares thetable[rowno][postid] with row [i] -->here rowno is internal
        {
            dr[1] = "modifies"; //column title with index 1
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(dataSet, "BlogPost");
            break;
        }
    }*/

    int row = int.Parse(Console.ReadLine());
    DataRow currow=dtPosts.AsEnumerable().Where(r => r.Field<long>(0) ==row).FirstOrDefault();
    if (row != null)
    {
        currow.Delete(); // for update  currow[3]="hari";
        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
        adapter.Update(dataSet, "BlogPost");
    }
}
