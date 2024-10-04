using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class Livro : Entidade
    {
        public string titulo = "Novo Livro";
        public string autor = "Autor";
        public string edicao = "Primeira Edição";
        public DateTime publicacao = DateTime.MinValue;

        public int corredor = 1;
        public int estante = 1;
        public int prateleira = 1;

        public bool disponivel = true;
        public bool perdido = false;
        public bool destruido = false;

        public new void loadFromDataString(string dataString)
        {
            string[] dados = dataString.Split(";");

            this.id = int.Parse(dados[0]);
            this.titulo = dados[1];
            this.autor = dados[2];
            this.edicao = dados[3];
            this.publicacao = DateTime.Parse(dados[4]);
            this.corredor = int.Parse(dados[5]);
            this.estante = int.Parse(dados[6]);
            this.prateleira = int.Parse(dados[7]);
            this.disponivel = bool.Parse(dados[8]);
            this.perdido = bool.Parse(dados[9]);
            this.destruido = bool.Parse(dados[10]);
        }

        public override string ToString()
        {
            return $"{id};{titulo};{autor};{edicao};{publicacao};{corredor};{estante};{prateleira};{disponivel};{perdido};{destruido}";
        }



    }
}