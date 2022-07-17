
using series.src.entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("NET-FILMES");
        DateTime dia = new DateTime(2022, 07, 10);
        Filmes filme1 = new Filmes(1,"Stranger Things", "Terror",dia,19.0);     
        Filmes filme2 = new Filmes(2,"The Stranger", "Terror",dia,15.0);
        Filmes filme3 = new Filmes(3,"Lord of The Rings", "Fantasy",dia,15.0);
        Filmes filme4 = new Filmes(4,"A Rainha dos condenados", "Fantasy",dia,300);  
        locacao Todos = new locacao(); 

       // Todos.locando(filme1);          
       // Todos.msg(); 
       // Todos.total(); 

        SeiesRepository sr = new SeiesRepository();
        sr.Insere(1,filme1);
        sr.Insere(2,filme2);
        sr.Insere(3,filme3);
         sr.Insere(4,filme4);
        sr.Atualizar(4,filme1);
         // other methods
        //sr.Excluir(2,filme2);
        //sr.RetornarPorId(0); 
                
        sr.Listar();
       

                         
   


       
    }
}