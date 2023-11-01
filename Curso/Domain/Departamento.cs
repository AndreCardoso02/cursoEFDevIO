namespace Curso.Domain
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public bool Activo { get; set; }

        // adicionando reelacionamentos
        public List<Funcionario> Funcionarios { get; set; } = new();
    }
}