using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appIntegracaoUML.Models
{
    public class FolhaDePagamento
    {
        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public DateTime Data { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal Descontos { get; set; }
        public decimal HorasExtras { get; set; }
        public decimal Total => SalarioBase + HorasExtras - Descontos;
    }
}
