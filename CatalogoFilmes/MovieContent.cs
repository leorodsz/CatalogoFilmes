using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoFilmes
{
    internal class MovieContent
    {
        public static string Conteudo(string conteudo){
            switch (conteudo)
            {
                case "Minecraft":
                    return "Baseado no famoso jogo, o filme deve trazer uma aventura no universo pixelado de Minecraft, com Steve Carrell no elenco.";
                case "FNAF":
                    return "Um segurança noturno começa a trabalhar na pizzaria Freddy Fazbear’s e descobre que os animatrônicos ganham vida à noite, tornando-se aterrorizantes.";
                case "It the thing":
                    return "Baseado no livro de Stephen King, segue um grupo de crianças que enfrenta Pennywise, um palhaço demoníaco que se alimenta de seus medos.";
                default:
                    return "Filme não encontrado";
            }
        }

        public static string Horario(string horario)
        {
            switch (horario)
            {
                case "Minecraft":
                    return "Horário de sessão: 14:00h - 15:20";
                case "FNAF":
                    return "Horário de sessão: 16:00h - 18:15";
                case "It the thing":
                    return "Horário de sessão: 18:00h - 20:00h";
                default:
                    return "Horário de sessão indisponivel";
            }
        }

        public static string ImprimirIngresso(string filme)
        {
            string mensagem = " "; // Variável para armazenar a mensagem final

            if (filme == "Minecraft")
            {
                string caminhoArquivo = "voucher.txt";
                mensagem = "Ingresso impresso com sucesso para o filme do Minecraft. " + Horario("Minecraft") + Environment.NewLine;
                File.AppendAllText(caminhoArquivo, mensagem); // Salva no arquivo
            }
            else if (filme == "FNAF")
            {
                string caminhoArquivo = "voucher.txt";
                mensagem = "Ingresso impresso com sucesso para o filme do FNAF. " + Horario("FNAF") + Environment.NewLine;
                File.AppendAllText(caminhoArquivo, mensagem);
            }
            else if (filme == "It the thing")
            {
                string caminhoArquivo = "voucher.txt";
                mensagem = "Ingresso impresso com sucesso para o filme do It the thing. " + Horario("It the thing") + Environment.NewLine;
                File.AppendAllText(caminhoArquivo, mensagem);
            }
            else
            {
                mensagem = "Filme não encontrado. Não foi possível imprimir o ingresso." + Environment.NewLine;
                File.AppendAllText("voucher.txt", mensagem);
            }

            return mensagem;
        }
        }
    }