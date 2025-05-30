// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using System.Data;
Console.WriteLine("Hello, World!");
string ConnectionString = "Data Source=WKSCHE03TRNG078\\SQLEXPRESS;Initial Catalog=BlogAppDel;Integrated Security=SSPI;Trust Server Certificate=True";
DataSet ds = new DataSet();
SqlDataAdapter adapter1 = new SqlDataAdapter("Select * from BlogPost",ConnectionString);
adapter1.Fill(ds, "BlogP");
SqlDataAdapter adapter2 = new SqlDataAdapter("Select * from BlogComment", ConnectionString);
adapter2.Fill(ds, "BlogC");
//Data in xml
/*string xmlDataPost=ds.GetXml();
Console.WriteLine(xmlDataPost);
SqlDataAdapter adapter2 = new SqlDataAdapter("Select * from BlogComment", ConnectionString);
adapter2.Fill(ds,"BlogC");
string xmlDataComment = ds.GetXml();
Console.WriteLine(xmlDataComment);
//Adding newrow to commments
DataTable dtComm = ds.Tables["BlogC"];
DataRow drNewcomm = dtComm.NewRow();
drNewcomm[1] = 1;
drNewcomm[2] = "first Comment";
drNewcomm[3] = "First comment text";
drNewcomm[4] = "mary";
dtComm.Rows.Add(drNewcomm);
SqlCommandBuilder builder = new SqlCommandBuilder(adapter2);
adapter2.Update(ds, "BlogC");*/

//RelationShip
/*var ParentColumn = ds.Tables["BlogP"].Columns[0];//blogPost Id column
var ChildColumn = ds.Tables["Blogc"].Columns[1];//post id cloumn of comment table
ds.Relations.Add("Rel1", ParentColumn, ChildColumn,false);
var dataRelations = ds.Relations;
foreach (var rel in dataRelations)
{
    Console.WriteLine("No.Of Relations--->"+rel.ToString());
}
DataTable dtBp = ds.Tables["BlogP"];
DataTable dtBc = ds.Tables["BlogC"];
foreach (DataRow row in dtBp.Rows)
{
    Console.WriteLine("Blog Title---" + row[1]);
    DataRow[] commentrows = row.GetChildRows("Rel1");
    Console.WriteLine("Comments on BlogPost");
    foreach(DataRow comm in commentrows)
    {
        Console.WriteLine(comm["Title"]);
    }
    Console.WriteLine("--------");
}*/


DataTable dtPost=ds.Tables[0]; //BlogPost table index is 0
DataTable dtComment=ds.Tables[1]; //index is 2
DataColumn[] dcPrmColumnArr = dtPost.PrimaryKey;

DataColumn[] dcColArr = { dtPost.Columns[0] };
dtPost.PrimaryKey = dcColArr;
foreach (DataColumn dr in dcColArr)
{
    Console.WriteLine(dr.ColumnName);
}

/*List<DataColumn> colList = new List<DataColumn>();
colList.Add(dtPost.Columns[0]);
dtPost.PrimaryKey=colList.ToArray();*/

Console.WriteLine("No.Of Constraints-->"+dtPost.Constraints.Count);
ForeignKeyConstraint fk = new ForeignKeyConstraint("FK_Bp_BC", dtPost.Columns[0], dtComment.Columns[1]);
dtComment.Constraints.Add(fk);

while(true) {
    Console.WriteLine("1:AddNew Post,Add New Comment 3:Update Database");
    int option = int.Parse(Console.ReadLine());
    switch (option)
    {
        case 1:
            dtPost.Constraints.Clear();
            Console.WriteLine("Enter PostId:");
            int PostID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Title:");
            string Title = Console.ReadLine();
            Console.WriteLine("Enter Post Text:");
            string PostText = Console.ReadLine();
            Console.WriteLine("Enter PostedBy:");
            string PostedBy = Console.ReadLine();
            DataRow newrow = dtPost.NewRow();
            newrow[0] = PostID;
            newrow[1] = Title;
            newrow[2] =PostText;
            newrow[3] = PostedBy;
            dtPost.Rows.Add(newrow);
            break;

        case 2:
            Console.WriteLine();
            break;

        case 3:
           //SqlDataAdapter adp = new SqlDataAdapter();
            adapter1.Update(dtPost);
            break;

         case 4:
            Console.WriteLine("Bolg Post Rows");
            break;
        default:
            Console.WriteLine("Choose correct option");
            break;
    }
}





DataTable dtComm = ds.Tables["BlogC"];
DataRow drNewcomm = dtComm.NewRow();
drNewcomm[1] = 2;
drNewcomm[2] = "services3";
drNewcomm[3] = "performance3";
drNewcomm[4] = "charpitha3";
dtComm.Rows.Add(drNewcomm);
SqlCommandBuilder builder = new SqlCommandBuilder(adapter2);
adapter2.Update(ds, "BlogC");