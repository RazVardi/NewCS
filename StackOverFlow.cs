using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UdemyStackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("Elon musk has cause Tesla and Bitcoin to fall",
                "Elon musk has cause Tesla and Bitcoin to fall because he said that:" +
                "Tesla has not sold any Bitcoin ");
            Console.WriteLine(post.UpVote());
            Console.WriteLine(post.UpVote());
            Console.WriteLine(post.UpVote());
            Console.WriteLine(post.UpVote());
            Console.WriteLine(post.DownVote());
            Console.WriteLine(post.UpVote());
            Console.WriteLine(post.DownVote());
            Console.WriteLine(post.UpVote());
            Console.WriteLine(post.DownVote());
            Console.WriteLine(post.RateVote());
            Thread.Sleep(35000);
        }
    }

    class Post
    {
        private String title;
        private String description;
        private DateTime date;
        private int rateVote=0;
        public Post(String title,String desription) 
        {
            this.title = title;
            this.description = desription;
            this.date = DateTime.Now;
        }
        public string Title 
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
            
        }
        public int UpVote()
        {
            return ++rateVote; 
        }
        public int DownVote()
        {
            return --rateVote;
        }
        public int RateVote()
        {
            return rateVote;
        }
}
