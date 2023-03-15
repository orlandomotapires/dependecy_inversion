using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class Navegador
    {
        private string nome;
        private int velocidadeAcesso;
        private int ramAlocada;

        public Navegador(string nome, int velocidadeAcesso, int ramAlocada)
        {
            this.Nome = nome;
            this.VelocidadeAcesso = velocidadeAcesso;
            this.RamAlocada = ramAlocada;
        }

        public string Nome { get => nome; set => nome = value; }
        public int VelocidadeAcesso { get => velocidadeAcesso; set => velocidadeAcesso = value; }
        public int RamAlocada { get => ramAlocada; set => ramAlocada = value; }

        public void acessarInternet(IURL url)
        {
            Console.WriteLine($"Usando {Nome} para acessar o site {url.DNS1}");
        }

        public void exibirProjetoWeb(IProjetoWeb pw)
        {
            pw.gerarAmbiente();
            Console.WriteLine($"Segue o HTML solicitado: \n{pw.Content}");
        }

        
    }
}
