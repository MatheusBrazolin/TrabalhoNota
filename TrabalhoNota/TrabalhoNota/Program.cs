using System;
using System.Collections.Generic;
using TrabalhoNota.Src;


namespace TrabalhoNota
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Filmes> filmes = new List<Filmes>(
                new Filmes[]{
                    new Acao("Piratas do Caribe","130 min","14+","Inglês"),
                    new Acao("Homem de ferro","124 min","12+","Inglês"),
                    new Acao("Logan","125 min","14+","Inglês"),
                    new Acao("Homem-Aranha","130 min","12+","Inglês"),
                    new Acao("Guerra mundial","110 min","14+","Ingles"),

                    new Animacao("Pocahontas","154 min","Livre","Inglês"),
                    new Animacao("Mulan","167 min", "Livre", "Inglês"),
                    new Animacao("Madagascar","100 min", "Livre", "Inglês"),
                    new Animacao("Peter Pan","77 min", "Livre", "Inglês"),
                    new Animacao("Tarzan","88 min", "Livre", "Inglês"),
                    
                    new Comedia("Imagine Só", "107 min", "Livre", "Inglês"),
                    new Comedia("O Filho da Noiva", "125 min", "Livre", "Inglês"),
                    new Comedia("Mr. Bean", "169 min", "Livre", "Inglês"),
                    new Comedia("10 Coisas Que Eu Odeio Em Você", "97 min", "12+", "Inglês"),
                    new Comedia("Click", "107 min", "10+", "Inglês"),

                    new Suspense("O espião que sabia de mais","100 min","14+","Inglês"),
                    new Suspense("O Silêncio dos Inocentes","118 min","16+","Inglês"),
                    new Suspense("O Sexto Sentido","107 min","16+","Inglês"),
                    new Suspense("A Origem","148 min","16+","Inglês"),
                    new Suspense("Seven - Os Sete Crimes Capitais","130 min","16+","Inglês"),

                    new Terror("Psicose","109 min","16+","Inglês"),
                    new Terror("Alien, o 8º Passageiro","116 min","18+","Inglês"),
                    new Terror("Invocação do Mal","110 min","18+","Inglês"),
                    new Terror("O Exorcista","121 min","18+","Inglês"),
                    new Terror("O Iluminado","143 min","18+","Ingles"),

                    new Romance("Cantando na Chuva", " 103 min", "Livre", "Inglês"),
                    new Romance("Sabrina", " 114 min", "Livre", "Inglês"),
                    new Romance("Bonequinha de luxo", " 114 min", "Livre", "Inglês"),
                    new Romance("A Princesa e o Plebeu ", " 118 min", "Livre", "Inglês"),
                    new Romance("Nothing Hill", " 124 min", "Livre", "Inglês"),

                    new Drama("Amor além da vida", "113 min", "Livre", "Inglês"),
                    new Drama("O Mutin", " 86 min", "Livre", "Inglês"),
                    new Drama("Cidade de Deus ", " 90 min", "+16", "Inglês"),
                    new Drama("Cisne negro", " 108 min", "+16", "Inglês"),
                    new Drama("Em nome do pai", " 133 min", "+16", "Inglês")

                }
            );

            foreach (Filmes filme in filmes)
            {
                Console.WriteLine(filme.ToString());
            }

            Console.WriteLine("Escolha por classificação: ");
            string classificacao = Console.ReadLine();

            foreach (Filmes filme in filmes)
            {
                if (filme.Classificacao.Contains(classificacao))
                {
                    Console.WriteLine(filme.ToString());
                }
            }
        }
    }
}
