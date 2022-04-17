using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoNota.Src
{
        public class Filmes
        {
            public string Nome { get; set; }
            public string Duracao { get; set; }
            public string Classificacao { get; set; }
            public string Idiomas { get; set; }

            public Filmes() { }

            public Filmes(string nome, string duracao, string classificacao, string idiomas)
            {
                Nome = nome;
                Duracao = duracao;
                Classificacao = classificacao;
                Idiomas = idiomas;
            }

            public override string ToString()
            {
                return $"Nome do filme: {Nome} | Classificação: {Classificacao} | Duração do filme: {Duracao} | No idioma: {Idiomas}. ";
            }
        }
    }
