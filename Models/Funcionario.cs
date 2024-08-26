using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appIntegracaoUML.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
    }
}
