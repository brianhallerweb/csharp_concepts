using System;

namespace StackOverflow
{
    class Post
    {
        public Post(string postTitle, string postDescription){
            title = postTitle;
            description = postDescription;
            createdAt = DateTime.Now;
        }
        public string title { get;}
        public string description { get; }
        public DateTime createdAt { get; }
        public int votes { get; private set; }

        public void upVote(){
            votes += 1;
        }
        public void downVote(){
            votes -= 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Post newPost = new Post("my title", "my description");
            newPost.upVote();
            newPost.upVote();
            newPost.upVote();
            newPost.downVote();

            Console.WriteLine(newPost.title);
            Console.WriteLine(newPost.description);
            Console.WriteLine(newPost.createdAt);
            Console.WriteLine(newPost.votes);
        }
    }
}
