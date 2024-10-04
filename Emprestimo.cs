using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class Emprestimo : Entidade
    {
        public DateTime dataEmprestimo = DateTime.Now;
        public DateTime dataDevolucao = DateTime.Now;
        public int idLivro = 0;
        public int idUsuario = 0;
        public bool devolvido = false;

        public new void loadFromDataString(string dataString)
        {
            string[] dados = dataString.Split(";");

            this.id = int.Parse(dados[0]);
            this.dataEmprestimo = DateTime.Parse(dados[1]);
            this.dataDevolucao = DateTime.Parse(dados[2]);
            this.idLivro = int.Parse(dados[3]);
            this.idUsuario = int.Parse(dados[4]);
            this.devolvido = bool.Parse(dados[5]);

        }

        public override string ToString()
        {
            return $"{id};{dataEmprestimo};{dataDevolucao};{idLivro};{idUsuario};{devolvido}";
        }

    }









}