using System;
using Exercicio_Enumeracao_Composicao_2.Entities;
using System.Globalization;

namespace Exercicio_Enumeracao_Composicao_2
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            string title = "Traveling to New Zealand";
            string content = "I'm going to visit this wonderful country!";
            int likes = 12;
            DateTime date = DateTime.ParseExact("21/06/2018 13:05:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Post post1 = new Post(date, title, content, likes);
            post1.AddComment(c1);
            post1.AddComment(c2);

            Console.WriteLine(post1);

            
        }
    }
}
