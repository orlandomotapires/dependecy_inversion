using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class ProjetoWeb : IProjetoWeb
    {
        private string content;
        private string css;
        private int port;

        public ProjetoWeb(string content, string css)
        {
            this.Content = content;
            this.Css = css;
        }

        public void gerarAmbiente()
        {
            Port = 8080;
            Console.WriteLine($"Ambiente gerado com sucesso! PORT: {Port}");
        }

        public string Content { get => content; set => content = value; }
        public string Css { get => css; set => css = value; }
        public int Port { get => port; set => port = value; }
    }
}
