using System;
using System.Threading.Tasks;
using System.Threading.Tasks;
using system.Linq;

namespace DataBaseFirstApproachEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PracticeSelfEntities();
            var post = new PostsTable()
            { Body="Body",
            DatePublished=DateTime.Now,
            Title="Title",
            PostID=1
            };            

            context.PostsTables.Add(post);
            context.SaveChanges();
            Console.WriteLine("jhfjcvdfbrgmthmtfdjddk");
        }
    }
}
