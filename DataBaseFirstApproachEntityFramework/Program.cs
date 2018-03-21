using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
