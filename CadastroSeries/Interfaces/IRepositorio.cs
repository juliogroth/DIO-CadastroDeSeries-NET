//Interface Repositorio sere para determinar que as classes que implementem essa interface possuirão os métodos
//listados abaixo...

using System.Collections.Generic;

namespace CadastroSeries.Interfaces
{
    public interface IRepositorio<T> //essa classe implementa um repositório desta outra classe T
    {
        List<T> Lista(); //método chamado Lista que retorna uma lista de T
        T RetoraPorId(int id); //passa um Id por parametro e ele retora um T
        void Insere (T entidade);
        void Exclui (int id);
        void Atualiza (int id, T entidade);
        int ProximoId();
    }
}