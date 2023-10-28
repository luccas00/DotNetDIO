using Azure;
using Azure.Data.Tables;

namespace AzureTableWebAPI.Tabelas
{
    public class Personagem : ITableEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Especie { get; set; }
        public string Regiao { get; set; }
        public int Idade { get; set; }
        public bool Imortal { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }

        public Personagem(string nome)
        {
            this.RowKey = Guid.NewGuid().ToString();
            this.Nome = nome;
            this.Imortal = false;
            this.PartitionKey = this.RowKey;
            this.Idade = 0;
        }

    }
}
