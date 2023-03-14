using Projeto03.Entidade;
using System;
using System.Reflection.PortableExecutable;

namespace Projeto03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro1;
            livro1 = new Livro();
            livro1.Autor = "Deus";
            livro1.Titulo = "Biblia";

            Livro livro2;
            livro2 = new Livro();
            livro2.Autor = "Joice";
            livro2.Titulo = "Mulheres";


            Livro livro3;
            livro3 = new Livro();
            livro3.Autor = "Lucinho";
            livro3.Titulo = "Jovens";


            Livro livro4 = new Livro();
            livro4.Autor = "Paty";
            livro4.Titulo = "Casamento";




        }
    }
}
