using appIntegracaoUML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appIntegracaoUML.Business
{
    public class PagamentoService
    {
        public FolhaDePagamento GerarFolha(Funcionario funcionario, decimal horasExtras)
        {
            var folha = new FolhaDePagamento
            {
                FuncionarioId = funcionario.Id,
                Data = DateTime.Now,
                SalarioBase = funcionario.Salario,
                HorasExtras = horasExtras * 20, // Exemplo: R$20 por hora extra
                Descontos = 100 // Exemplo de desconto fixo
            };

            // Salvar folha de pagamento no banco de dados
            return folha;
        }
    }
}
