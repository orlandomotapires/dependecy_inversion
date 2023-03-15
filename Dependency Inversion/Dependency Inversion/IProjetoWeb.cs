namespace Dependency_Inversion
{
    internal interface IProjetoWeb
    {
        string Content { get; set; }
        string Css { get; set; }

        void gerarAmbiente();
    }
}