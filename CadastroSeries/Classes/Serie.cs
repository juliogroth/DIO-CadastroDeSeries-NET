using System;

namespace CadastroSeries
{
    public class Serie : EntidadeBase //Significa que a classe série HERDA definiçoes de EntidadeBase
                                      //(no caso apenas o ID)
    {
         //Atributos

         private Genero Genero{get ; set; }
         private string Titulo{get; set; }
         private string Descricao{get; set; }
        private int Ano{get; set; }
        private bool Excluido{get; set; }
    
        //Métodos:

        //* CONSTRUTOR

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            //para quando tentar dar um writeline é executada essa ação, 
            //ver descriç]ao do enviroment newline na doc da microsoft
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido + Environment.NewLine;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo; //só devolve o título do objeto em questao
        }

        public int retornaId()
        {
            return this.Id; //só retorna o ID do objeto em questao, para nao ficar alterando o ID
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

        public bool retornaExcluido() //inseri para verificar se na hora de listar as séries o item que será
        //impresso esta marcado como excluido ou nao.
        {
            return this.Excluido;
        }
    }

}   