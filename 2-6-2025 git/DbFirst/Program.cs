// See https://aka.ms/new-console-template for more information
using DbFirst;
 BlogAppDelContext ctx=new BlogAppDelContext();
 var res=ctx.BlogPosts;
  foreach (var blogPost in res)
 {
     Console.WriteLine(blogPost.PostId);
 }
