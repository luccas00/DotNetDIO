using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBancarias
{
    [Serializable]
    public sealed class Investimento
    {
        public decimal rendimento { get; private set; }
        public decimal aporteMensal { get; private set; }
        public decimal montante { get; private set; }

        public Investimento() { }
        public Investimento(decimal rendimento, decimal aporteMensal, decimal montante)
        {
            this.rendimento = rendimento;
            this.aporteMensal = aporteMensal;
            this.montante = montante;
        }

        public override string ToString()
        {
            return $"\n- - - - -\nRendimento {this.rendimento*100}%\n" +
                $"Aporte Mensal R$ {this.aporteMensal}\nMontante R$ {this.montante}";
        }
    }
}
