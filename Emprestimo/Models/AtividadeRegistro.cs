namespace Emprestimo.Models
{
    public class AtividadeRegistro
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string? TipoAtividade { get; set; } // "Empréstimo" ou "Devolução"
        public string? LivroId { get; set; }
        public string? UsuarioId { get; set; }
    }

}
