using System;
using ExStringBuilder.Entities;

namespace ExStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Comentario c1 = new Comentario("Good Nigth");
            Comentario c2 = new Comentario("Tenha uma boa viagem!");
            Post p1 = new Post(
                 DateTime.Parse("22-12-1999 13:05:44"),
                 "Viagem para Europa",
                 "Estou indo viajar para Europa",
                 12
                 );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comentario c3 = new Comentario("Balada Hoje a noite");
            Comentario c4 = new Comentario("Tenha uma boa festa!");
            Post p2 = new Post(
                 DateTime.Parse("22-12-1995 19:05:44"),
                 "Balada",
                 "Estou indo para a festa",
                 12
                 );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            string a = Console.ReadLine();
        }
    }
}
