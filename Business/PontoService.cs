using appIntegracaoUML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appIntegracaoUML.Business
{
    public class PontoService
    {
        public void RegistrarPonto(ControleDePonto ponto)
        {
            // Código para salvar o registro de ponto
        }

        public decimal CalcularHorasExtras(TimeSpan entrada, TimeSpan saida)
        {
            TimeSpan jornadaNormal = new TimeSpan(8, 0, 0); // 8 horas por dia
            TimeSpan horasTrabalhadas = saida - entrada;

            return horasTrabalhadas > jornadaNormal
                   ? (horasTrabalhadas - jornadaNormal).Hours
                   : 0;
        }
    }
}
