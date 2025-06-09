using EFDbFirst;
using Microsoft.EntityFrameworkCore;
using System.Linq;
BlogAppDelContext con=new BlogAppDelContext();
/*var res=con.BlogPosts;//simple select
Linq Query Expression syntax
List<BlogPost> posts=(from obj in con.BlogPosts 
                    where obj.PostId<5 select obj)
                    .ToList();
List<BlogPost> blogpost=con.BlogPosts.Where(b=>b.PostId>5).ToList(); //Linq method invocation
BlogPosts from context and it is property and postid from the class of BlogPost
linq to entities
foreach(var blog in posts)
{
    Console.WriteLine(blog.PostId.ToString()+ "--"+blog.Title);
}*/


/*BlogPost SelPost=con.BlogPosts.FirstOrDefault(x=>x.PostId==6);
if(SelPost!=null){
    Console.WriteLine($"{SelPost.PostText}");
}
else{
    Console.WriteLine("No records");
}*/

//Console.WriteLine(con.BlogPosts.Count(p=>p.Title.Contains("Title"))); //no.of posts are there and text contains title
// var posts=con.BlogPosts.OrderByDescending(p=>p.PostId).ToList();
// foreach(var res in posts){
//     Console.WriteLine(res.Title);
// }

/*var posts=con.BlogPosts.OrderBy(p=>p.PostId).ThenBy(p=>p.PostText); //multiple columns can be sorted using orderby and then
foreach(var res in posts){
    Console.WriteLine(res.Title+"---"+res.PostText);
}*/

/*var comments=con.BlogComments.OrderBy(c=>c.CommentId).ToList();
foreach(var comm in comments){
    Console.WriteLine(comm.CommentText+"---"+comm.CommentId);
}
*/

/*var res=con.BlogComments.GroupBy(c=>c.PostId);
foreach(var grp in res){
    Console.WriteLine($"{grp.Key}-{grp.Count()}");
}
*/
//Adding new record to existing blogpost table
/*BlogPost newPost=new BlogPost();
newPost.Title="From Efcore2";
newPost.PostText="Efcore2 related post";
newPost.PostedBy="ramu";
con.BlogPosts.Add(newPost);*/
//con.SaveChanges(); //mandatory to update to db

//Adding new record with graph
/*BlogComment newcomment=new BlogComment();
newcomment.Title="Comment from efcore2";
newcomment.CommentText="Efcore2 comment text";
newcomment.CommentBy="raghu";
newPost.BlogComments.Add(newcomment);
con.SaveChanges();*/

//update operation
/*BlogPost SelBlogpost=con.BlogPosts.FirstOrDefault(p=>p.PostId==11);
if(SelBlogpost!=null){
    SelBlogpost.Title="orm ef title";
    con.SaveChanges();
}*/

//Delete Operation
/*BlogPost SelBlogpost=con.BlogPosts.FirstOrDefault(p=>p.PostId==8);
if(SelBlogpost!=null){
    con.BlogPosts.Remove(SelBlogpost);
    con.SaveChanges();
}*/

//to delete multiple post at once
/*BlogPost[] SelBlogpost=con.BlogPosts.Where(p=>p.PostId>=7 && p.PostId<10).ToArray();
if(SelBlogpost!=null){
    con.BlogPosts.RemoveRange(SelBlogpost);
    con.SaveChanges();
}
*/
/*var res=con.BlogPosts // late loading 
foreach(var blog in res){
    Console.WriteLine($"{blog.Title}-{blog.BlogComments.Count()}");
}*/

/*var res=con.BlogPosts.Include(p=>p.BlogComments); //eager loading
foreach(var blog in res){
    Console.WriteLine($"{blog.Title}-{blog.BlogComments.Count()}");
}*/

/*var res=con.BlogPosts.Include(c=>c.BlogComments).FirstOrDefault(p=>p.PostId==2);
if(res!=null){
    Console.WriteLine(res.BlogComments.Count());
}*/
//Eager loading explicit
/*var res=con.BlogPosts.FirstOrDefault(p=>p.PostId==2);
if(res!=null){
    con.Entry<BlogPost>(res).Collection(p=>p.BlogComments).Load();
    Console.WriteLine(res.BlogComments.Count());
}
*/

// Lazy Loading
/*var res=con.BlogPosts.FirstOrDefault(p=>p.PostId==2) ;// lazy loading 
Console.WriteLine(res.BlogComments.Count());
foreach(var blog in res.BlogComments){
    Console.WriteLine($"{blog.Title}");
}*/

//--->used to execute queries directly
//con.DataBase.ExecuteSql("Select * from BlogPost"); 

con.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);

/*
//Transaction
BlogPost blog=new BlogPost(){
    Title="TransDemo1",
    PostText="trans demo text",
    PostedBy="john"
};
var Trans=con.Database.BeginTransaction();
con.BlogPosts.Add(blog);
con.SaveChanges();
Trans.Commit(); //this will create a record
//Trans.RollBack();//This will not create the record
//if we use rollback or commit that is explicit transaction
//if we are not using any transaction that comes under implicit transaction
*/
