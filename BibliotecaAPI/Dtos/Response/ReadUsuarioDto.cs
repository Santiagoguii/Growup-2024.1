﻿namespace BibliotecaAPI.Dtos.Response;

public class ReadUsuarioDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public List<int>? IdsEmprestimos { get; set; }
    public List<int>? IdsMultas { get; set; }
}
