using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class Entidade
    {
        public int id = 0;
        public void loadFromDataString(string dataString)
        {
            string[] dados = dataString.Split(';');
            this.id = int.Parse(dados[0]);

        }

        public override string ToString()
        {
            return $"{id}";
        }
    }
}