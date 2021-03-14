using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    /// <summary>
    /// Design a class called Post.
    /// This class models a StackOverflow post. It should have properties for title, description and the date/time it was created. 
    /// We should be able to up-vote or down-vote a post. We should also be able to see the current vote value. 
    /// In the main method, create a post, up-vote and down-vote it a few times and then display the the current vote value. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var myPost = new Post
            {
                Title = "This is the title of my question",
                Description = "This is a simple description"
            };

            Console.WriteLine("Post '{0}' created at {1}\n{2}\n", myPost.Title, myPost.DateCreated, myPost.Description);
        }
    }
}
