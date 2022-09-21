using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Enumeracao_Composicao_2.Entities
{
    internal class Post
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }
        public Post(DateTime date, string title, string content, int likes)
        {
            Date = date;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder postContent = new StringBuilder();
            postContent.AppendLine($"{Title}" +
                $"\n{Likes} Likes - {Date}" +
                $"\n{Content}" +
                $"\nComments:");
            foreach (Comment comment in Comments)
            {
                postContent.AppendLine(comment.Text);
            }
            return postContent.ToString();

        }
    }
}
