using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoNota.Src
{
    internal class Animacao : Filmes
    {
        public Animacao() { }

        public Animacao(string nome, string duracao, string classificacao, string idiomas) : base(nome, duracao, classificacao, idiomas) { }

        public override string ToString()
        {
            return $"Nome do filme: {Nome} | Classificação: {Classificacao} | Duração do filme: {Duracao} | No idioma: {Idiomas}. ";
        }
    }
}