using System;
using System.Collections.Generic;
using System.Text;

namespace ExStringBuilder.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>(); // Como um post pode ter varios comentarios, criamos uma lista pra armazenar estes. Uma relação um para muitos.
        
        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comentario comment)
        {
            Comentarios.Add(comment);
        }
        public void RemoveComment(Comentario comment)
        {
            Comentarios.Remove(comment);
        }
        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Title}\n{Likes} likes - {Moment.ToString("dd/MM/yyyy HH:mm:ss")}\n{Content}\nComments:");
            foreach(Comentario comm in Comentarios)
            {
                sb.AppendLine(comm.Comment);
            }
            return sb.ToString();
        }
    }
}
