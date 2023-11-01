namespace Curso.Domain
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string BI { get; set; } = string.Empty;
        public Departamento Departamento { get; set; } = new();
    }
}