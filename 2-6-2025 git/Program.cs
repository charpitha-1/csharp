using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        { //creating a object for context
            BlogAppDelEntities ctx = new BlogAppDelEntities();
            //access the database
            var blogPosts=ctx.BlogPosts;
            foreach (var blogPost in blogPosts)
            {
                Console.WriteLine(blogPost.PostID);
            }
        }
    }
}
