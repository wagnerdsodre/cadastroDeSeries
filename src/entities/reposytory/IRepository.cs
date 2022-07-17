using System.Collections.Generic;


namespace series.src.entities.reposytory
{
    public interface IRepository<Filmes>
    {
         void Listar();
        
        public void Insere(int d, Filmes filmes);
        void Excluir(int id, Filmes filme);

        public void Atualizar(int id,Type filmes);

        void ProximoId();

        void RetornarPorId(int id);


    }
}