namespace Emprestimo.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public string? UsuarioId { get; set; }
        public string? LivroId { get; set; }
        public DateTime LoanDate { get; set; }
        public bool IsReturned { get; set; }
    }


}
