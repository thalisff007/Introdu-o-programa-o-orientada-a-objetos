using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class Usuario : Entidade
    {
        public string nome = "Novo Usuário";
        public string telefone = "";
        public string endereco = "";
        public string email = "";
        public bool banido = false;

        public new void loadFromDataString(string dataString)
        {
            string[] dados = dataString.Split(";");

            this.id = Convert.ToInt32(dados[0]);
            this.nome = dados[1];
            this.telefone = dados[2];
            this.endereco = dados[3];
            this.email = dados[4];
            this.banido = Convert.ToBoolean(dados[5]);
        }

        public override string ToString()
        {
            return $"{id};{nome};{telefone};{endereco};{email};{banido}";
        }
    }
}