using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestObjectDatabaseMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var repo = new Repository((@"C:\Users\Arjun Garg\repo\libgit2sharp")))
            {
                Commit commit = repo.Lookup<Commit>("73b48894238c3e9c37f9f3a696bbd4bffcf45ce5");
                Console.WriteLine("Author: {0}", commit.Author.Name);
                Console.WriteLine("Message: {0}", commit.MessageShort);
            }
        }
    }
}
