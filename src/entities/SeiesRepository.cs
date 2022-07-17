
using series.src.entities.reposytory;
using System.Collections.Concurrent;


namespace series.src.entities
{
    public class SeiesRepository : IRepository<Filmes>
    {

       // private List<Filmes> ListaFilmes = new List<Filmes>();
        ConcurrentDictionary<int, Filmes> ListaFilmes =  new ConcurrentDictionary<int, Filmes>();

        Filmes? filme = null;
        public void Excluir(int id, Filmes filme)
        {

         
          bool value =  ListaFilmes.Remove(id, out this.filme);
              
            
        }       

        public void Listar()
        {
            foreach( KeyValuePair<int, Filmes> f in ListaFilmes )
                {
            Console.WriteLine("chave = {0}, valor = {1}", f.Key, f.Value);
                }  
        }
        public void ProximoId() { }
       
        public void RetornarPorId(int id)
        {
            foreach( KeyValuePair<int, Filmes> f in ListaFilmes )
                {
            Console.WriteLine("==================");
            Console.WriteLine("Retornando por id chave = {0}, valor = {1}", f.Key, f.Value);
                }
            
         
        }
      
        public void Atualizar(int id, Filmes filme)
        {   
          
             ListaFilmes.TryUpdate(id,filme, ListaFilmes[id]);
          

            Console.WriteLine("Registro Atualizado");
        }

        internal void Insere(int id, Filmes filme)
        {
             ListaFilmes.TryAdd(id, filme);
        }
        
       //*******************
        void IRepository<Filmes>.Insere(int id, Filmes entidade)
        {
            throw new NotImplementedException();
        }

        void IRepository<Filmes>.Atualizar(int id, Type entidade)
        {
            throw new NotImplementedException();
        }
    }
}