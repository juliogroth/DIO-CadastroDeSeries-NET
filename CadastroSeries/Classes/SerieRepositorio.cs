// O REPOSITORIO serve para fazer um meio de campo entre as funções diversas que devem ser chamadas pra 
//executar as operações que preciso. Isso torna mais facil a manutenção e organização e implementação de novas
// funcionalidades.


using System;
using System.Collections.Generic;
using CadastroSeries.Interfaces;

namespace CadastroSeries
{
    public class SerieRepositorio : IRepositorio<Serie> //assim o que for passado em <Serie> será interpretado 
                                                        //dentro de <T> no IRepositorio...
                                                        //aqui traduz que a SerieRepositorio esta implementado o IRespositorio de Serie
    {
        private List<Serie> listaSerie = new List<Serie>(); //essa vai ser a lista que vai conter todas
                                                            //as minhas series.
                                            //aqui está no repositorio, para fazer o desenvolvimento em camadas

        public void Atualiza(int id, Serie objeto) //onde era T já trocou por Serie
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count; //um atalho, o tamanho do vetor é um acima da posicao do vetor, pois o vetor
            //é feito em base zero. exemplo, string[5] tem 6 posições...
        }

        public Serie RetoraPorId(int id)
        {
            return listaSerie[id];
        }
    }
}