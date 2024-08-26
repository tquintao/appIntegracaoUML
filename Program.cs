using appIntegracaoUML.Business;
using appIntegracaoUML.Models;

public class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario { Id = 1, Nome = "João", Salario = 3000 };
        ControleDePonto ponto = new ControleDePonto { FuncionarioId = funcionario.Id, Data = DateTime.Today, HoraEntrada = new TimeSpan(8, 0, 0), HoraSaida = new TimeSpan(18, 0, 0) };

        PontoService pontoService = new PontoService();
        pontoService.RegistrarPonto(ponto);
        decimal horasExtras = pontoService.CalcularHorasExtras(ponto.HoraEntrada, ponto.HoraSaida);

        PagamentoService pagamentoService = new PagamentoService();
        FolhaDePagamento folha = pagamentoService.GerarFolha(funcionario, horasExtras);

        Console.WriteLine($"Folha de Pagamento - Funcionario: {funcionario.Nome}");
        Console.WriteLine($"Salario Base: {folha.SalarioBase}");
        Console.WriteLine($"Horas Extras: {folha.HorasExtras}");
        Console.WriteLine($"Descontos: {folha.Descontos}");
        Console.WriteLine($"Total: {folha.Total}");
    }
}
