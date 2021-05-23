// Entidade Base será uma classe abstrata que será utilizada por todas as outras classes do projeto


namespace CadastroSeries
{
    public abstract class EntidadeBase
    {
        public int Id {get; protected set;} //a classe só é pra ter um ID, para que todos que herdarem a classe já
        //tenham esse ID definido.
        //Esta como protected para ser acessado apenas dentro dessa dll (relembrar conceitos de classe Private, public,...)
    }
}