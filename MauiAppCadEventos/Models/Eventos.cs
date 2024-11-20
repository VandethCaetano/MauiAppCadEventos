using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCadEventos.Models
{
    public class Eventos
    {
        public string Nome { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int QntParticipantes { get; set; }
        public string Local { get; set; } = string.Empty;
        public int DuracaoEvento { get => DataTermino.Subtract(DataInicio).Days; }
        public double CustoParticipante => 75;
        public double CustoDiaria => CustoParticipante * QntParticipantes;
        public double CustoEvento
        {
            get
            {
                if (DuracaoEvento == 0)
                {
                    double Total = CustoDiaria; return Total;
                }
                else
                {
                    double Total = (CustoDiaria * DuracaoEvento) + CustoDiaria; return Total;
                }

            }
        }
    }
}
